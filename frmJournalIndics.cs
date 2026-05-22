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
    public partial class frmJournalIndics : Form
    {
        private string m_nomPlanete;
        private int m_numMission;

        public frmJournalIndics()
        {
            InitializeComponent();
        }

        public frmJournalIndics(string nomPlanete, int numMission)
        {
            InitializeComponent();

            m_nomPlanete = nomPlanete;
            m_numMission = numMission;

        }

        private void frmJournalIndics_Load(object sender, EventArgs e)
        {
            DataRow[] drIndics = MesDatas.DsGlobal.Tables["Contact"].Select(
                $"nomPlanete = '{m_nomPlanete}' " +
                $"AND numeroMission = {m_numMission}", "dateC ASC");
            int totalVerse = 0;
            
            int positionY = 0;
            foreach ( DataRow dr in drIndics )
            {
                Indic ind = new Indic(
                    Convert.ToDateTime(dr["dateC"]),
                    dr["appreciation"].ToString(),
                    Convert.ToInt32(dr["sommeVersee"]),
                    dr["nomCodeInformateur"].ToString()
                    );
                ind.Location = new Point(0, positionY);
                positionY+= ind.Height + 5;
                pnlIndics.Controls.Add(ind);

                totalVerse += Convert.ToInt32(dr["sommeVersee"]);
            }
            llblTotalSomme.Text= $"{totalVerse} $DG";

            Style.InitControles(this);
        }
    }
}
