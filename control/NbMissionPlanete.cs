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
    public partial class NbMissionPlanete : UserControl
    {
        public NbMissionPlanete()
        {
            InitializeComponent();
        }
        public NbMissionPlanete(DataTable dt)
        {
            InitializeComponent();
            foreach (DataRow dr in dt.Rows)
            {
                PlaneteReduit planete = new PlaneteReduit(dr["Planete"].ToString(), Convert.ToInt32(dr["NombreDeMissions"]));
                flpPlanete.Controls.Add(planete);
            }
        }
    }
}
