using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saeStargateTUAILLON_LONGO_YURTSEBEN.control
{
    public partial class Planete : UserControl
    {

        
        public Planete()
        {
            InitializeComponent();
        }
        

        public Planete(string non,Image img,int temperature,float gravite,int databaz)
        {
            InitializeComponent();
            //this.BackColor = Color.FromArgb(60, 56, 54);
            pbPlanete.Image = img;
            lblPlanete.Text = non.ToUpper();
            lblGravite.Text += " " + gravite.ToString();
            
           if(temperature >= 0)
            {
                ajouteJauge(Color.LightGreen);
                if (temperature > 40) ajouteJauge(Color.Orange);
                if (temperature > 100) ajouteJauge(Color.Red);
            }
            else if(temperature < 0)
            {
                ajouteJauge(Color.FromArgb(122,242,252));
                if (temperature < -40) ajouteJauge(Color.FromArgb(100,131,249));
                if (temperature < -100) ajouteJauge(Color.FromArgb(128,1,254));
            }
            placeTemp(temperature);
            if(databaz == 1)
            {
                chkDatabaz.Checked = true;
            }
        }

        public Planete(string non, string planete, int temperature, double gravite, int databaz)
        {

            InitializeComponent();
            temp = temperature;
            grav = gravite;
            data = databaz;

            //this.BackColor = Color.FromArgb(60, 56, 54);
            pbPlanete.Image = getImage(planete);
            lblPlanete.Text = non.ToUpper();
            lblGravite.Text += " " + gravite.ToString();

            if (temperature >= 0)
            {
                ajouteJauge(Color.LightGreen);
                if (temperature > 40) ajouteJauge(Color.Orange);
                if (temperature > 100) ajouteJauge(Color.Red);
            }
            else if (temperature < 0)
            {
                ajouteJauge(Color.FromArgb(122, 242, 252));
                if (temperature < -40) ajouteJauge(Color.FromArgb(100, 131, 249));
                if (temperature < -100) ajouteJauge(Color.FromArgb(128, 1, 254));
            }
            placeTemp(temperature);
            if (databaz == 1)
            {
                chkDatabaz.Checked = true;
            }
            
        }
        private int temp;
        private double grav;
        private int data;

        public Planete(string non, string planete, int temperature, double gravite, int databaz,bool enable)
        {
            temp = temperature;
            grav = gravite;
            data = databaz;
            InitializeComponent();
            //this.BackColor = Color.FromArgb(60, 56, 54);
            pbPlanete.Image = getImage(planete);
            lblPlanete.Text = non.ToUpper();
            lblGravite.Text += " " + gravite.ToString();

            if (temperature >= 0)
            {
                ajouteJauge(Color.LightGreen);
                if (temperature > 40) ajouteJauge(Color.Orange);
                if (temperature > 100) ajouteJauge(Color.Red);
            }
            else if (temperature < 0)
            {
                ajouteJauge(Color.FromArgb(122, 242, 252));
                if (temperature < -40) ajouteJauge(Color.FromArgb(100, 131, 249));
                if (temperature < -100) ajouteJauge(Color.FromArgb(128, 1, 254));
            }
            placeTemp(temperature);
            if (databaz == 1)
            {
                chkDatabaz.Checked = true;
            }
            btnDetail.Enabled = false;
            btnDetail.Visible = false;
            this.BorderStyle = BorderStyle.None;
        }

        private void ajouteJauge(Color color)
        {
            int debut = rtxtTemp.TextLength;
            rtxtTemp.AppendText("||||");
            rtxtTemp.Select(debut, 4);
            rtxtTemp.SelectionColor = color;
            rtxtTemp.DeselectAll();
        }

        private void rtxtTemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeTemp(int temp)
        {
            int top = rtxtTemp.Top;
            int left = rtxtTemp.Left;
            int longueur = rtxtTemp.TextLength;

            Label temperature = new Label();
            temperature.Text = temp.ToString();
            temperature.AutoSize = true;
            temperature.Left = left;

            if (longueur == 4) temperature.Left = left;
            if (longueur == 8) temperature.Left = left+40;
            if (longueur == 12) temperature.Left = left+80;
            temperature.Top = top + 40;

            this.Controls.Add(temperature);
        }

        private void chkDatabaz_CheckedChanged(object sender, EventArgs e)
        {

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

        private void Planete_Load(object sender, EventArgs e)
        {

        }
        private string getNom()
        {
            return lblPlanete.Text;
        } 

        private void btnDetail_Click(object sender, EventArgs e)
        {
            frmInfoPlanete infoplanete = new frmInfoPlanete(getNom(), getNom(), temp, grav, data);
            infoplanete.ShowDialog();

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Définir la couleur et l'épaisseur du pinceau
            Color couleurBordure = Color.FromArgb(243, 214, 144);
            int epaisseurBordure = 2;

            // Créer le "stylo" (Pen)
            using (Pen pen = new Pen(couleurBordure, epaisseurBordure))
            {
                // On ajuste légèrement le rectangle pour que la bordure ne soit pas coupée par les bords du contrôle
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(
                    epaisseurBordure / 2,
                    epaisseurBordure / 2,
                    this.Width - epaisseurBordure,
                    this.Height - epaisseurBordure
                );

                // On dessine le rectangle sur le UserControl
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
    }
}
