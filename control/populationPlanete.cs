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
    public partial class populationPlanete : UserControl
    {
        public populationPlanete()
        {
            InitializeComponent();
        }

        public populationPlanete(Dictionary<string,int> dict,Dictionary<string,Color> color)
        {
            InitializeComponent();
            int x = 10;
            if (dict.Count == 0)
            {
                Label rtb = new Label();
                rtb.Text = "Aucune espèce n'habite cette planète.";
                rtb.Top = x;
                rtb.Height = 15;
                rtb.Font = new Font("Arial", 10);
                rtb.AutoSize = true;
                rtb.ForeColor = Color.Red;
                this.Controls.Add(rtb);
            }
            else
            {
                foreach (string item in dict.Keys)
                {
                    Label rtb = new Label();
                    rtb.Text = item + ": ";
                    if(dict[item] / 10 <= 0)
                    {
                        rtb.Text += "|";
                    }
                    for (int i = 0; i < dict[item] / 10; i++)
                    {
                        rtb.Text += "| ";
                    }

                    rtb.Top = x;
                    rtb.Height = 15;
                    rtb.Font = new Font("Arial", 12);
                    rtb.AutoSize = true;
                    rtb.ForeColor = color[item];


                    x += 20;
                    this.Controls.Add(rtb);
                }
            }
        }
    }
}
