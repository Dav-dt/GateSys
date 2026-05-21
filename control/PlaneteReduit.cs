using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saeStargateTUAILLON_LONGO_YURTSEBEN.control
{
    public partial class PlaneteReduit : UserControl
    {
        public PlaneteReduit()
        {
            InitializeComponent();
        }
        public PlaneteReduit(String non, int nombre)
        {
            InitializeComponent();
            lblNom.Text = non;
            lblNombre.Text = nombre.ToString();
            if (nombre == 0)
            {
                pbPlanete.Image = GriserImage(getImage(non));
                lblNombre.ForeColor = Color.Red;
            }
            else
            {
                pbPlanete.Image = getImage(non);
            }
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
        public static Bitmap GriserImage(Image imageOriginale)
        {
            // 1. Créer un nouveau bitmap de la même taille que l'image d'origine
            Bitmap imageGrisee = new Bitmap(imageOriginale.Width, imageOriginale.Height);

            // 2. Initialiser l'objet Graphics pour dessiner sur la nouvelle image
            using (Graphics g = Graphics.FromImage(imageGrisee))
            {
                // 3. Définir la matrice de couleur pour les niveaux de gris
                ColorMatrix matriceGris = new ColorMatrix(new float[][]
                {
            new float[] {.3f, .3f, .3f, 0, 0},
            new float[] {.59f, .59f, .59f, 0, 0},
            new float[] {.11f, .11f, .11f, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {0, 0, 0, 0, 1}
                });

                // 4. Associer la matrice à des attributs d'image
                using (ImageAttributes attributs = new ImageAttributes())
                {
                    attributs.SetColorMatrix(matriceGris);

                    // 5. Dessiner l'image originale sur la nouvelle en appliquant les attributs
                    g.DrawImage(imageOriginale,
                        new Rectangle(0, 0, imageOriginale.Width, imageOriginale.Height),
                        0, 0, imageOriginale.Width, imageOriginale.Height,
                        GraphicsUnit.Pixel, attributs);
                }
            }

            return imageGrisee;
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
