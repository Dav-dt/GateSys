using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saeStargateTUAILLON_LONGO_YURTSEBEN.control
{
    public partial class Mission : UserControl
    {
        private string m_nomPlanete;
        private int m_numMission;

        public Mission()
        {
            InitializeComponent();
        }
        public Mission(string nomPlanete, int numMission, string dateDepart, string dateFin, string commandant, string budget, Image image)
        {
            InitializeComponent();
            lblNomMission.Text = nomPlanete;
            lblDateDepart.Text = dateDepart;
            lblDateFin.Text = dateFin;
            lblNomCapitaine.Text = commandant;
            lblbudget.Text = budget;
            pbPlanete.Image = image;
            pbPlanete.SizeMode = PictureBoxSizeMode.StretchImage;

            m_nomPlanete = nomPlanete;
            m_numMission = numMission;
        }


        private void Mission_Load(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmFicheMission frmFicheMission = new
                frmFicheMission(m_nomPlanete, m_numMission);
            frmFicheMission.Show();
        }
    }
}
