namespace saeStargateTUAILLON_LONGO_YURTSEBEN.control
{
    partial class Indic
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
            this.dtIndic = new System.Windows.Forms.DateTimePicker();
            this.lblSommeVersee = new System.Windows.Forms.Label();
            this.lblAppr = new System.Windows.Forms.Label();
            this.txtAppr = new System.Windows.Forms.TextBox();
            this.picIndic = new System.Windows.Forms.PictureBox();
            this.lblNomIndic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIndic)).BeginInit();
            this.SuspendLayout();
            // 
            // dtIndic
            // 
            this.dtIndic.Enabled = false;
            this.dtIndic.Location = new System.Drawing.Point(13, 13);
            this.dtIndic.Name = "dtIndic";
            this.dtIndic.Size = new System.Drawing.Size(200, 26);
            this.dtIndic.TabIndex = 0;
            // 
            // lblSommeVersee
            // 
            this.lblSommeVersee.AutoSize = true;
            this.lblSommeVersee.Location = new System.Drawing.Point(241, 18);
            this.lblSommeVersee.Name = "lblSommeVersee";
            this.lblSommeVersee.Size = new System.Drawing.Size(51, 20);
            this.lblSommeVersee.TabIndex = 1;
            this.lblSommeVersee.Text = "label1";
            // 
            // lblAppr
            // 
            this.lblAppr.AutoSize = true;
            this.lblAppr.Location = new System.Drawing.Point(13, 63);
            this.lblAppr.Name = "lblAppr";
            this.lblAppr.Size = new System.Drawing.Size(98, 20);
            this.lblAppr.TabIndex = 2;
            this.lblAppr.Text = "Appreciation";
            // 
            // txtAppr
            // 
            this.txtAppr.Location = new System.Drawing.Point(13, 104);
            this.txtAppr.Multiline = true;
            this.txtAppr.Name = "txtAppr";
            this.txtAppr.ReadOnly = true;
            this.txtAppr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAppr.Size = new System.Drawing.Size(275, 121);
            this.txtAppr.TabIndex = 3;
            // 
            // picIndic
            // 
            this.picIndic.Location = new System.Drawing.Point(399, 18);
            this.picIndic.Name = "picIndic";
            this.picIndic.Size = new System.Drawing.Size(176, 162);
            this.picIndic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIndic.TabIndex = 4;
            this.picIndic.TabStop = false;
            // 
            // lblNomIndic
            // 
            this.lblNomIndic.AutoSize = true;
            this.lblNomIndic.Location = new System.Drawing.Point(374, 204);
            this.lblNomIndic.Name = "lblNomIndic";
            this.lblNomIndic.Size = new System.Drawing.Size(51, 20);
            this.lblNomIndic.TabIndex = 5;
            this.lblNomIndic.Text = "label2";
            // 
            // Indic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblNomIndic);
            this.Controls.Add(this.picIndic);
            this.Controls.Add(this.txtAppr);
            this.Controls.Add(this.lblAppr);
            this.Controls.Add(this.lblSommeVersee);
            this.Controls.Add(this.dtIndic);
            this.Name = "Indic";
            this.Size = new System.Drawing.Size(647, 237);
            ((System.ComponentModel.ISupportInitialize)(this.picIndic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtIndic;
        private System.Windows.Forms.Label lblSommeVersee;
        private System.Windows.Forms.Label lblAppr;
        private System.Windows.Forms.TextBox txtAppr;
        private System.Windows.Forms.PictureBox picIndic;
        private System.Windows.Forms.Label lblNomIndic;
    }
}
