using saeStargateTUAILLON_LONGO_YURTSEBEN.control;
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
    public partial class frmRace : Form
    {
        public frmRace()
        {
            InitializeComponent();
        }

        private void frmRace_Load(object sender, EventArgs e)
        {
            DataSet ds = MesDatas.DsGlobal;

            DataRow[] dr = ds.Tables["Espece"].Select();
            //MessageBox.Show(dr.Count().ToString());

            foreach(DataRow ligne in dr)
            {
                Alien al = new Alien(ligne["nom"].ToString(), ligne["couleur"].ToString());
                flpRace.Controls.Add(al);
            }
        }
    }
}
