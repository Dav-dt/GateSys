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
    public partial class frmCreationMission : Form
    {
        private bool aValidePlanete = false;
        private int numMission = -1;

        //guetteurs pour apres faire le constructeur des autres frms
        public string nomPlanete
        {
            get { return cmbPlanete.SelectedItem.ToString();}
        }

        public int numeroMission
        {
            get { return numMission;}
        }

        public int nbMembres
        {
            get { return Convert.ToInt32(txtNbMembres.Text) - 1;}
        }

        public frmCreationMission()
        {
            InitializeComponent();

            txtBudget.KeyPress += onlyNumbers_KeyPress;
            txtNbMembres.KeyPress += onlyNumbers_KeyPress;
            txtObjectifQDB.KeyPress += onlyNumbers_KeyPress;

            Style.InitControles(this);
        }

        private void frmCreationMission_Load(object sender, EventArgs e)
        {
            //remplissage cmb Planetes
            SQLiteCommand cmd = new SQLiteCommand(
                @"SELECT nom FROM Planete", Connexion.Connec);

            SQLiteDataReader reader = cmd.ExecuteReader();
            while ( reader.Read() )
            {
                cmbPlanete.Items.Add(reader["nom"].ToString());
            }
            cmbPlanete.SelectedIndex = 0;

            //remplissage Choix chef mission

            SQLiteCommand cmd2 = new SQLiteCommand(@"
                    SELECT matricule, nom, prenom, grade
                    FROM Membre mb JOIN Militaire m 
                    ON mb.matricule = m.matriculeMembre
                    WHERE NOT EXISTS (
                        SELECT mis.matriculeChef FROM Mission mis
                        WHERE mis.matriculeChef = m.matriculeMembre)",

                    Connexion.Connec); //seulement les disponibles
            
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // colonne affichée
            dt.Columns.Add("Affichage",typeof(string),
                "nom + ' ' + prenom + ' - ' + grade");

            cmbChefMission.DataSource = dt;
            cmbChefMission.DisplayMember = "Affichage";
            cmbChefMission.ValueMember = "matricule";
        }

        private void onlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back )
            {
                e.Handled = true;
            }
        }
        
        private void btnValiderPlanete_Click(object sender, EventArgs e)
        {
            string nomPlanete = cmbPlanete.SelectedItem.ToString();
            //id de la planete
            SQLiteCommand cmd = new SQLiteCommand(
                $@"SELECT COUNT(numero) FROM Mission
                  WHERE nomPlanete = '{nomPlanete}'", Connexion.Connec);

            //si mission sans planete on aura 1 qd même
            int num = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

            lblNomMission.Text = "Nom de la Mission : " + nomPlanete + " - " + num.ToString();

            aValidePlanete = true;
            numMission = num;
            cmbPlanete.Cursor = Cursors.Default;
        }

        private void btnValiderMission_Click(object sender, EventArgs e)
        {
            if ( !aValidePlanete || numMission == -1 )
            {
                MessageBox.Show("Veuillez valider la planète avant de " +
                    "valider la mission.");
                return;
            }

            else if ( txtFeuilleDeRoute.Text == "" ||
                txtObjectifQDB.Text == "" ||
                txtBudget.Text == "" ||
                txtNbMembres.Text == "" )
            {
                MessageBox.Show("Veuillez remplir tous les champs avant de " +
                    "valider la mission.");
                return;
            }

            else if ( txtNbMembres.Text == String.Empty || 
                    Convert.ToInt32(txtNbMembres.Text) <= 0 )
            {
                MessageBox.Show("Veuillez un nombre valide de membres ");
            }

            try
                {
                string requete = $@"INSERT INTO Mission (nomPlanete, numero, nbMembreRequis, 
                    dateDepart, dateRetour, matriculeChef, feuilleDeRoute,objectifDatabaz,budget)
                    VALUES ('{cmbPlanete.SelectedItem.ToString()}', {numMission}, {txtNbMembres.Text},
                    '{dtDepart.Value.ToString("yyyy-MM-dd")}', '{dtRetour.Value.ToString("yyyy-MM-dd")}',
                    '{cmbChefMission.SelectedValue.ToString()}', '{txtFeuilleDeRoute.Text.Replace("'", "''")}', {txtObjectifQDB.Text}, 
                    {txtBudget.Text})";

                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                    cmd.ExecuteNonQuery();

                    //insérer le chef aussi dans composer
                    cmd.CommandText = $@"INSERT INTO Composer(nomPlanete,
                                numeroMission, matriculeMembre) 
                                VALUES ('{cmbPlanete.SelectedItem.ToString()}',
                                {numMission}, '{cmbChefMission.SelectedValue.ToString()}')";
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mission créée avec succès !");

                    this.DialogResult = DialogResult.OK;
                }
                catch ( SQLiteException ex )
                {
                    MessageBox.Show("Erreur lors de l'insertion de la mission : " +
                        ex.Message);
                    return;
                }

                catch ( Exception ex )
                {
                    MessageBox.Show("Une erreur est survenue : " +
                        ex.Message);
                    return;
                }
        }

        private void dtDepart_ValueChanged(object sender, EventArgs e)
        {
            dtRetour.MinDate = dtDepart.Value;
            //date pas avant c logique
        }
    }
}
