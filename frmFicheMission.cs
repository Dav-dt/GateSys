using saeStargateTUAILLON_LONGO_YURTSEBEN.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{

    public partial class frmFicheMission : Form
    {
        private string m_nomPlanete;
        private int m_numero;

        public frmFicheMission()
        {
            InitializeComponent();
        }

        public frmFicheMission(string nomPlanete, int numero)
        {
            InitializeComponent();
            m_nomPlanete = nomPlanete;
            m_numero = numero;
        }

        private void frmFicheMission_Load(object sender, EventArgs e)
        {
            //verifier que la mission existe
            DataRow[] dr = MesDatas.DsGlobal.Tables["Mission"].Select(
                            $@"Numero = '{m_numero}' AND 
                            NomPlanete = '{m_nomPlanete}'");

            if ( dr.Length == 0 )
            {
                MessageBox.Show("Mission inexistante");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }

            lblMission.Text = $"Mission n°{m_numero} sur {m_nomPlanete}";
            lblDtDepart.Text = $"Date de départ : {dr[0]["dateDepart"]}";
            lblDtRetour.Text = $"Date de retour : {dr[0]["dateRetour"]}";
            txtFeuilleDeRoute.Text = dr[0]["feuilleDeRoute"].ToString();

            lblBudget.Text = $"Budget : {dr[0]["budget"]} $DG";
            lblBudgetApresDepenses.Text = $"Budget après dépenses :" +
                $" {Convert.ToInt32(dr[0]["budget"]) - GetMontantDesDepenses()} $DG";

            //parcourt des membres
            DataRow[] drMatricules = MesDatas.DsGlobal.Tables["Composer"].Select(
                            $@"numeroMission = '{m_numero}' AND 
                            NomPlanete = '{m_nomPlanete}'");


            int index = 0;
            foreach ( DataRow row in drMatricules )
            {
                string matricule = row["matriculeMembre"].ToString();

                DataRow[] infosMembre = MesDatas.DsGlobal.Tables["Membre"].Select(
                            $@"Matricule = '{matricule}'");

                bool estMilitaire = matricule.StartsWith("M");
                string nom = infosMembre[0]["nom"].ToString();
                string prenom = infosMembre[0]["prenom"].ToString();

                Membre membre = new Membre(nom, prenom, estMilitaire);
                membre.Width = (pnlMembres.ClientSize.Width - 30) / 2;

                int colonne = index % 2;
                int ligne = index / 2;

                int posX = 10 + colonne * (membre.Width + 10);
                int posY = 10 + ligne * (membre.Height + 5);

                membre.Location = new Point(posX, posY);
                pnlMembres.Controls.Add(membre);
                
                index++;
            }

            DataRow[] objectifsCapture = MesDatas.DsGlobal.Tables["ObjectifCapture"].Select(
                            $@"numeroMission = '{m_numero}' AND 
                            nomPlanete = '{m_nomPlanete}'");

            int posYCapture = 10;
            foreach ( DataRow row in objectifsCapture )
            {
                int idEspeceEnnemi = Convert.ToInt32(row["idEspeceEnnemi"]);
                DataRow[] infosEspeceEnnemi = MesDatas.DsGlobal.Tables["Espece"].Select(
                            $@"id = '{idEspeceEnnemi}'");
                string nomEnnemi = infosEspeceEnnemi[0]["nom"].ToString();

                Label lbl = new Label();
                lbl.Text = nomEnnemi + " --> " + row["objectif"].ToString();
                lbl.AutoSize = true;
                lbl.Location = new Point(10, posYCapture);

                pnlCapture.Controls.Add(lbl);
                posYCapture += lbl.Height+ 5;
            }
        }

        private int GetMontantDesDepenses()
        {
            int montant = 0;
            DataRow[] drDepenses = MesDatas.DsGlobal.Tables["Depense"].Select(
                            $@"numeroMission = '{m_numero}' AND 
                            nomPlanete = '{m_nomPlanete}'");
            foreach ( DataRow row in drDepenses )
            {
                montant += Convert.ToInt32(row["montant"]);
            }
            return montant;
        }

        private bool MissionTerminee()
        {
            DataRow[] dr = MesDatas.DsGlobal.Tables["Mission"].Select(
                            $@"Numero = '{m_numero}' AND 
                            NomPlanete = '{m_nomPlanete}'");

            DateTime dateRetour = Convert.ToDateTime(dr[0]["dateRetour"]);
            return DateTime.Now >dateRetour;
        }

        private void btnValiderIndic_Click(object sender, EventArgs e)
        {
            if ( MissionTerminee() )
            {
                MessageBox.Show("Mission terminée, impossible d'ajoute des éléments");
                return;
            }

            if ( txtAppreciationIndic.Text == String.Empty ||
                 cmbINomIndic.SelectedIndex == -1 ||
                 txtSoudoiementIndic.Text == String.Empty )
            {
                MessageBox.Show("Champs incomplets ou invalides");
            }
        }

        private void numberOnlyField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }
    }
}
