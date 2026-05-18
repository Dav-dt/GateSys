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
    public partial class frmJournal : Form
    {
        private string m_nomPlanete;
        private int m_numeroMission;
        
        //binding source des familles
        private BindingSource m_bsJournal = new BindingSource();

        public frmJournal()
        {
            InitializeComponent();
        }

        public frmJournal(string nomPlanete, int numeroMission)
        {
            InitializeComponent();
            m_nomPlanete = nomPlanete;
            m_numeroMission = numeroMission;
        }

        private void frmJournal_Load(object sender, EventArgs e)
        {
            DataRow[] drJournal = MesDatas.DsGlobal.Tables["JournalDeBord"].Select(
                $"nomPlanete = '{m_nomPlanete}' " +
                $"AND numero = {m_numeroMission}","dateJ ASC");

            DataTable dtJournal = drJournal.CopyToDataTable();
            m_bsJournal.DataSource = dtJournal;

            if ( m_bsJournal.Count > 0 )
            {
                lblEventJournal.DataBindings.Add("Text",m_bsJournal, "commentaires");
                dtEventJournal.DataBindings.Add("Text",m_bsJournal, "dateJ");
            }
        }

        private void btnTTdebut_Click(object sender, EventArgs e)
        {
            m_bsJournal.MoveFirst();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            m_bsJournal.MovePrevious();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            m_bsJournal.MoveNext();
        }

        private void btnTTfin_Click(object sender, EventArgs e)
        {
            m_bsJournal.MoveLast();
        }

        private void btnDepenses_Click(object sender, EventArgs e)
        {
            frmJournalDepenses frmJournalDepenses = new frmJournalDepenses(m_nomPlanete, m_numeroMission);
            frmJournalDepenses.Show();
        }

        private void btnIndics_Click(object sender, EventArgs e)
        {
            frmJournalIndics frmJournalIndics = new frmJournalIndics(
                m_nomPlanete, m_numeroMission);
            frmJournalIndics.Show();
        }

        private void btnCapturesAfficher_Click(object sender, EventArgs e)
        {
            frmJournalCaptures frmJournalCaptures = new frmJournalCaptures(
                m_nomPlanete, m_numeroMission);
            frmJournalCaptures.Show();
        }
    }
}
