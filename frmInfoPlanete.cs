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
    public partial class frmInfoPlanete : Form
    {
        DataSet ds = MesDatas.DsGlobal;
        public frmInfoPlanete()
        {
            InitializeComponent();
        }
        string nomplanete;

        public frmInfoPlanete(string non, string planete, int temperature, double gravite, int databaz)
        {
            InitializeComponent();
            Style.InitControles(this);
            Planete plt = new Planete(non, planete, temperature, gravite, databaz, false);
            this.Controls.Add(plt);
            nomplanete = planete;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmInfoPlanete_Load(object sender, EventArgs e)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            Dictionary<string,Color> color = new Dictionary<string, Color>();

            if (!ds.Relations.Contains("relHabiterEspece"))
            {
                DataRelation rel = new DataRelation("relHabiterEspece", ds.Tables["Espece"].Columns["id"], ds.Tables["Habiter"].Columns["idEspece"]);
                ds.Relations.Add(rel);
            }
            DataRow[] habitants = ds.Tables["Habiter"].Select($"nomPlanete = '{nomplanete}'");
            if (habitants.Length > 0)
            {
                foreach (DataRow ligne in habitants)
                {
                    // Accès direct à la ligne correspondante dans la table Espece
                    DataRow espece = ligne.GetParentRow("relHabiterEspece");
                    ;

                    
                    dic.Add(espece["nom"].ToString(), Convert.ToInt32(ligne["pourcentage"]));
                    color.Add(espece["nom"].ToString(), getCouleur(Convert.ToInt32(espece["id"])));
                }
                

            }
            else
            {
                //lbEspece.Items.Add("Aucune espèce n'habite cette planète.");
            }



            DataRow[] mission = ds.Tables["Mission"].Select($"nomPlanete = '{nomplanete}'");
            if (mission.Length > 0)
            {
                foreach (DataRow ligne in mission)
                {
                    lbMission.Items.Add(ligne["nomPlanete"].ToString() + "-" + ligne["numero"].ToString());
                }
            }
            else
            {
                lbMission.Items.Add("Aucune mission n'est prévue pour cette planète.");
            }
            //Dictionary<string, int> dic = new Dictionary<string, int> { { "test", 100 }, { "test2",20} };
            populationPlanete pl = new populationPlanete(dic,color);
            pl.Top = 220;
            pl.Left = 10;
            this.Controls.Add(pl);

        }

        private Color getCouleur(int id)
        {
            DataRow[] res = ds.Tables["Allie"].Select($"idEspece = {id}");
            if (res.Length > 0)
            {
                return Color.Green;
            }
            else
            {
                return Color.Red;
            }
        }
        

     }

   }
    
