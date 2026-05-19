using saeStargateTUAILLON_LONGO_YURTSEBEN.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        private bool m_missionTerminee;

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

            m_missionTerminee = MissionTerminee();

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
                //membre.Width = (pnlMembres.ClientSize.Width - 30) / 2;

                int colonne = index % 3;
                int ligne = index / 3;

                int posX = 30 + colonne * (membre.Width + 10);
                int posY = 5 + ligne * (membre.Height + 5);

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

            //Remplissage des cmbs
            cmbINomIndic.DataSource = MesDatas.DsGlobal.Tables["Informateur"];
            cmbINomIndic.DisplayMember  = "nom";
            cmbINomIndic.ValueMember = "idEspeceEnnemi";

            cmbIdDepense.DataSource = MesDatas.DsGlobal.Tables["TypeDepense"];
            cmbIdDepense.DisplayMember = "libelle";
            cmbIdDepense.ValueMember = "id";
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
            if ( m_missionTerminee )
            {
                MessageBox.Show("Mission terminée, impossible d'ajoute des éléments");
                return;
            }

            if ( txtAppreciationIndic.Text == String.Empty ||
                 cmbINomIndic.SelectedIndex == -1 ||
                 txtSoudoiementIndic.Text == String.Empty )
            {
                MessageBox.Show("Champs incomplets ou invalides");
                return;
            }

            DataRow row = MesDatas.DsGlobal.Tables["Contact"].NewRow();
            row["nomPlanete"] = m_nomPlanete;
            row["numeroMission"] = m_numero;
            row["dateC"] = dtIndic.Value;
            row["sommeVersee"] = Convert.ToInt32(txtSoudoiementIndic.Text);
            row["appreciation"] = txtAppreciationIndic.Text;
            row["nomCodeInformateur"] = cmbINomIndic.Text;
            
            MesDatas.DsGlobal.Tables["Contact"].Rows.Add(row);

            try
            {
                string requete = $@"INSERT INTO Contact(nomPlanete, numeroMission, dateC,
                       sommeVersee, appreciation, nomCodeInformateur)
                        VALUES('{m_nomPlanete}', {m_numero}, 
                        '{dtIndic.Value.ToString("yyyy-MM-dd")}', 
                        {Convert.ToInt32(txtSoudoiementIndic.Text)}, '{txtAppreciationIndic.Text}', 
                        '{cmbINomIndic.SelectedValue}')";
                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Contact ajouté avec succès !");
            }
            catch ( SQLiteException ex )
            {
                MessageBox.Show("Erreur lors de l'ajout du contact : " +ex.Message);
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Erreur lors de l'ajout du contact : " +ex.Message);
            }

        }

        private void numberOnlyField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void btnValiderNouvelEvent_Click(object sender, EventArgs e)
        {
            if (m_missionTerminee)
            {
                MessageBox.Show("Mission terminée, impossible d'ajoute des éléments");
                return;
            }

            if (txtNouvelEvent.Text == String.Empty)
            {
                MessageBox.Show("Champs incomplets ou invalides");
                return;
            }

            DataRow row = MesDatas.DsGlobal.Tables["JournalDeBord"].NewRow();
            row["nomPlanete"] = m_nomPlanete;
            row["numero"] = m_numero;
            row["dateJ"] = dtNouvelEvent.Value;
            row["commentaires"] = txtNouvelEvent.Text;

            MesDatas.DsGlobal.Tables["JournalDeBord"].Rows.Add(row);
            //synchro vraie bdd
            try
            {
                string requete = $@"INSERT INTO JournalDeBord(nomPlanete, numero, dateJ,
                        commentaires)
                        VALUES('{m_nomPlanete}', {m_numero}, 
                        '{dtNouvelEvent.Value.ToString("yyyy-MM-dd")}',
                        {txtNouvelEvent.Text}')";

                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Evènement ajouté avec succès !");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de l'évènement : " +ex.Message);
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Erreur lors de l'ajout de l'évènement : " +ex.Message);
            }
        }

        private void btnValiderDepense_Click(object sender, EventArgs e)
        {
            if (m_missionTerminee)
            {
                MessageBox.Show("Mission terminée, impossible d'ajoute des éléments");
                return;
            }
            
            if ( txtMontantDepense.Text == String.Empty ||
                    cmbIdDepense.SelectedIndex == -1 ||
                    txtMotifDepense.Text == String.Empty )
            {
                MessageBox.Show("Champs incomplets ou invalides");
                return;
            }
            int prochainId = GetProchainIdDepense();
            DataRow row = MesDatas.DsGlobal.Tables["Depense"].NewRow();
            row["nomPlanete"] = m_nomPlanete;
            row["numeroMission"] = m_numero;
            row["id"] = prochainId;
            row["dateD"] = dtDepense.Value;
            row["montant"] = Convert.ToInt32(txtMontantDepense.Text);
            row["motif"] = txtMotifDepense.Text;
            row["idTypeDepense"] = cmbIdDepense.SelectedValue;

            MesDatas.DsGlobal.Tables["Depense"].Rows.Add(row);

            try
            {
                string requete = $@"INSERT INTO Depense(nomPlanete, numeroMission, id, dateD,
                        montant, motif, idTypeDepense)
                    VALUES('{m_nomPlanete}', {m_numero}, {prochainId},
                    '{dtDepense.Value.ToString("yyyy-MM-dd")}', 
                        {Convert.ToInt32(txtMontantDepense.Text)},'{txtMotifDepense.Text}', 
                        {cmbIdDepense.SelectedValue})";

                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dépense ajoutée avec succès !");
            }
            catch ( SQLiteException ex )
            {
                MessageBox.Show("Erreur lors de l'ajout de la dépense : " +ex.Message);
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Erreur lors de l'ajout de la dépense : " +ex.Message);
            }
        }

        private int GetProchainIdDepense()
        {
            DataRow[] drDepenses = MesDatas.DsGlobal.Tables["Depense"].Select(
                            $@"numeroMission = '{m_numero}' AND 
                            nomPlanete = '{m_nomPlanete}'");

            if ( drDepenses.Length == 0 )
                return 1;

            return drDepenses.GetLength(0)+ 1; //nb lignes ++;
        }


        private void btnJournal_Click(object sender, EventArgs e)
        {
            frmJournal frmJournal = new frmJournal(m_nomPlanete, m_numero);
            frmJournal.Show();
        }
    }
}
