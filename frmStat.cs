using saeStargateTUAILLON_LONGO_YURTSEBEN.control;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    public partial class frmStat : Form
    {
        public frmStat()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //Style.InitControles(this);  il faut le a la main sinon ce sera trop dure a tout fix 
            string path = Path.Combine(Application.StartupPath,
                "fonts", "Saira_Condensed-Regular.ttf");

            m_privateFontCollection.AddFontFile(path);
        }
        private static PrivateFontCollection m_privateFontCollection =
            new PrivateFontCollection();
        private static Font m_font;


        private void frmStat_Load(object sender, EventArgs e)
        {

            DataTable dt = new Statistique().getMissionPlanete();
            NbMissionPlanete nbMission = new NbMissionPlanete(dt);
            nbMission.Top = 20;
            nbMission.Left = 10;
            grpMissionPlanete.Controls.Add(nbMission);


            DataTable dtMenbre = new Statistique().getMenbre();
            cboCollegue.DataSource = dtMenbre;
            cboCollegue.DisplayMember = dtMenbre.Columns["nom"].ToString();
            cboCollegue.ValueMember = dtMenbre.Columns["matricule"].ToString();

            DataTable dtMission = new Statistique().getNomMission();
            cboMission.DataSource = dtMission;
            cboMission.DisplayMember = "nomMission";
            cboMission.ValueMember = "nomMission";


            //Style.InitControles(this);
            DataTable d2 = new Statistique().DatagetBudget();
            foreach (DataRow dr in d2.Rows)
            {
                DataTable budgetDetail = new Statistique().getBudgetDetail(dr["nomPlanete"].ToString(), Convert.ToInt32(dr["numero"]));
                BudgetMIssionStat bd = new BudgetMIssionStat(dr["nomPlanete"].ToString(), Convert.ToInt32(dr["numero"]), Convert.ToInt32(dr["budget"]), Convert.ToInt32(dr["BudgetActuel"]), budgetDetail);
                flpBudget.Controls.Add(bd);

            }
            DataTable dtDepense = new Statistique().getDepenseMax();
            DepenseMaxList dml = new DepenseMaxList(dtDepense);

            gbDepenseMax.Controls.Add(dml);
            dml.Top += 20;
            dml.Left += 10;

            //Style(grpBudget);
            Style.InitControles(this);
            menuBar1.BringToFront();




        }

        private void InitStyle(GroupBox grp)
        {
            this.BackColor = Color.FromArgb(21, 19, 30);

            grp.ForeColor = Color.FromArgb(253, 128, 02);
            grp.UseCompatibleTextRendering = true;
            grp.Font = new Font(m_privateFontCollection.Families[0],
            11, FontStyle.Regular);



        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            flpCollegue.Controls.Clear();
            string id = cboCollegue.SelectedValue.ToString();

            DataTable dtcolegue = new Statistique().getColege(id);
            if (dtcolegue.Rows.Count == 0)
            {
                Label lbl = new Label();
                lbl.Text = "Cette personne n'a travaillé avec aucun membre";
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
            if (dtInformateur.Rows.Count == 0)
            {
                Label lbl = new Label();
                lbl.Text = "Aucun informtaeur";
                lbl.AutoSize = true;
                flpInformteur.Controls.Add(lbl);
            }
            foreach (DataRow dr in dtInformateur.Rows)
            {
                AlienReduit ar = new AlienReduit(dr["couleur"].ToString(), dr["nomCode"].ToString(), dr["especeOrigine"].ToString(), Convert.ToInt32(dr["sommeTotaleRecue"]));
                flpInformteur.Controls.Add(ar);
            }

        }
    }
}
