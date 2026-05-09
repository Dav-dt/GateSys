using saeStargateTUAILLON_LONGO_YURTSEBEN.control;
using saeStargateTUAILLON_LONGO_YURTSEBEN.Properties;
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
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            Image img = Resources.mars;
            List<string> ls = new List<string>{ "Terre", "mars" };
            Alien al = new Alien("test", "test", ls, img);
            Alien al2 = new Alien("test", "test", img);
            al2.Top = 200;

            this.Controls.Add(al);
            this.Controls.Add(al2);
        }
    }
}
