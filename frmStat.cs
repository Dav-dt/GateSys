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
    public partial class frmStat : Form
    {
        public frmStat()
        {
            InitializeComponent();
            //Style.InitControles(this);  il faut le a la main sinon ce sera trop dure a tout fix 
        }

        private void frmStat_Load(object sender, EventArgs e)
        {
            DataTable dt = new Statistique().getMissionPlanete();
            NbMissionPlanete nbMission = new NbMissionPlanete(dt);
            nbMission.Top = 10;
            nbMission.Left = 10;
            this.Controls.Add(nbMission);

            DataTable d2 = new Statistique().DatagetBudget();
            foreach(DataRow dr in d2.Rows)
            {
                DataTable budgetDetail = new Statistique().getBudgetDetail(dr["nomPlanete"].ToString(), Convert.ToInt32(dr["numero"]));
                BudgetMIssionStat bd = new BudgetMIssionStat(dr["nomPlanete"].ToString(), Convert.ToInt32(dr["numero"]), Convert.ToInt32(dr["budget"]), Convert.ToInt32(dr["BudgetActuel"]),budgetDetail);
                flpBudget.Controls.Add(bd);

            }
            DataTable dtMenbre = new Statistique().getMenbre();
            cboCollegue.DataSource = dtMenbre;
            cboCollegue.DisplayMember = dtMenbre.Columns["nom"].ToString();
            cboCollegue.ValueMember = dtMenbre.Columns["matricule"].ToString();

            DataTable dtMission = new Statistique().getNomMission();
            cboMission.DataSource = dtMission;
            cboMission.DisplayMember = "nomMission";
            cboMission.ValueMember = "nomMission";

            DataTable dtDepense = new Statistique().getDepenseMax();
            DepenseMaxList dml = new DepenseMaxList(dtDepense);

            gbDepenseMax.Controls.Add(dml);
            dml.Top += 15;
            dml.Left += 10;
            

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            flpCollegue.Controls.Clear();
            string id = cboCollegue.SelectedValue.ToString();

            DataTable dtcolegue = new Statistique().getColege(id);
            if (dtcolegue.Rows.Count == 0)
            {
                Label lbl = new Label();
                lbl.Text = "Cette personne a travailler avec aucun Menbre";
                lbl.AutoSize = true;
                flpCollegue.Controls.Add(lbl);
            }
            else
            {
                foreach (DataRow dr in dtcolegue.Rows)
                {
                    if (dr["Type"].ToString() == "Militaire")
                    {
                        Membre mb = new Membre(dr["nom"].ToString(), dr["prenom"].ToString(), true);
                        flpCollegue.Controls.Add(mb);
                    }
                    else
                    {
                        Membre mb = new Membre(dr["nom"].ToString(), dr["prenom"].ToString(), false);
                        flpCollegue.Controls.Add(mb);

                    }
                }
            }
        }

        private void btnValiderInofrmateur_Click(object sender, EventArgs e)
        {
            flpInformteur.Controls.Clear();
            string mission = cboMission.SelectedValue.ToString();
            string[] splitMission = mission.Split('-');
            DataTable dtInformateur = new Statistique().getInformateurMoins(splitMission[0], Convert.ToInt32(splitMission[1]));
            if(dtInformateur.Rows.Count == 0)
            {
                Label lbl = new Label();
                lbl.Text = "Aucun informtaeur";
                lbl.AutoSize = true;
                flpInformteur.Controls.Add(lbl);
            }
            foreach(DataRow dr in dtInformateur.Rows)
            {
                AlienReduit ar = new AlienReduit(dr["couleur"].ToString(), dr["nomCode"].ToString(), dr["especeOrigine"].ToString(), Convert.ToInt32(dr["sommeTotaleRecue"]));
                flpInformteur.Controls.Add(ar);
            }

        }
    }
}
