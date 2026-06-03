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
    public partial class frmSaisieMembresObjectifs : Form
    {
        private List<string> m_idsMembres = new List<string>();
        private Dictionary<int, int> m_captures = new Dictionary<int, int>();
        private int m_numeroMission;
        private string m_nomPlanete;
        private int m_nbMembres;

        public frmSaisieMembresObjectifs()
        {
            InitializeComponent();
        }

        public frmSaisieMembresObjectifs(string nomPlanete, int numeroMission, int nbMembres)
        {
            InitializeComponent();

            m_nomPlanete = nomPlanete;
            m_numeroMission = numeroMission;
            m_nbMembres = nbMembres;
        }

        private void frmSaisieMembresObjectifs_Load(object sender, EventArgs e)
        {
            string requete = @"SELECT * FROM membre me
                    LEFT JOIN Militaire mi 
                        ON me.matricule = mi.matriculeMembre
                    LEFT JOIN Civil c 
                        ON me.matricule = c.matriculeMembre";

            string requeteCapture = @"SELECT * From Ennemi 
                                        en JOIN espece es
                                        on en.idEspece = es.id";


            //if grade alors militaire sinon civil

            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(requete, Connexion.Connec);
                DataSet ds = new DataSet();

                da.Fill(ds, "membre");
                
                ds.Tables["membre"].Columns.Add("DisplayInfo", typeof(string), "nom + ' ' + prenom + ' - ' + ISNULL(grade, Specialite)");
                
                cmbMembres.DataSource = ds.Tables["membre"];
                cmbMembres.DisplayMember = "DisplayInfo";
                cmbMembres.ValueMember = "matricule";

                SQLiteDataAdapter daCapture = new SQLiteDataAdapter(requeteCapture, 
                                            Connexion.Connec);

                DataSet dsCapture = new DataSet();
                daCapture.Fill(dsCapture, "capture");
                dsCapture.Tables["capture"].Columns.Add("DisplayCapture", typeof(string), "nom + ' - ' + couleur");

                cmbCapture.DataSource = dsCapture.Tables["capture"];
                cmbCapture.DisplayMember = "DisplayCapture";
                cmbCapture.ValueMember = "idEspece";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement");
            }

            Style.InitControles(this);

        }

        private void btnValiderTout_Click(object sender, EventArgs e)
        {
            //debut des inserts

            //cas ou ya juste le capitaine et pas dautres membres
            if ( lstMembres.Items.Count == 0 && m_nbMembres != 0 )
            {
                MessageBox.Show("Veuillez entrer des informations valides");
                return;
            }

            if ( lstCapture.Items.Count == 0 )
            {
                MessageBox.Show("Veuillez entrer des informations valides");
                return;
            }

            if ( lstMembres.Items.Count != m_nbMembres )
            {
                MessageBox.Show($"Assurez-vous d'avoir ajouté exactement " +
                    $"{m_nbMembres} membres sans compter le capitaine");
                return;
            }

                SQLiteTransaction transaction = Connexion.Connec.BeginTransaction();
            try
            {
                //insertion des membres
                foreach ( string idMembre in m_idsMembres )
                {
                    string requete = $@"INSERT INTO Composer(nomPlanete, numeroMission, matriculeMembre) 
                                        VALUES ('{m_nomPlanete}', '{m_numeroMission}',
                                           '{idMembre}')";
                    SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                }

                //insertion des captures

                foreach ( KeyValuePair<int,int> capture in m_captures )
                {
                    string requete = $@"INSERT INTO ObjectifCapture(nomPlanete, numeroMission, 
                                        idEspeceEnnemi, objectif) 
                                        VALUES ('{m_nomPlanete}', '{m_numeroMission}',
                                           '{capture.Key}', '{capture.Value}')";
                    SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Données insérées avec succès !");
                
                this.DialogResult = DialogResult.OK;

            }
            catch ( SQLiteException ex )
            {
                transaction.Rollback();
                MessageBox.Show("Erreur lors de l'insertion : " + ex.Message);
            }

            catch ( Exception ex )
            {
                transaction.Rollback();
                MessageBox.Show("Erreur inattendue : " + ex.Message);
            }

        }

        private void btnEffacerMembre_Click(object sender, EventArgs e)
        {
            lstMembres.Items.Clear();
            m_idsMembres.Clear();
        }

        private void btnEffacerCapture_Click(object sender, EventArgs e)
        {
            lstCapture.Items.Clear();
            m_captures.Clear();
        }

        private void btnAjouterMembres_Click(object sender, EventArgs e)
        {
            //pas 2 fois
            if (lstMembres.Items.Contains(cmbMembres.Text))
                return;

            else if (lstMembres.Items.Count == m_nbMembres)
                return;

                lstMembres.Items.Add(cmbMembres.Text);
            m_idsMembres.Add(cmbMembres.SelectedValue.ToString());

            Style.InitControles(this);

        }

        private void btnAjouterCapture_Click(object sender, EventArgs e)
        {
            if ( txtNbCapture.Text == String.Empty || 
                !int.TryParse(txtNbCapture.Text, out int nbCapture) ||
                nbCapture <= 0 )
            {
                MessageBox.Show("Veuillez entrer un nombre de captures valide.");
                return;
            }

            int idEspece = Convert.ToInt32(cmbCapture.SelectedValue);
            //pas 2 fois
            if (m_captures.ContainsKey(idEspece))
                return;

            lstCapture.Items.Add(cmbCapture.Text + " -> " + nbCapture);
            m_captures.Add(idEspece, nbCapture);

            Style.InitControles(this);
        }

        private void frmSaisieMembresObjectifs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
                return;
            //eviter que ca empeche de fermer meme si tout est ok

            MessageBox.Show("Ces informations sont obligatoires");
            e.Cancel = true;
            //empêcher le user de fermer le formulaire et
            // de tout casser
        }
    }
}
