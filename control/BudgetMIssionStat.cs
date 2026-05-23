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
    public partial class BudgetMIssionStat : UserControl
    {
        public BudgetMIssionStat()
        {
            InitializeComponent();
        }

        public BudgetMIssionStat(string nom,int numero,int budget,int budgetactuelle,DataTable dtDepense)
        {
            InitializeComponent();
            pbPlanete.Image = getImage(nom);
            lblMission.Text = nom + "-" + numero.ToString();
            BarBudget bd = new BarBudget(budget, budgetactuelle);
            bd.Top = pbPlanete.Top-40;
            bd.Left = pbPlanete.Left + pbPlanete.Width + 30;
            this.Controls.Add(bd);
            dgDepense.DataSource = dtDepense;
            

        }

        private Image getImage(string planete)
        {
            switch (planete.ToLower())
            {
                case "mercure":
                    return Properties.Resources.mercury;
                case "vénus":
                    return Properties.Resources.venus;
                case "terre":
                    return Properties.Resources.earth;
                case "mars":
                    return Properties.Resources.mars;
                case "jupiter":
                    return Properties.Resources.jupiter;
                case "saturne":
                    return Properties.Resources.saturne;
                case "uranus":
                    return Properties.Resources.uranus;
                case "neptune":
                    return Properties.Resources.neptune;
                case "la 9ème planète":
                    return Properties.Resources._9planete;
                case "aina":
                    return Properties.Resources.Aina;
                case "aurae":
                    return Properties.Resources.Aurae;
                case "kobaia":
                    return Properties.Resources.Kobaia;
                case "malaria":
                    return Properties.Resources.Malaria;
                case "muh":
                    return Properties.Resources.Muh;
                case "sckxyss":
                    return Properties.Resources.Sckxyss;
                case "setna":
                    return Properties.Resources.setna;
                case "sohia":
                    return Properties.Resources.Sohia;
                default:
                    return null;
            }
        }
    }
}
