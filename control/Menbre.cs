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
    public partial class Menbre : UserControl
    {
        public Menbre()
        {
            InitializeComponent();
        }

        public Menbre(string nom,string prenom,bool militaire)
        {
            InitializeComponent();
            lblNom.Text = nom;
            lblPrenom.Text = prenom;
            if (militaire)
            {
                Image img = Properties.Resources.militaire;
                pbMenbre.Image = img;
            }
            else
            {
                Image img = Properties.Resources.civil;
                pbMenbre.Image = img;
            }
        }
    }
}
