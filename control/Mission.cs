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
                case "La 9ème Planète":
                    pbPlanete.Image = Properties.Resources.pengu;
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
            // Création de la boite dialogue 
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF|*.pdf";
            sfd.FileName = " Rapport_" + m_nomPlanete + "_" + m_numMission + ".pdf";

            // Annule on fait retour 
            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            // Crée un doc pdf en format A4
            Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
            PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
            doc.Open();

            // Taille du pdf 
            iTextSharp.text.Font fontTitre = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            iTextSharp.text.Font fontGras = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
            iTextSharp.text.Font fontNormal = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11);

            // Récuperations des infos de la mission ( DataSet )
            DataRow[] drMission = MesDatas.DsGlobal.Tables["Mission"].Select(
                "numéro = " + m_numMission + " Et nomPlanète = ' " + m_nomPlanete + " ' ");

            // Titre rapport 
            doc.Add(new Paragraph(" Rapport de mission : " + m_nomPlanete + " _ " + m_numMission, fontTitre));
            doc.Add(new Paragraph(" "));

            // La Date 
            doc.Add(new Paragraph("Date de départ : " + drMission[0]["dateDepart"], fontNormal));
            doc.Add(new Paragraph("Date de retour prévue : " + drMission[0]["dateRetour"], fontNormal));

            // Chef de Mission 
            DataRow[] drchef = MesDatas.DsGlobal.Tables["Membres"].Select
                ("matricule = ' " + drMission[0]["matriculeChef"] + " ' ");
            doc.Add(new Paragraph("Responsable : " + drchef[0]["nom"] + " " + drchef[0]["prenom"], fontNormal));

            // Budget 
            int budgetInitial = Convert.ToInt32(drMission[0]["Budget"]);
            doc.Add(new Paragraph("Budget initial :  " + budgetInitial + "€", fontNormal));




        }
    }
}
