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
            Mission ms = new Mission("Mars", "01-01-2090", "01-01-2090", "test", "beaucoup", img);

            this.Controls.Add(ms);
        }
    }
}
