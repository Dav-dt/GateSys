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

    public partial class frmFicheMission : Form
    {
        private string m_nomPlanete;
        private int m_numero;

        public frmFicheMission()
        {
            InitializeComponent();
        }

        public frmFicheMission(string nomPlanete, int numero)
        {
            InitializeComponent();
            m_nomPlanete = nomPlanete;
            m_numero = numero;
        }

        private void frmFicheMission_Load(object sender, EventArgs e)
        {
            //verifier que la mission existe
            DataRow[] dr = MesDatas.DsGlobal.Tables["Mission"].Select(
                            $@"Numero = '{m_numero}' AND 
                            NomPlanete = '{m_nomPlanete}'");

            if (dr.Length == 0)
            {
                MessageBox.Show("Mission inexistante");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }
            
            lblMission.Text = $"Mission n°{m_numero} sur {m_nomPlanete}";




        }
    }
}
