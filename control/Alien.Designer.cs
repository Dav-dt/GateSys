namespace saeStargateTUAILLON_LONGO_YURTSEBEN.control
{
    partial class Alien
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbAlien = new System.Windows.Forms.PictureBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblPlanete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAlien
            // 
            this.pbAlien.Location = new System.Drawing.Point(18, 16);
            this.pbAlien.Name = "pbAlien";
            this.pbAlien.Size = new System.Drawing.Size(144, 148);
            this.pbAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlien.TabIndex = 0;
            this.pbAlien.TabStop = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(181, 18);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(57, 20);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "label1";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(181, 62);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(35, 13);
            this.lblRace.TabIndex = 2;
            this.lblRace.Text = "label2";
            // 
            // lblPlanete
            // 
            this.lblPlanete.AutoSize = true;
            this.lblPlanete.Location = new System.Drawing.Point(181, 106);
            this.lblPlanete.Name = "lblPlanete";
            this.lblPlanete.Size = new System.Drawing.Size(0, 13);
            this.lblPlanete.TabIndex = 3;
            // 
            // Alien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.lblPlanete);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pbAlien);
            this.Name = "Alien";
            this.Size = new System.Drawing.Size(366, 187);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAlien;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblPlanete;
    }
}
