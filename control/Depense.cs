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
    public partial class Depense : UserControl
    {
        public Depense()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.simpledep;
        }

        public Depense(int num, DateTime d, int montant, string motif,
            int typeDepense)
        {
            InitializeComponent();
            lblNumero.Text = "No:"+num.ToString();
            dateTimePicker1.Text = d.ToShortDateString();
            lblMontant.Text = montant.ToString();
            lblMotif.Text = motif;

            DataRow[] drTypeDep = MesDatas.DsGlobal.Tables["TypeDepense"].Select(
                $"id = {typeDepense}");

            string libelleType;
            if ( drTypeDep.Length > 0 )
                libelleType = drTypeDep[0]["libelle"].ToString();
            else
                libelleType = "Autre";

            switch ( libelleType )
            {
                case "DataBaz":
                    pictureBox1.Image = Properties.Resources.qDatabaz;
                    break;
                case "Informateur":
                    pictureBox1.Image = Properties.Resources.indic;
                    break;
                case "Réparation":
                    pictureBox1.Image = Properties.Resources.reparation;
                    break;
                case "Droit de passage":
                    pictureBox1.Image = Properties.Resources.droiPassage;
                    break;

                default:
                    pictureBox1.Image = Properties.Resources.simpledep;
                    break;
            }

        }

        private void Depense_Load(object sender, EventArgs e)
        {

        }
    }
}
