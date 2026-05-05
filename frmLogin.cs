using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand($@"SELECT mdp FROM Admin
                                                    WHERE login = '{txtLogin.Text}'",
                                                        Connexion.Connec);
            object resultat = cmd.ExecuteScalar();

            if (resultat != null && resultat != DBNull.Value)
            {
                string mdpStocke = resultat.ToString();
                bool mdpValide = BCrypt.Net.BCrypt.Verify(txtMdp.Text,
                    mdpStocke);

                if (mdpValide)
                {
                    MessageBox.Show("Connexion réussie !");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect.");
                }
            }
            else
            {
                MessageBox.Show("Le nom d'utilisateur n'existe pas.");
            }
        }

        private void btnAfficherMdp_Click(object sender, EventArgs e)
        {
            if ( txtMdp.PasswordChar == '●')
                txtMdp.PasswordChar = '\0';
            else
                txtMdp.PasswordChar = '●';
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
