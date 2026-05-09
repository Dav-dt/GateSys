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
        public Mission()
        {
            InitializeComponent();
        }
        public Mission(string nonMission,string dateDepart,string dateFin,string commandant,string budget,Image image)
        {
            InitializeComponent();
            lblNomMission.Text = nonMission;
            lblDateDepart.Text = dateDepart;
            lblDateFin.Text = dateFin;
            lblNomCapitaine.Text = commandant;
            lblbudget.Text = budget;

            pbPlanete.Image = image;
            pbPlanete.SizeMode = PictureBoxSizeMode.StretchImage;


        }
    }
}
