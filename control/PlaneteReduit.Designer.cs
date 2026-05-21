namespace saeStargateTUAILLON_LONGO_YURTSEBEN.control
{
    partial class PlaneteReduit
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbPlanete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanete)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.Location = new System.Drawing.Point(9, 117);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(90, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "label1";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(12, 144);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "label2";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // pbPlanete
            // 
            this.pbPlanete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlanete.Location = new System.Drawing.Point(9, 11);
            this.pbPlanete.Name = "pbPlanete";
            this.pbPlanete.Size = new System.Drawing.Size(90, 93);
            this.pbPlanete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlanete.TabIndex = 0;
            this.pbPlanete.TabStop = false;
            // 
            // PlaneteReduit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pbPlanete);
            this.Name = "PlaneteReduit";
            this.Size = new System.Drawing.Size(108, 168);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlanete;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNombre;
    }
}
