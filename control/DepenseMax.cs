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
    public partial class DepenseMax : UserControl
    {
        public DepenseMax()
        {
            InitializeComponent();
        }

        public DepenseMax(DataRow dr)
        {
            InitializeComponent();
            lblNomMission.Text = dr["Mission"].ToString();
            lblNomChef.Text = dr["nom"].ToString();
            lblPrenom.Text = dr["prenom"].ToString();



            DataTable dtUnique = dr.Table.Clone(); 
            dtUnique.ImportRow(dr);                

           
            dgvDepense.DataSource = dtUnique;


            if (dgvDepense.Columns.Contains("Mission")) dgvDepense.Columns["Mission"].Visible = false;
            if (dgvDepense.Columns.Contains("nom")) dgvDepense.Columns["nom"].Visible = false;
            if (dgvDepense.Columns.Contains("prenom")) dgvDepense.Columns["prenom"].Visible = false;

            
               
            dgvDepense.Columns["recap"].HeaderText = "Dépenses les plus importantes";
            

        }
    }
}
