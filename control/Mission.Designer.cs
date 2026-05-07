namespace saeStargateTUAILLON_LONGO_YURTSEBEN.control
{
    partial class Mission
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
            this.lblNomMission = new System.Windows.Forms.Label();
            this.lblNomCapitaine = new System.Windows.Forms.Label();
            this.lblbudget = new System.Windows.Forms.Label();
            this.lblBudgetText = new System.Windows.Forms.Label();
            this.lblDateDepart = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomMission
            // 
            this.lblNomMission.AutoSize = true;
            this.lblNomMission.Location = new System.Drawing.Point(142, 13);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(35, 13);
            this.lblNomMission.TabIndex = 0;
            this.lblNomMission.Text = "label1";
            // 
            // lblNomCapitaine
            // 
            this.lblNomCapitaine.AutoSize = true;
            this.lblNomCapitaine.Location = new System.Drawing.Point(142, 106);
            this.lblNomCapitaine.Name = "lblNomCapitaine";
            this.lblNomCapitaine.Size = new System.Drawing.Size(35, 13);
            this.lblNomCapitaine.TabIndex = 1;
            this.lblNomCapitaine.Text = "label1";
            // 
            // lblbudget
            // 
            this.lblbudget.AutoSize = true;
            this.lblbudget.Location = new System.Drawing.Point(417, 106);
            this.lblbudget.Name = "lblbudget";
            this.lblbudget.Size = new System.Drawing.Size(47, 13);
            this.lblbudget.TabIndex = 2;
            this.lblbudget.Text = "Budget: ";
            // 
            // lblBudgetText
            // 
            this.lblBudgetText.AutoSize = true;
            this.lblBudgetText.Location = new System.Drawing.Point(470, 106);
            this.lblBudgetText.Name = "lblBudgetText";
            this.lblBudgetText.Size = new System.Drawing.Size(0, 13);
            this.lblBudgetText.TabIndex = 3;
            // 
            // lblDateDepart
            // 
            this.lblDateDepart.AutoSize = true;
            this.lblDateDepart.Location = new System.Drawing.Point(142, 59);
            this.lblDateDepart.Name = "lblDateDepart";
            this.lblDateDepart.Size = new System.Drawing.Size(35, 13);
            this.lblDateDepart.TabIndex = 4;
            this.lblDateDepart.Text = "label1";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(417, 59);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(35, 13);
            this.lblDateFin.TabIndex = 5;
            this.lblDateFin.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 110);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnInfo
            // 
            this.btnInfo.Image = global::saeStargateTUAILLON_LONGO_YURTSEBEN.Properties.Resources.loupe;
            this.btnInfo.Location = new System.Drawing.Point(526, 54);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(77, 64);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "btnInfo";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDepart);
            this.Controls.Add(this.lblBudgetText);
            this.Controls.Add(this.lblbudget);
            this.Controls.Add(this.lblNomCapitaine);
            this.Controls.Add(this.lblNomMission);
            this.Name = "Mission";
            this.Size = new System.Drawing.Size(626, 161);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomMission;
        private System.Windows.Forms.Label lblNomCapitaine;
        private System.Windows.Forms.Label lblbudget;
        private System.Windows.Forms.Label lblBudgetText;
        private System.Windows.Forms.Label lblDateDepart;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInfo;
    }
}
