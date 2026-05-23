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
    }
}
