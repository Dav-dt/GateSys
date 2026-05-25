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
    public partial class BarBudget : UserControl
    {
        public BarBudget()
        {
            InitializeComponent();
        }

        public BarBudget(int budget,int budgetActuelle)
        {
            InitializeComponent();
            pBarBudget.Minimum = 0;
            pBarBudget.Maximum = budget;

            pBarBudget.Value = budgetActuelle;
            lblBudget.Text = budget.ToString();

            Label lbl = new Label();
            lbl.Text = budgetActuelle.ToString();
            lbl.Top = pBarBudget.Top + 50;
            lbl.Left = pBarBudget.Left + (pBarBudget.Width *budgetActuelle)/budget;
            this.Controls.Add(lbl);
        }
    }
}
