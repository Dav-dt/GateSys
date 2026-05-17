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
using System.Xml;

namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    public partial class frmMain : Form
    {
        private bool m_hasConnectedOnce = false;

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
            if ( !m_hasConnectedOnce )
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
                if ( frmLogin.DialogResult == DialogResult.OK )
                {
                    m_hasConnectedOnce = true;
                }
            }

            if ( m_hasConnectedOnce )
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
            frmPlanete frmPlanete = new frmPlanete();
            frmPlanete.ShowDialog();

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

        private void MettreAJourDs(DataSet ds)
        {
            DataTable schemaTable = Connexion.Connec.GetSchema("Tables");
            SQLiteDataAdapter da;

            for (int i = 0; i < schemaTable.Rows.Count; i++)
            {
                string nomTable = schemaTable.Rows[i]["TABLE_NAME"].ToString();

                if (ds.Tables.Contains(nomTable))
                    ds.Tables[nomTable].Clear();

                da = new SQLiteDataAdapter("SELECT * FROM " + nomTable,
                                           Connexion.Connec);

                da.Fill(ds, nomTable);
            }
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
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnTestMembre_Click(object sender, EventArgs e)
        {
            frmSaisieMembresObjectifs frmSaisieMembresObjectifs = new frmSaisieMembresObjectifs();
            frmSaisieMembresObjectifs.ShowDialog();
        }

        private void btnTestFiche_Click(object sender, EventArgs e)
        {
            frmFicheMission frmFicheMission = new frmFicheMission("test", 1);
            frmFicheMission.ShowDialog();
        }
    }
}
