using saeStargateTUAILLON_LONGO_YURTSEBEN.control;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    public partial class frmNegociation : Form
    {
        private string m_nomPlanete;
        private int m_numeroMission;

        private DataTable dtEspeceAllieDetaillee;


        public frmNegociation()
        {
            InitializeComponent();
        }

        public frmNegociation(string nomPlanete, int numeroMission)
        {
            InitializeComponent();

            m_nomPlanete = nomPlanete;
            m_numeroMission = numeroMission;
        }

        private void btnValiderDemande_Click(object sender, EventArgs e)
        {
            if (txtQtDatabaz.Text == String.Empty ||
                !int.TryParse(txtQtDatabaz.Text, out int nb) || nb <= 0)
            {
                MessageBox.Show("Veuillez entrer une quantité valide de DataBaz");
                return;
            }



            DataRow dr = MesDatas.DsGlobal.Tables["Negocier"].NewRow();
            dr["numeroMission"] = m_numeroMission;
            dr["nomPlanete"] = m_nomPlanete;
            dr["idEspeceAllie"] = cmbAllie.SelectedValue;
            dr["qteDataBaz"] = Convert.ToInt32(txtQtDatabaz.Text);

            bool existeDeja = MesDatas.DsGlobal.Tables["Negocier"].Select(
                                $@"numeroMission = {m_numeroMission} AND
                                   nomPlanete = '{m_nomPlanete}' AND
                                   idEspeceAllie = {cmbAllie.SelectedValue}").Length > 0;

            if ( existeDeja )
            {
                MessageBox.Show("Vous ne pouvez pas négocier deux fois avec le même allié!","Erreur Logique",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MesDatas.DsGlobal.Tables["Negocier"].Rows.Add(dr);

            MessageBox.Show("Demande de négociation envoyée avec succès !");

            //synchro bdd
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(
                    $"INSERT INTO Negocier(nomPlanete, numeroMission,idEspeceAllie," +
                    $"qteDataBaz)" +
                    $"Values('{m_nomPlanete}',{m_numeroMission}," +
                    $"{cmbAllie.SelectedValue},{Convert.ToInt32(txtQtDatabaz.Text)})",
                    Connexion.Connec);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }

            //rafraichir
            AfficherNegociations();
            Style.InitControles(this);
        }

        public Image getImage(string couleur)
        {

            switch (couleur)
            {
                case "Pourpre":
                    return Properties.Resources.pourpre;

                case "Orange":
                    return Properties.Resources.orange;

                case "Bleu":
                    return Properties.Resources.bleu;

                case "Rose":
                    return Properties.Resources.rose;

                case "Vert":
                    return Properties.Resources.vert;

                case "Violet":
                    return Properties.Resources.violet;

                case "Marron":
                    return Properties.Resources.marron;

                default:
                    return Properties.Resources.gris;
            }

        }

        private void AfficherNegociations()
        {
            DataRow[] drNegociations = MesDatas.DsGlobal.Tables["Negocier"].Select(
                $"nomPlanete = '{m_nomPlanete}' AND numeroMission = {m_numeroMission}");
            pnlNegoc.Controls.Clear();

            int positionY = 10;
            if (drNegociations.Length > 0)
            {
                foreach (DataRow dr in drNegociations)
                {
                    foreach (DataRow d2 in dtEspeceAllieDetaillee.Rows)
                    {
                        if (Convert.ToInt32(d2["idEspece"]) ==
                            Convert.ToInt32(dr["idEspeceAllie"]))
                        {
                            string nomEspece = d2["nom"].ToString();
                            int qteDataBaz = Convert.ToInt32(dr["qteDataBaz"]);
                            string bienveillance = d2["degreBienveillance"].ToString();
                            string instru = d2["instrumentMusique"].ToString();
                            DataRow[] extraCouleur = dtEspeceAllieDetaillee.Select(
                        $"idEspece = {Convert.ToInt32(d2["idEspece"])}");
                            string couleur = extraCouleur[0]["couleur"].ToString();

                            Negociation negociation = new Negociation(nomEspece, bienveillance,
                                instru, qteDataBaz, getImage(couleur));

                            negociation.Location = new Point(10, positionY);
                            positionY += negociation.Height + 10;
                            pnlNegoc.Controls.Add(negociation);

                        }
                    }
                }
            }

        }

        private void frmNegociation_Load(object sender, EventArgs e)
        {
            //datatable avec des vraies données jpp du schema horrible en plus en mode deco
            dtEspeceAllieDetaillee = new DataTable();
            dtEspeceAllieDetaillee.Columns.Add("idEspece", typeof(int));
            dtEspeceAllieDetaillee.Columns.Add("nom", typeof(string));
            dtEspeceAllieDetaillee.Columns.Add("degreBienveillance", typeof(string));
            dtEspeceAllieDetaillee.Columns.Add("couleur", typeof(string));
            dtEspeceAllieDetaillee.Columns.Add("instrumentMusique", typeof(string));
            foreach (DataRow dr in MesDatas.DsGlobal.Tables["Allie"].Rows)
            {
                DataRow[] drEspece = MesDatas.DsGlobal.Tables["Espece"].Select(
                    $"id = {dr["idEspece"]}");

                if (drEspece.Length > 0)
                {
                    DataRow drEspeceAllie = dtEspeceAllieDetaillee.NewRow();
                    drEspeceAllie["idEspece"] = dr["idEspece"];
                    drEspeceAllie["nom"] = drEspece[0]["nom"];
                    drEspeceAllie["degreBienveillance"] = dr["degreBienveillance"];
                    drEspeceAllie["couleur"] = drEspece[0]["couleur"];
                    drEspeceAllie["instrumentMusique"] = dr["instrumentMusique"];
                    dtEspeceAllieDetaillee.Rows.Add(drEspeceAllie);
                }
            }

            cmbAllie.DisplayMember = "nom";
            cmbAllie.ValueMember = "idEspece";
            cmbAllie.DataSource = dtEspeceAllieDetaillee;

            //rafraichir panel
            AfficherNegociations();
            Style.InitControles(this);
        }

        private void cmbAllie_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow[] extraCouleur = dtEspeceAllieDetaillee.Select(
                $"idEspece = {cmbAllie.SelectedValue}");
            string couleur = extraCouleur[0]["couleur"].ToString();

            picExtra.Image = getImage(couleur);
        }
    }
}
