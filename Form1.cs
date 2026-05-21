using saeStargateTUAILLON_LONGO_YURTSEBEN.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
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
            pnlAffichageMissions.AutoScroll = true;
            afficherMissionsPanel();
            btnNouvellesMissions.Select();//plus beau

            Style.InitControles(this);

        }

        private void btnTableauDeBord_Click(object sender, EventArgs e)
        {

        }

        private void btnNouvellesMissions_Click(object sender, EventArgs e)
        { //evite de retaper le mot de passe a chaque fois
            if ( !m_hasConnectedOnce )
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
                if (frmLogin.DialogResult == DialogResult.OK)
                {
                    m_hasConnectedOnce = true;
                }
            }

            if ( m_hasConnectedOnce )
            {
                frmCreationMission frmCreationMission = new frmCreationMission();
                frmCreationMission.ShowDialog();

                if ( frmCreationMission.DialogResult == DialogResult.OK )
                {
                    MettreAJourDs(MesDatas.DsGlobal);

                    frmSaisieMembresObjectifs frmS = new frmSaisieMembresObjectifs(
                        frmCreationMission.nomPlanete, frmCreationMission.numeroMission,
                        frmCreationMission.nbMembres);
                    frmS.ShowDialog();

                    if ( frmS.DialogResult == DialogResult.OK )
                    {
                        afficherMissionsPanel(); //rafraichir
                        Style.InitControles(this);
                        frmChargement frmChargement = new frmChargement();
                        frmChargement.Show();
                        Application.DoEvents();
                        MessageBox.Show("Mission créée et objectifs saisis avec succès !" +
                            "Vous pouvez consulter la mission dans le tableau de bord");
                        frmChargement.Close();
                        MettreAJourDs(MesDatas.DsGlobal);

                    }
                }
            }
        }

        private void btnRaces_Click(object sender, EventArgs e)
        {
            frmChargement frmChargement = new frmChargement();
            frmChargement.Show();
            Application.DoEvents(); //obligé sinon la progess bar se remplie que apres
            
            frmRace frmRace = new frmRace();
            frmRace.Show();
            frmChargement.Close();

        }

        private void btnInfosPlanetes_Click(object sender, EventArgs e)
        {
            frmChargement frmChargement = new frmChargement();
            frmChargement.Show();
            Application.DoEvents();

            frmPlanete frmPlanete = new frmPlanete();
            frmPlanete.Show();
            frmChargement.Close();

        }

        //charge dans MesDatas et renvoie une liste des tables 
        private List<string> ChargerBddDansDs(DataSet ds)
        {
            List<string> tables = new List<string>();

            DataTable schemaTable = Connexion.Connec.GetSchema("Tables");
            SQLiteDataAdapter da;

            for ( int i = 0; i < schemaTable.Rows.Count; i++ )
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

            for ( int i = 0; i < schemaTable.Rows.Count; i++ )
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

        private void afficherMissionsPanel()
        {
            SQLiteCommand cmd = new SQLiteCommand(
                "SELECT * FROM Mission", Connexion.Connec);
            SQLiteDataReader reader = cmd.ExecuteReader();

            int positionY = 0;
            while ( reader.Read() )
            {
                SQLiteCommand cmdChef = new SQLiteCommand(
                    $@"SELECT CONCAT(nom, ' ',prenom)
                    FROM Membre WHERE matricule = '{reader["matriculeChef"]}'",
                    Connexion.Connec);

                string nomChef = cmdChef.ExecuteScalar().ToString();

                Mission mission = new Mission(
                    reader["nomPlanete"].ToString(),
                    Convert.ToInt32(reader["numero"]),
                    reader["dateDepart"].ToString(),
                    reader["dateRetour"].ToString(),
                    nomChef, reader["budget"].ToString());

                mission.Location = new Point(0, positionY);
                positionY += mission.Height + 10;

                pnlAffichageMissions.Controls.Add(mission);

            }
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            frmStat stat = new frmStat();
            stat.ShowDialog();
        }
    }
}
