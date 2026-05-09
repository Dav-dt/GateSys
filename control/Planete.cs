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
    }
}
