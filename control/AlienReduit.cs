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
    public partial class AlienReduit : UserControl
    {
        public AlienReduit()
        {
            InitializeComponent();
        }
        public AlienReduit(string couleur,string nomCode,string nom,int somme)
        {
            InitializeComponent();
            pbAlien.Image = getImage(couleur);
            lblNomCode.Text = nomCode;
            lblEspece.Text = nom;
            lblSomme.Text = somme.ToString();
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
    }
}
