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
    public partial class frmPlanete : Form
    {
        public frmPlanete()
        {
            InitializeComponent();
        }

        private void frmPlanete_Load(object sender, EventArgs e)
        {
            DataSet ds = MesDatas.DsGlobal;
            int top = 10;
            int left = 10;
            int i = 0;

            foreach(DataRow item in ds.Tables["Planete"].Rows)
            {
                string nom = item["nom"].ToString();
                int temp;
                if (item.IsNull("temperature"))
                {
                    temp = 0;
                }
                else
                {
                    temp = Convert.ToInt32(item["temperature"]);
                }
                double gravite;
                if (item.IsNull("gravite"))
                {
                    gravite = 0;
                }
                else
                {
                    gravite = Convert.ToDouble(item["gravite"]);
                }

                int databaz;

                if (item.IsNull("dataBazON"))
                {
                    databaz = 0;
                }
                else
                {
                    databaz = Convert.ToInt32(item["dataBazON"]);
                }



                Planete pl = new Planete(nom, nom, temp,gravite, databaz);
                pl.Top = top;
                pl.Left = left;
                i++;
                if (i % 3 == 0)
                {
                    top += 180;
                    left = 10;
                }
                else
                {

                    left += 400;
                }


                this.Controls.Add(pl);
            }
        }
    }
}
