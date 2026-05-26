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
    public partial class ButtonBack : UserControl
    {
        public ButtonBack()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(21, 19, 30);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                parentForm.Close();
            }
        }
    }
}
