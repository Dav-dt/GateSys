using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace saeStargateTUAILLON_LONGO_YURTSEBEN.control
{
    public partial class Mission : UserControl
    {
        private string m_nomPlanete;
        private int m_numMission;

        public Mission()
        {
            InitializeComponent();
        }
        public Mission(string nomPlanete, int numMission, string dateDepart, string dateFin, string commandant, string budget)
        {
            InitializeComponent();
            lblNomMission.Text = $"{nomPlanete}-{numMission}" ;
            lblDateDepart.Text = dateDepart;
            lblDateFin.Text = dateFin;
            lblNomCapitaine.Text = commandant;
            lblbudget.Text = budget;
            pbPlanete.SizeMode = PictureBoxSizeMode.StretchImage;
            m_nomPlanete = nomPlanete;
            m_numMission = numMission;

            switch ( m_nomPlanete )
            {
                case "mercure":
                    pbPlanete.Image = Properties.Resources.mercury;
                    break;

                case "Vénus":
                    pbPlanete.Image = Properties.Resources.venus;
                    break;
                case "Terre":
                    pbPlanete.Image = Properties.Resources.earth;
                    break;
                case "Mars":
                pbPlanete.Image = Properties.Resources.mars;
                break;
                case "Jupiter":
                    pbPlanete.Image = Properties.Resources.jupiter;
                    break;
                case "Saturne":
                    pbPlanete.Image = Properties.Resources.saturne;
                    break;
                case "Uranus":
                    pbPlanete.Image = Properties.Resources.uranus;
                    break;
                case "Neptune":
                    pbPlanete.Image = Properties.Resources.neptune;
                    break;
                case "La 9ème planète":
                    pbPlanete.Image = Properties.Resources._9planete;
                    break;

                case "Kobaia":
                    pbPlanete.Image = Properties.Resources.Kobaia;
                    break;

                case "Setna":
                    pbPlanete.Image = Properties.Resources.setna;
                    break;
                case "Malaria":
                    pbPlanete.Image = Properties.Resources.Malaria;
                    break;
                case "Aurae":
                    pbPlanete.Image = Properties.Resources.Aurae;
                    break;

                case "Aina":
                    pbPlanete.Image = Properties.Resources.Aina;
                    break;
                case "Sckxyss":
                    pbPlanete.Image = Properties.Resources.Sckxyss;
                    break;
                case "Sohia":
                    pbPlanete.Image = Properties.Resources.Sohia;
                    break;
                case "Muh":
                    pbPlanete.Image = Properties.Resources.Muh;
                    break;

                default:
                    pbPlanete.Image = Properties.Resources.pengu;
                    break;
            }
        }


        private void Mission_Load(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmFicheMission frmFicheMission = new
                frmFicheMission(m_nomPlanete, m_numMission);
            frmFicheMission.Show();
        }

        private void btnGenererPdf_Click(object sender, EventArgs e)
        {
            // boite dialogue
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF|*.pdf";
            sfd.FileName = "Rapport_" + m_nomPlanete + "_" + m_numMission + ".pdf";

            // Annule on fait retour
            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            // Crée pdf 
            Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
            PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
            doc.Open();

            // Taille 
            iTextSharp.text.Font fontTitre = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            iTextSharp.text.Font fontSousTitre = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
            iTextSharp.text.Font fontNormal = FontFactory.GetFont(FontFactory.HELVETICA, 10);
            iTextSharp.text.Font fontGras = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);

            // Récuperations  infos 
            DataRow[] drMission = MesDatas.DsGlobal.Tables["Mission"].Select(
                $"numero = {m_numMission} AND nomPlanete = '{m_nomPlanete}'");

            if (drMission.Length == 0)
            {
                MessageBox.Show("Mission introuvable.");
                doc.Close();
                return;
            }

            DataRow mission = drMission[0];

            // Chef de Mission
            string matriculeChef = mission["matriculeChef"].ToString();
            DataRow[] drChef = MesDatas.DsGlobal.Tables["Membre"].Select(
                $"matricule = '{matriculeChef}'");
            string nomChef = drChef.Length > 0
                ? drChef[0]["nom"] + " " + drChef[0]["prenom"]
                : "Inconnu";

            // Budget
            int budgetInitial = Convert.ToInt32(mission["budget"]);
            DataRow[] drToutesDepenses = MesDatas.DsGlobal.Tables["Depense"].Select(
                $"nomPlanete = '{m_nomPlanete}' AND numeroMission = {m_numMission}");
            int totalDepenses = 0;
            foreach (DataRow dep in drToutesDepenses)
                totalDepenses += Convert.ToInt32(dep["montant"]);
            int budgetRestant = budgetInitial - totalDepenses;

            // Titre rapport
            doc.Add(new Paragraph("Rapport de mission", fontTitre));
            doc.Add(new Paragraph(m_nomPlanete + " - " + m_numMission, fontTitre));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("------------------------------------------------", fontNormal));
            doc.Add(new Paragraph(" "));

            // La Date
            doc.Add(new Paragraph("Date de départ : " + mission["dateDepart"], fontNormal));
            doc.Add(new Paragraph("Date de retour prévue : " + mission["dateRetour"], fontNormal));
            doc.Add(new Paragraph("Responsable : " + nomChef, fontNormal));
            doc.Add(new Paragraph("Budget initial : " + budgetInitial + " $DG", fontNormal));
            doc.Add(new Paragraph("Budget restant : " + budgetRestant + " $DG", fontNormal));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("Feuille de route :", fontGras));
            doc.Add(new Paragraph(mission["feuilleDeRoute"].ToString(), fontNormal));
            doc.Add(new Paragraph(" "));

            // Liste  membres
            doc.Add(new Paragraph("------------------------------------------------", fontNormal));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("Liste des membres", fontSousTitre));
            doc.Add(new Paragraph(" "));

            DataRow[] drComposer = MesDatas.DsGlobal.Tables["Composer"].Select(
                $"nomPlanete = '{m_nomPlanete}' AND numeroMission = {m_numMission}");

            foreach (DataRow rowComposer in drComposer)
            {
                string mat = rowComposer["matriculeMembre"].ToString();
                DataRow[] drInfo = MesDatas.DsGlobal.Tables["Membre"].Select(
                    $"matricule = '{mat}'");

                if (drInfo.Length > 0)
                {
                    string nomMembre = drInfo[0]["nom"] + " " + drInfo[0]["prenom"];
                    
                    string type = mat.StartsWith("M") ? "Militaire" : "Civil";
                    doc.Add(new Paragraph("  --> " + nomMembre + " (" + type + ")", fontNormal));
                }
            }
            doc.Add(new Paragraph(" "));

            // Journal de bord
            doc.Add(new Paragraph("------------------------------------------------", fontNormal));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("Journal de bord", fontSousTitre));
            doc.Add(new Paragraph(" "));

            DataRow[] drJournal = MesDatas.DsGlobal.Tables["JournalDeBord"].Select(
                $"nomPlanete = '{m_nomPlanete}' AND numero = {m_numMission}", "dateJ ASC");

            if (drJournal.Length == 0)
            {
                doc.Add(new Paragraph("Aucun événement enregistré.", fontNormal));
            }
            else
            {
                foreach (DataRow ev in drJournal)
                {
                    string date = Convert.ToDateTime(ev["dateJ"]).ToString("dd/MM/yyyy");
                    doc.Add(new Paragraph("  Le " + date + " --> " + ev["commentaires"], fontNormal));
                }
            }
            doc.Add(new Paragraph(" "));

            // Dépenses effectuées
            doc.Add(new Paragraph("------------------------------------------------", fontNormal));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("Dépenses effectuées", fontSousTitre));
            doc.Add(new Paragraph(" "));

            DataRow[] drDepenses = MesDatas.DsGlobal.Tables["Depense"].Select(
                $"nomPlanete = '{m_nomPlanete}' AND numeroMission = {m_numMission}", "dateD ASC");

            if (drDepenses.Length == 0)
            {
                doc.Add(new Paragraph("Aucune dépense enregistrée.", fontNormal));
            }
            else
            {
                int compteur = 1;
                foreach (DataRow dep in drDepenses)
                {
                    string date = Convert.ToDateTime(dep["dateD"]).ToString("dd/MM/yyyy");
                    doc.Add(new Paragraph(
                        "  " + compteur + ") le " + date + " : " + dep["motif"] + " -> " + dep["montant"] + " $DG",
                        fontNormal));
                    compteur++;
                }
                doc.Add(new Paragraph("  Total : " + totalDepenses + " $DG", fontGras));
            }
            doc.Add(new Paragraph(" "));

            // Contacts informateurs
            doc.Add(new Paragraph("------------------------------------------------", fontNormal));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("Contacts avec les informateurs", fontSousTitre));
            doc.Add(new Paragraph(" "));

            DataRow[] drContacts = MesDatas.DsGlobal.Tables["Contact"].Select(
                $"nomPlanete = '{m_nomPlanete}' AND numeroMission = {m_numMission}", "dateC ASC");

            if (drContacts.Length == 0)
            {
                doc.Add(new Paragraph("Aucun contact enregistré.", fontNormal));
            }
            else
            {
                int totalVerse = 0;
                foreach (DataRow contact in drContacts)
                {
                    string date = Convert.ToDateTime(contact["dateC"]).ToString("dd/MM/yyyy");
                    int somme = Convert.ToInt32(contact["sommeVersee"]);
                    doc.Add(new Paragraph(
                        "  Le " + date + " : " + contact["nomCodeInformateur"]
                        + " -> " + somme + " $DG (" + contact["appreciation"] + ")",
                        fontNormal));
                    totalVerse += somme;
                }
                doc.Add(new Paragraph("  Total versé : " + totalVerse + " $DG", fontGras));
            }
            doc.Add(new Paragraph(" "));

            // Bilan captures
            doc.Add(new Paragraph("------------------------------------------------", fontNormal));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("Bilan des captures", fontSousTitre));
            doc.Add(new Paragraph(" "));

            DataRow[] drObjectifs = MesDatas.DsGlobal.Tables["ObjectifCapture"].Select(
                $"nomPlanete = '{m_nomPlanete}' AND numeroMission = {m_numMission}");

            if (drObjectifs.Length == 0)
            {
                doc.Add(new Paragraph("Aucun objectif de capture défini.", fontNormal));
            }
            else
            {
                doc.Add(new Paragraph("  Espèce | Objectif | Réalisé | Taux", fontGras));

                foreach (DataRow obj in drObjectifs)
                {
                    int idEspece = Convert.ToInt32(obj["idEspeceEnnemi"]);
                    int objectif = Convert.ToInt32(obj["objectif"]);

                    DataRow[] drEspece = MesDatas.DsGlobal.Tables["Espece"].Select($"id = {idEspece}");
                    string nomEspece = drEspece.Length > 0 ? drEspece[0]["nom"].ToString() : "?";

                    DataRow[] drCaptures = MesDatas.DsGlobal.Tables["Capturer"].Select(
                        $"nomPlanete = '{m_nomPlanete}' AND numeroMission = {m_numMission} AND idEspeceEnnemi = {idEspece}");
                    int nombreReel = drCaptures.Length > 0 ? Convert.ToInt32(drCaptures[0]["nombre"]) : 0;

                    int taux = objectif > 0 ? (int)((double)nombreReel / objectif * 100) : 0;

                    doc.Add(new Paragraph(
                        "  " + nomEspece + " | " + objectif + " | " + nombreReel + " | " + taux + " %",
                        fontNormal));
                }
            }
            doc.Close();
            MessageBox.Show("PDF généré avec succès !\n" + sfd.FileName);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Définir la couleur et l'épaisseur du pinceau
            Color couleurBordure = Color.FromArgb(243, 214, 144);
            int epaisseurBordure = 2;

            // Créer le "stylo" (Pen)
            using (Pen pen = new Pen(couleurBordure, epaisseurBordure))
            {
                // On ajuste légèrement le rectangle pour que la bordure ne soit pas coupée par les bords du contrôle
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(
                    epaisseurBordure / 2,
                    epaisseurBordure / 2,
                    this.Width - epaisseurBordure,
                    this.Height - epaisseurBordure
                );

                // On dessine le rectangle sur le UserControl
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
    }
}
