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
    public partial class Negociation : UserControl
    {
        public Negociation()
        {
            InitializeComponent();
        }

        public Negociation(string nom, string bienveillance, string instru,
            int databaz,Image img)
        {
            InitializeComponent();
            lblDatabaz.Text = databaz.ToString();
            lblInstru.Text = instru;
            lblDegBienveillance.Text = bienveillance;
            lblNom.Text = nom;
            picAlien.Image = img;
        }

        private void Negociation_Load(object sender, EventArgs e)
        {

        }
    }
}
