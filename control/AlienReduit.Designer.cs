namespace saeStargateTUAILLON_LONGO_YURTSEBEN.control
{
    partial class AlienReduit
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
            this.lblNomCode = new System.Windows.Forms.Label();
            this.lblEspece = new System.Windows.Forms.Label();
            this.lblSomme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAlien
            // 
            this.pbAlien.Location = new System.Drawing.Point(12, 15);
            this.pbAlien.Name = "pbAlien";
            this.pbAlien.Size = new System.Drawing.Size(76, 69);
            this.pbAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlien.TabIndex = 0;
            this.pbAlien.TabStop = false;
            // 
            // lblNomCode
            // 
            this.lblNomCode.AutoSize = true;
            this.lblNomCode.Location = new System.Drawing.Point(25, 87);
            this.lblNomCode.Name = "lblNomCode";
            this.lblNomCode.Size = new System.Drawing.Size(35, 13);
            this.lblNomCode.TabIndex = 1;
            this.lblNomCode.Text = "label1";
            // 
            // lblEspece
            // 
            this.lblEspece.AutoSize = true;
            this.lblEspece.Location = new System.Drawing.Point(25, 112);
            this.lblEspece.Name = "lblEspece";
            this.lblEspece.Size = new System.Drawing.Size(35, 13);
            this.lblEspece.TabIndex = 2;
            this.lblEspece.Text = "label2";
            // 
            // lblSomme
            // 
            this.lblSomme.AutoSize = true;
            this.lblSomme.Location = new System.Drawing.Point(25, 140);
            this.lblSomme.Name = "lblSomme";
            this.lblSomme.Size = new System.Drawing.Size(35, 13);
            this.lblSomme.TabIndex = 3;
            this.lblSomme.Text = "label3";
            // 
            // AlienReduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblSomme);
            this.Controls.Add(this.lblEspece);
            this.Controls.Add(this.lblNomCode);
            this.Controls.Add(this.pbAlien);
            this.Name = "AlienReduit";
            this.Size = new System.Drawing.Size(104, 160);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAlien;
        private System.Windows.Forms.Label lblNomCode;
        private System.Windows.Forms.Label lblEspece;
        private System.Windows.Forms.Label lblSomme;
    }
}
