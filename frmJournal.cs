using System;
using System.Data;
using System.Windows.Forms;

namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    public partial class frmJournal : Form
    {
        private string m_nomPlanete;
        private int m_numeroMission;
        private BindingSource m_bsJournal = new BindingSource();

        public frmJournal(string nomPlanete, int numeroMission)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Style.InitControles(this);
            m_nomPlanete = nomPlanete;
            m_numeroMission = numeroMission;
        }

        private void frmJournal_Load(object sender, EventArgs e)
        {
            DataRow[] drJournal = MesDatas.DsGlobal.Tables["JournalDeBord"].Select(
                $"nomPlanete = '{m_nomPlanete}' AND numero = {m_numeroMission}",
                "dateJ ASC");

            if (drJournal.Length == 0)
            {
                lblEventJournal.Text = "Aucun événement enregistré pour cette mission.";
                lblCompteur.Text = "0 événement";
                
                btnPrecedent.Enabled = false;
                btnSuivant.Enabled = false;
                btnTTdebut.Enabled = false;
                btnTTfin.Enabled = false;

                return;
            }

            DataTable dtJournal = drJournal.CopyToDataTable();
            m_bsJournal.DataSource = dtJournal;

            lblEventJournal.DataBindings.Add("Text", m_bsJournal, "commentaires");
            dtEventJournal.DataBindings.Add("Value", m_bsJournal, "dateJ", true);

            m_bsJournal.PositionChanged += new EventHandler(bsJournal_PositionChanged);

            MettreAJourCompteur();
        }

        private void bsJournal_PositionChanged(object sender, EventArgs e)
        {
            MettreAJourCompteur();
        }

        private void MettreAJourCompteur()
        {
            int position = m_bsJournal.Position +1;
            int total = m_bsJournal.Count;

            lblCompteur.Text = $"Événement {position} / {total}";

            btnTTdebut.Enabled = (m_bsJournal.Position> 0);
            btnPrecedent.Enabled = (m_bsJournal.Position> 0);

            btnSuivant.Enabled = (m_bsJournal.Position< total -1);
            btnTTfin.Enabled = (m_bsJournal.Position< total -1);
        }

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
