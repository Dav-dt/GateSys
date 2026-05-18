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
    public partial class Indic : UserControl
    {
        public Indic()
        {
            InitializeComponent();
        }

        public Indic(DateTime date, String apprecation,
            int sommeVersee, string nomCode)
        {
            InitializeComponent();

            DataRow[] drNom = MesDatas.DsGlobal.Tables["Informateur"].Select(
                $"nomCode = '{nomCode}'");
             lblNomIndic.Text = drNom[0]["nom"].ToString();

            dtIndic.Text = date.ToString();
            txtAppr.Text = apprecation;
            lblSommeVersee.Text = $"{sommeVersee.ToString()} $DG";


            picIndic.Image = Properties.Resources.indic;
        }
    }
}
