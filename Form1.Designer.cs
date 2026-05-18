namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInfosPlanetes = new System.Windows.Forms.Button();
            this.btnRaces = new System.Windows.Forms.Button();
            this.btnNouvellesMissions = new System.Windows.Forms.Button();
            this.btnTableauDeBord = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.pnlAffichageMissions = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnInfosPlanetes
            // 
            this.btnInfosPlanetes.Location = new System.Drawing.Point(33, 483);
            this.btnInfosPlanetes.Name = "btnInfosPlanetes";
            this.btnInfosPlanetes.Size = new System.Drawing.Size(155, 47);
            this.btnInfosPlanetes.TabIndex = 0;
            this.btnInfosPlanetes.Text = "Infos planetes";
            this.btnInfosPlanetes.UseVisualStyleBackColor = true;
            this.btnInfosPlanetes.Click += new System.EventHandler(this.btnInfosPlanetes_Click);
            // 
            // btnRaces
            // 
            this.btnRaces.Location = new System.Drawing.Point(33, 416);
            this.btnRaces.Name = "btnRaces";
            this.btnRaces.Size = new System.Drawing.Size(155, 44);
            this.btnRaces.TabIndex = 1;
            this.btnRaces.Text = "Races";
            this.btnRaces.UseVisualStyleBackColor = true;
            this.btnRaces.Click += new System.EventHandler(this.btnRaces_Click);
            // 
            // btnNouvellesMissions
            // 
            this.btnNouvellesMissions.Location = new System.Drawing.Point(33, 324);
            this.btnNouvellesMissions.Name = "btnNouvellesMissions";
            this.btnNouvellesMissions.Size = new System.Drawing.Size(155, 66);
            this.btnNouvellesMissions.TabIndex = 2;
            this.btnNouvellesMissions.Text = "Nouvelles Missions";
            this.btnNouvellesMissions.UseVisualStyleBackColor = true;
            this.btnNouvellesMissions.Click += new System.EventHandler(this.btnNouvellesMissions_Click);
            // 
            // btnTableauDeBord
            // 
            this.btnTableauDeBord.Location = new System.Drawing.Point(33, 226);
            this.btnTableauDeBord.Name = "btnTableauDeBord";
            this.btnTableauDeBord.Size = new System.Drawing.Size(155, 65);
            this.btnTableauDeBord.TabIndex = 3;
            this.btnTableauDeBord.Text = "Tableau de Bord";
            this.btnTableauDeBord.UseVisualStyleBackColor = true;
            this.btnTableauDeBord.Click += new System.EventHandler(this.btnTableauDeBord_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(43, 536);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(132, 37);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // pnlAffichageMissions
            // 
            this.pnlAffichageMissions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAffichageMissions.Location = new System.Drawing.Point(293, 18);
            this.pnlAffichageMissions.Name = "pnlAffichageMissions";
            this.pnlAffichageMissions.Size = new System.Drawing.Size(833, 555);
            this.pnlAffichageMissions.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 585);
            this.Controls.Add(this.pnlAffichageMissions);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnTableauDeBord);
            this.Controls.Add(this.btnNouvellesMissions);
            this.Controls.Add(this.btnRaces);
            this.Controls.Add(this.btnInfosPlanetes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Gestion Interstellaire";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInfosPlanetes;
        private System.Windows.Forms.Button btnRaces;
        private System.Windows.Forms.Button btnNouvellesMissions;
        private System.Windows.Forms.Button btnTableauDeBord;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel pnlAffichageMissions;
    }
}

