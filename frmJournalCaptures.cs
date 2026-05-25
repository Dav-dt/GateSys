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
    public partial class frmJournalCaptures : Form
    {
        private string m_nomPlanete;
        private int m_numeroMission;

        public frmJournalCaptures()
        {
            InitializeComponent();
        }

        public frmJournalCaptures(string nomPlanete, int numeroMission)
        {
            InitializeComponent();

            m_nomPlanete = nomPlanete;
            m_numeroMission = numeroMission;
        }

        private void frmJournalCaptures_Load(object sender, EventArgs e)
        {
            string nomTable = $"BilanCapture{m_nomPlanete}-{m_numeroMission}";

            //verif si la table existe deja
            if (MesDatas.DsGlobal.Tables.Contains(nomTable))
                MesDatas.DsGlobal.Tables.Remove(nomTable);

            DataTable dtCapture = MesDatas.DsGlobal.Tables.Add(nomTable);
            dtCapture.Columns.Add("Nom de l'espèce", typeof(string));
            dtCapture.Columns.Add("Objectif Initial", typeof(int));
            dtCapture.Columns.Add("Nombre de captures réalisées", typeof(int));
            dtCapture.Columns.Add("Taux de réussite", typeof(int));

            DataRow[] drObjectifs = MesDatas.DsGlobal.Tables["ObjectifCapture"].Select(
                $"nomPlanete = '{m_nomPlanete}' " +
                $"AND numeroMission = {m_numeroMission}");


            DataRow[] drCaptures = MesDatas.DsGlobal.Tables["Capturer"].Select(
                $"nomPlanete = '{m_nomPlanete}' " +
                $"AND numeroMission = {m_numeroMission}");

            //clé idEspece, valeur : liste des infos de capture
            // list[0] = obj & list[1] = nombre reel de capture
            Dictionary<int, List<int>> infosCaptures =
                new Dictionary<int, List<int>>();

            foreach (DataRow dr in drObjectifs)
            {
                int objectifDeCapture = Convert.ToInt32(dr["objectif"]);
                infosCaptures.Add(Convert.ToInt32(dr["idEspeceEnnemi"]),
                    new List<int> { objectifDeCapture });
            }

            foreach (DataRow dr in drCaptures)
            {
                int idEspece = Convert.ToInt32(dr["idEspeceEnnemi"]);
                int nombreReel = Convert.ToInt32(dr["nombre"]);
                infosCaptures[idEspece].Add(nombreReel);
            }

            foreach (int idEspece in infosCaptures.Keys)
            {
                DataRow[] drEspece = MesDatas.DsGlobal.Tables["Espece"].Select(
                    $"id = {idEspece}");
                string nomEspece = drEspece[0]["nom"].ToString();

                int objectifInitial = infosCaptures[idEspece][0];

                //verifier que ya une valeur
                int nombreReel = infosCaptures[idEspece].Count > 1 ?
                    infosCaptures[idEspece][1] : 0;

                int tauxReussite = objectifInitial > 0 ?
                    (int)((double)nombreReel / objectifInitial * 100) : 0;

                dtCapture.Rows.Add(nomEspece, objectifInitial, nombreReel, tauxReussite);
            }

            dgvCapture.DataSource = dtCapture;

            Style.InitControles(this);
        }
    }
}
