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
    public partial class DepenseMaxList : UserControl
    {
        public DepenseMaxList()
        {
            InitializeComponent();
        }
        public DepenseMaxList(DataTable dt )
        {
            InitializeComponent();
            foreach(DataRow dr in dt.Rows)
            {
                DepenseMax dp = new DepenseMax(dr);
                flpDepense.Controls.Add(dp);
            }
        }
    }
}
