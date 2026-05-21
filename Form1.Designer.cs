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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.pnlAffichageMissions = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnStat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInfosPlanetes
            // 
            this.btnInfosPlanetes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfosPlanetes.Location = new System.Drawing.Point(50, 381);
            this.btnInfosPlanetes.Name = "btnInfosPlanetes";
            this.btnInfosPlanetes.Size = new System.Drawing.Size(192, 58);
            this.btnInfosPlanetes.TabIndex = 0;
            this.btnInfosPlanetes.Text = "Infos planetes";
            this.btnInfosPlanetes.UseVisualStyleBackColor = true;
            this.btnInfosPlanetes.Click += new System.EventHandler(this.btnInfosPlanetes_Click);
            // 
            // btnRaces
            // 
            this.btnRaces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaces.Location = new System.Drawing.Point(50, 298);
            this.btnRaces.Name = "btnRaces";
            this.btnRaces.Size = new System.Drawing.Size(192, 55);
            this.btnRaces.TabIndex = 1;
            this.btnRaces.Text = "Races";
            this.btnRaces.UseVisualStyleBackColor = true;
            this.btnRaces.Click += new System.EventHandler(this.btnRaces_Click);
            // 
            // btnNouvellesMissions
            // 
            this.btnNouvellesMissions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNouvellesMissions.Location = new System.Drawing.Point(50, 193);
            this.btnNouvellesMissions.Name = "btnNouvellesMissions";
            this.btnNouvellesMissions.Size = new System.Drawing.Size(192, 77);
            this.btnNouvellesMissions.TabIndex = 2;
            this.btnNouvellesMissions.Text = "Nouvelle Mission";
            this.btnNouvellesMissions.UseVisualStyleBackColor = true;
            this.btnNouvellesMissions.Click += new System.EventHandler(this.btnNouvellesMissions_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.Location = new System.Drawing.Point(19, 525);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(124, 48);
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
            // picLogo
            // 
            this.picLogo.Image = global::saeStargateTUAILLON_LONGO_YURTSEBEN.Properties.Resources.logo;
            this.picLogo.InitialImage = global::saeStargateTUAILLON_LONGO_YURTSEBEN.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(19, 33);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(268, 102);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // btnStat
            // 
            this.btnStat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStat.Location = new System.Drawing.Point(50, 461);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(192, 58);
            this.btnStat.TabIndex = 10;
            this.btnStat.Text = "Statistiques";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 585);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.pnlAffichageMissions);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnNouvellesMissions);
            this.Controls.Add(this.btnRaces);
            this.Controls.Add(this.btnInfosPlanetes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "gateSys Beta";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInfosPlanetes;
        private System.Windows.Forms.Button btnRaces;
        private System.Windows.Forms.Button btnNouvellesMissions;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel pnlAffichageMissions;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnStat;
    }
}

