namespace saeStargateTUAILLON_LONGO_YURTSEBEN.control
{
    partial class Membre
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.pbMenbre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenbre)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.Location = new System.Drawing.Point(3, 98);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(85, 19);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "label1";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrenom
            // 
            this.lblPrenom.Location = new System.Drawing.Point(3, 117);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(85, 19);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "label2";
            this.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbMenbre
            // 
            this.pbMenbre.Location = new System.Drawing.Point(13, 17);
            this.pbMenbre.Name = "pbMenbre";
            this.pbMenbre.Size = new System.Drawing.Size(67, 78);
            this.pbMenbre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenbre.TabIndex = 0;
            this.pbMenbre.TabStop = false;
            // 
            // Membre
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pbMenbre);
            this.Name = "Membre";
            this.Size = new System.Drawing.Size(94, 142);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenbre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMenbre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
    }
}
