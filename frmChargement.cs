using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    public partial class frmChargement : Form
    {
        public frmChargement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            Style.InitControles(this);
            picCharg.Image = imgAleatoire();
            this.Location = new Point(0, 0);

        }

        //c'est bo
        public Image imgAleatoire()
        {
            Random rnd = new Random();
            int i = rnd.Next(1, 8);
            switch ( i )
            {
                case 1:
                    return Properties.Resources.pourpre;

                case 2:
                    return Properties.Resources.orange;
                
                case 3:
                    return Properties.Resources.bleu;

                case 4:
                    return Properties.Resources.rose;

                case 5:
                    return Properties.Resources.vert;

                case 6:
                    return Properties.Resources.violet;

                case 7:
                    return Properties.Resources.marron;

                default:
                    return Properties.Resources.gris;
            }
        }
    }
}
