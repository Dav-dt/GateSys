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
        public frmInfoPlanete()
        {
            InitializeComponent();
        }

        public frmInfoPlanete(string non, string planete, int temperature, double gravite, int databaz)
        {
            InitializeComponent();
            Planete plt = new Planete(non, planete, temperature, gravite, databaz, false);
            this.Controls.Add(plt);
        }
    }
}
