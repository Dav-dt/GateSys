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

        public Alien(string nom,string race, List<string> planete)
        {
            InitializeComponent();
            lblNom.Text = nom;
            lblRace.Text = race;

            if (planete.Count > 0)
            {
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
            }
            else
            {
                lblPlanete.ForeColor = Color.Red;
                lblPlanete.Text = "Inconnu";
            }

            pbAlien.Image = getImage(race);

        }
        public Alien(string nom, string race)
        {
            InitializeComponent();
            lblNom.Text = nom;
            lblRace.Text = race;

            lblPlanete.ForeColor = Color.Red;
            lblPlanete.Text = "Inconnu";

            pbAlien.Image = getImage(race);

        }

        private Image getImage(string nom)
        {
            switch (nom.ToLower())
            {
                case "vert":
                    return Properties.Resources.vert;
                case "orange":
                    return Properties.Resources.orange;
                case "bleu":
                    return Properties.Resources.bleu;
                case "rose":
                    return Properties.Resources.rose;
                case "pourpre":
                    return Properties.Resources.pourpre;
                case "violet":
                    return Properties.Resources.violet;
                case "marron":
                    return Properties.Resources.marron;
                case "gris":
                    return Properties.Resources.gris;
                default: return null;
            }
        }
        public string getNom()
        {
            return lblNom.Text.ToLower();
        }

        public string getCouleur()
        {
            return lblRace.Text.ToLower();
        }


    }
}
