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
            ajoutAlien();
            DataSet ds = MesDatas.DsGlobal;
            DataTable dt = ds.Tables["Espece"];
            DataTable couleur = dt.DefaultView.ToTable(true, "couleur");
            foreach (DataRow row in couleur.Rows)
            {
                cboCouleur.Items.Add(row["couleur"]);
            }
        }

        private void ajoutAlien()
        {
            DataSet ds = MesDatas.DsGlobal;

            DataRow[] dr = ds.Tables["Espece"].Select();
            //MessageBox.Show(dr.Count().ToString());

            foreach (DataRow ligne in dr)
            {
                List<string> nomPlanete = getPlanete(ligne["id"].ToString());
                Alien al = new Alien(ligne["nom"].ToString(), ligne["couleur"].ToString(), nomPlanete);
                flpRace.Controls.Add(al);
            }
        }

        private List<string> getPlanete(string id)
        {
            List<string> res = new List<string>();
            DataSet ds = MesDatas.DsGlobal;
            DataRow[] dr = ds.Tables["Habiter"].Select($"idEspece={id}");
            foreach (DataRow ligne in dr)
            {
                res.Add(ligne["nomPlanete"].ToString());
            }
            return res;
        }

        private void Clear()
        {
            flpRace.Controls.Clear();
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            Clear();
            ajoutAlien();
            string nom = txtNom.Text.ToLower();
            string couleur = cboCouleur.SelectedItem.ToString().ToLower();
            //MessageBox.Show(couleur);
            

            for (int i = flpRace.Controls.Count - 1; i >= 0; i--)
            {
                if (flpRace.Controls[i] is Alien al)
                {
                    //MessageBox.Show(couleur + "      " + al.getCouleur());
                    if (!(al.getNom().Contains(nom)) || (al.getCouleur() != couleur))
                    {
                        //MessageBox.Show(al.getCouleur());
                        flpRace.Controls.Remove(al);
                    }
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
