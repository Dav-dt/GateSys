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
            //Style.InitControles(this);
        }

        private void frmPlanete_Load(object sender, EventArgs e)
        {
            DataSet ds = MesDatas.DsGlobal;


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
              


                flpPlanete.Controls.Add(pl);
            }
            Style.InitControles(this);
        }
    }
}
