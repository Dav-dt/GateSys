using System;
using System.Data;
using System.Windows.Forms;

namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    public partial class frmJournal : Form
    {
        // Nom de la planète et numéro de mission transmis par la fiche mission
        private string m_nomPlanete;
        private int m_numeroMission;

        // BindingSource : permet de naviguer dans les événements sans requêter la BDD
        private BindingSource m_bsJournal = new BindingSource();

        public frmJournal(string nomPlanete, int numeroMission)
        {
            InitializeComponent();
            m_nomPlanete = nomPlanete;
            m_numeroMission = numeroMission;
        }

        private void frmJournal_Load(object sender, EventArgs e)
        {
            // Filtrage des événements de la mission depuis le DataSet local (trié par date)
            DataRow[] drJournal = MesDatas.DsGlobal.Tables["JournalDeBord"].Select(
                $"nomPlanete = '{m_nomPlanete}' AND numero = {m_numeroMission}",
                "dateJ ASC");

            // Si aucun événement : on affiche un message et on désactive la navigation
            if (drJournal.Length == 0)
            {
                lblEventJournal.Text = "Aucun événement enregistré pour cette mission.";
                lblCompteur.Text = "0 événement";
                ActiverBoutons(false);
                return;
            }

            // Copie des lignes filtrées dans un DataTable local, puis liaison au BindingSource
            DataTable dtJournal = drJournal.CopyToDataTable();
            m_bsJournal.DataSource = dtJournal;

            // Liaison de données : les contrôles se mettent à jour automatiquement lors
            // de la navigation (MoveNext, MovePrevious...), sans accès à la base de données
            lblEventJournal.DataBindings.Add("Text", m_bsJournal, "commentaires");
            dtEventJournal.DataBindings.Add("Value", m_bsJournal, "dateJ", true);

            // Abonnement à l'événement déclenché à chaque changement de position
            m_bsJournal.PositionChanged += new EventHandler(bsJournal_PositionChanged);

            // Affichage initial du compteur et état des boutons
            MettreAJourCompteur();
        }

        // Appelée à chaque fois que l'utilisateur change d'événement
        private void bsJournal_PositionChanged(object sender, EventArgs e)
        {
            MettreAJourCompteur();
        }

        // Met à jour le label "Événement X / Y" et active/désactive les boutons de navigation
        private void MettreAJourCompteur()
        {
            int position = m_bsJournal.Position + 1; // La position commence à 0, on affiche à partir de 1
            int total = m_bsJournal.Count;

            lblCompteur.Text = $"Événement {position} / {total}";

            // Désactiver "Début" et "Précédent" si on est déjà au premier événement
            btnTTdebut.Enabled  = (m_bsJournal.Position > 0);
            btnPrecedent.Enabled = (m_bsJournal.Position > 0);

            // Désactiver "Suivant" et "Fin" si on est déjà au dernier événement
            btnSuivant.Enabled = (m_bsJournal.Position < total - 1);
            btnTTfin.Enabled   = (m_bsJournal.Position < total - 1);
        }

        // Active ou désactive tous les boutons de navigation d'un seul coup
        private void ActiverBoutons(bool actif)
        {
            btnTTdebut.Enabled  = actif;
            btnPrecedent.Enabled = actif;
            btnSuivant.Enabled  = actif;
            btnTTfin.Enabled    = actif;
        }

        // --- Boutons de navigation (data binding : aucune requête BDD) ---

        private void btnTTdebut_Click(object sender, EventArgs e)
        {
            m_bsJournal.MoveFirst();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            m_bsJournal.MovePrevious();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            m_bsJournal.MoveNext();
        }

        private void btnTTfin_Click(object sender, EventArgs e)
        {
            m_bsJournal.MoveLast();
        }

        // --- Boutons d'accès aux sous-formulaires ---

        private void btnDepenses_Click(object sender, EventArgs e)
        {
            frmJournalDepenses frmDep = new frmJournalDepenses(m_nomPlanete, m_numeroMission);
            frmDep.Show();
        }

        private void btnIndics_Click(object sender, EventArgs e)
        {
            frmJournalIndics frmInd = new frmJournalIndics(m_nomPlanete, m_numeroMission);
            frmInd.Show();
        }

        private void btnCapturesAfficher_Click(object sender, EventArgs e)
        {
            frmJournalCaptures frmCap = new frmJournalCaptures(m_nomPlanete, m_numeroMission);
            frmCap.Show();
        }
    }
}
