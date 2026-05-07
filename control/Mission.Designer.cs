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
            this.btnInfo = new System.Windows.Forms.Button();
            this.pbPlanete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanete)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomMission
            // 
            this.lblNomMission.AutoSize = true;
            this.lblNomMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomMission.Location = new System.Drawing.Point(167, 17);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(66, 24);
            this.lblNomMission.TabIndex = 0;
            this.lblNomMission.Text = "label1";
            // 
            // lblNomCapitaine
            // 
            this.lblNomCapitaine.AutoSize = true;
            this.lblNomCapitaine.Location = new System.Drawing.Point(167, 110);
            this.lblNomCapitaine.Name = "lblNomCapitaine";
            this.lblNomCapitaine.Size = new System.Drawing.Size(35, 13);
            this.lblNomCapitaine.TabIndex = 1;
            this.lblNomCapitaine.Text = "label1";
            // 
            // lblbudget
            // 
            this.lblbudget.AutoSize = true;
            this.lblbudget.Location = new System.Drawing.Point(442, 110);
            this.lblbudget.Name = "lblbudget";
            this.lblbudget.Size = new System.Drawing.Size(47, 13);
            this.lblbudget.TabIndex = 2;
            this.lblbudget.Text = "Budget: ";
            // 
            // lblBudgetText
            // 
            this.lblBudgetText.AutoSize = true;
            this.lblBudgetText.Location = new System.Drawing.Point(495, 110);
            this.lblBudgetText.Name = "lblBudgetText";
            this.lblBudgetText.Size = new System.Drawing.Size(0, 13);
            this.lblBudgetText.TabIndex = 3;
            // 
            // lblDateDepart
            // 
            this.lblDateDepart.AutoSize = true;
            this.lblDateDepart.Location = new System.Drawing.Point(167, 63);
            this.lblDateDepart.Name = "lblDateDepart";
            this.lblDateDepart.Size = new System.Drawing.Size(35, 13);
            this.lblDateDepart.TabIndex = 4;
            this.lblDateDepart.Text = "label1";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(442, 63);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(35, 13);
            this.lblDateFin.TabIndex = 5;
            this.lblDateFin.Text = "label1";
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = global::saeStargateTUAILLON_LONGO_YURTSEBEN.Properties.Resources.loupe;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.Location = new System.Drawing.Point(526, 54);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(64, 64);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // pbPlanete
            // 
            this.pbPlanete.Location = new System.Drawing.Point(3, 13);
            this.pbPlanete.Name = "pbPlanete";
            this.pbPlanete.Size = new System.Drawing.Size(145, 128);
            this.pbPlanete.TabIndex = 6;
            this.pbPlanete.TabStop = false;
            // 
            // Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.pbPlanete);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDepart);
            this.Controls.Add(this.lblBudgetText);
            this.Controls.Add(this.lblbudget);
            this.Controls.Add(this.lblNomCapitaine);
            this.Controls.Add(this.lblNomMission);
            this.Name = "Mission";
            this.Size = new System.Drawing.Size(676, 188);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanete)).EndInit();
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
        private System.Windows.Forms.PictureBox pbPlanete;
        private System.Windows.Forms.Button btnInfo;
    }
}
