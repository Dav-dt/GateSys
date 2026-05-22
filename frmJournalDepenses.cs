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
    public partial class frmJournalDepenses : Form
    {
        private string m_nomPlanete;
        private int m_numeroMission;

        public frmJournalDepenses()
        {
            InitializeComponent();
        }

        public frmJournalDepenses(string nomPlanete, int numeroMission)
        {
            InitializeComponent();
            m_nomPlanete = nomPlanete;
            m_numeroMission = numeroMission;
        }

        private void frmJournalDepenses_Load(object sender, EventArgs e)
        {
            pnlDepenses.AutoScroll = true;
            DataRow[] drDepenses = MesDatas.DsGlobal.Tables["Depense"].Select(
                $"nomPlanete = '{m_nomPlanete}' " +
                $"AND numeroMission = {m_numeroMission}", "dateD ASC");
            int totalDepense = 0;

            int positionY = 0;
            foreach ( DataRow row in drDepenses )
            {
                Depense depense = new Depense(
                             Convert.ToInt32(row["id"]),
                             Convert.ToDateTime(row["dateD"]),
                             Convert.ToInt32(row["montant"]),
                             row["motif"].ToString(),
                             Convert.ToInt32(row["idTypeDepense"]));
                depense.Location = new Point(0, positionY);
                this.pnlDepenses.Controls.Add(depense);
                positionY += depense.Height + 5;
                
                totalDepense += Convert.ToInt32(row["montant"]);
            }
            lblTotal.Text = totalDepense + " $DG";
            Style.InitControles(this);
        }
    }
}
