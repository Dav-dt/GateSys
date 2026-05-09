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
    public partial class Alien : UserControl
    {
        public Alien()
        {
            InitializeComponent();
        }

        public Alien(string nom,string race, List<string> planete,Image image)
        {
            InitializeComponent();
            lblNom.Text = nom;
            lblRace.Text = race;

            for (int i = 0; i < planete.Count(); i++)
            {
                if (i == planete.Count() - 1)
                {
                    lblPlanete.Text += planete[i];
                }
                else
                {
                    lblPlanete.Text += planete[i] + "/";
                }
            }

            pbAlien.Image = image;

        }
        public Alien(string nom, string race, Image image)
        {
            InitializeComponent();
            lblNom.Text = nom;
            lblRace.Text = race;

            lblPlanete.ForeColor = Color.Red;
            lblPlanete.Text = "Inconnu";

            pbAlien.Image = image;

        }
    }
}
