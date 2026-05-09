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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            //chargement initial de la toute la bdd
            List<string> tables = ChargerBddDansDs(MesDatas.DsGlobal);


        }

        private void btnTableauDeBord_Click(object sender, EventArgs e)
        {

        }

        private void btnNouvellesMissions_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();

            if (  frmLogin.DialogResult == DialogResult.OK)
            {
                frmCreationMission frmCreationMission = new frmCreationMission();
                frmCreationMission.ShowDialog();
            }
        }

        private void btnRaces_Click(object sender, EventArgs e)
        {

        }

        private void btnInfosPlanetes_Click(object sender, EventArgs e)
        {

        }

        //charge dans MesDatas et renvoie une liste des tables 
        private List<string> ChargerBddDansDs(DataSet ds)
        {
            List<string> tables = new List<string>();

            DataTable schemaTable = Connexion.Connec.GetSchema("Tables");
            SQLiteDataAdapter da;

            for ( int i = 0; i < schemaTable.Rows.Count; i++)
            {
                string nomTable = schemaTable.Rows[i]["TABLE_NAME"].ToString();
                tables.Add(nomTable);
                da = new SQLiteDataAdapter("SELECT * FROM " + nomTable, 
                                            Connexion.Connec);
                da.Fill(ds, nomTable);
            }

            return tables;

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Connexion.FermerConnexion();

            this.Close();
            
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Form test = new frmTest();
            test.Show();

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
