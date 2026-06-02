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
            Style.InitControles(this);

        }

        private void frmRace_Load(object sender, EventArgs e)
        {
            //ajoutAlien();
            rbTous.Checked = true;
            DataSet ds = MesDatas.DsGlobal;
            DataTable dt = ds.Tables["Espece"];
            DataTable couleur = dt.DefaultView.ToTable(true, "couleur");
            cboCouleur.Items.Add("Tous");
            foreach (DataRow row in couleur.Rows)
            {
                cboCouleur.Items.Add(row["couleur"]);
            }
            cboCouleur.SelectedIndex = 0;
            Style.InitControles(this);
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

        private void RafraichirAliens()
        {
            Clear();
            DataSet ds = MesDatas.DsGlobal;

            if (rbAllie.Checked)
            {
                if (!ds.Relations.Contains("relAllieEspece"))
                {
                    DataRelation rel = new DataRelation("relAllieEspece", MesDatas.DsGlobal.Tables["Espece"].Columns["id"], MesDatas.DsGlobal.Tables["Allie"].Columns["idEspece"]);
                    ds.Relations.Add(rel);
                }
                DataRow[] allie = ds.Tables["Allie"].Select();
                if (allie.Length > 0)
                {
                    foreach (DataRow dr in allie)
                    {
                        DataRow espece = dr.GetParentRow("relAllieEspece");
                        List<string> nomPlanete = getPlanete(espece["id"].ToString());
                        Alien al = new Alien(espece["nom"].ToString(), espece["couleur"].ToString(), nomPlanete, $"Bienveillance:{dr["degreBienveillance"].ToString()}", $"{dr["instrumentMusique"].ToString()}",Color.Green);
                        flpRace.Controls.Add(al);
                    }
                }
            }
            else if (rbEnnemi.Checked)
            {
                if (!ds.Relations.Contains("relAllieEnnemi"))
                {
                    DataRelation rel = new DataRelation("relAllieEnnemi", MesDatas.DsGlobal.Tables["Espece"].Columns["id"], MesDatas.DsGlobal.Tables["Ennemi"].Columns["idEspece"]);
                    ds.Relations.Add(rel);
                }
                DataRow[] allie = ds.Tables["Ennemi"].Select();
                if (allie.Length > 0)
                {
                    foreach (DataRow dr in allie)
                    {
                        DataRow espece = dr.GetParentRow("relAllieEnnemi");
                        List<string> nomPlanete = getPlanete(espece["id"].ToString());
                        Alien al = new Alien(espece["nom"].ToString(), espece["couleur"].ToString(), nomPlanete, $"Agréssivité:{dr["degreAgressivite"].ToString()}", $"{dr["typeArme"].ToString()}", Color.Red);
                        flpRace.Controls.Add(al);
                    }
                }
            }
            else
            {
                ajoutAlien();
            }

            string nom = txtNom.Text.ToLower();
            string couleur = "";
            if (cboCouleur.SelectedItem != null)
            {
                couleur = cboCouleur.SelectedItem.ToString().ToLower();
                if (couleur == "tous")
                {
                    couleur = "";
                }
            }

            for (int i = flpRace.Controls.Count - 1; i >= 0; i--)
            {
                if (flpRace.Controls[i] is Alien al)
                {
                    if (!(al.getNom().ToLower().Contains(nom)) || (al.getCouleur().ToLower() != couleur && !string.IsNullOrEmpty(couleur)))
                    {
                        flpRace.Controls.Remove(al);
                    }
                }
            }
            Style.InitControles(this);
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            RafraichirAliens();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEnnemi.Checked) RafraichirAliens();
        }

        private void rbTous_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTous.Checked) RafraichirAliens();
        }

        private void rbAllie_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllie.Checked) RafraichirAliens();
        }

        private void cboCouleur_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFiltre_Click(sender, e);
        }
    }
}
