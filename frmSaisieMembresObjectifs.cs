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
        private List<int> idsMembres = new List<int>();
        private Dictionary<int, int> captures = new Dictionary<int, int>();

        public frmSaisieMembresObjectifs()
        {
            InitializeComponent();
        }

        public frmSaisieMembresObjectifs(string nomPlanete, int numeroMission)
        {
            InitializeComponent();

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

        }

        private void btnValiderTout_Click(object sender, EventArgs e)
        {

        }

        private void btnEffacerMembre_Click(object sender, EventArgs e)
        {
            lstMembres.Items.Clear();
        }

        private void btnEffacerCapture_Click(object sender, EventArgs e)
        {
            lstCapture.Items.Clear();
        }

        private void btnAjouterMembres_Click(object sender, EventArgs e)
        {
            lstMembres.Items.Add(cmbMembres.Text);

        }

        private void btnAjouterCapture_Click(object sender, EventArgs e)
        {

        }
    }
}
