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
            this.lblDateDepart = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblbudget = new System.Windows.Forms.Label();
            this.lblBudgetText = new System.Windows.Forms.Label();
            this.picDep = new System.Windows.Forms.PictureBox();
            this.btnGenererPdf = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.pbPlanete = new System.Windows.Forms.PictureBox();
            this.picRet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomMission
            // 
            this.lblNomMission.AutoSize = true;
            this.lblNomMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomMission.Location = new System.Drawing.Point(250, 26);
            this.lblNomMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(99, 33);
            this.lblNomMission.TabIndex = 0;
            this.lblNomMission.Text = "label1";
            // 
            // lblNomCapitaine
            // 
            this.lblNomCapitaine.AutoSize = true;
            this.lblNomCapitaine.Location = new System.Drawing.Point(250, 169);
            this.lblNomCapitaine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomCapitaine.Name = "lblNomCapitaine";
            this.lblNomCapitaine.Size = new System.Drawing.Size(51, 20);
            this.lblNomCapitaine.TabIndex = 1;
            this.lblNomCapitaine.Text = "label1";
            // 
            // lblDateDepart
            // 
            this.lblDateDepart.AutoSize = true;
            this.lblDateDepart.Location = new System.Drawing.Point(250, 97);
            this.lblDateDepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateDepart.Name = "lblDateDepart";
            this.lblDateDepart.Size = new System.Drawing.Size(51, 20);
            this.lblDateDepart.TabIndex = 4;
            this.lblDateDepart.Text = "label1";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(396, 97);
            this.lblDateFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(51, 20);
            this.lblDateFin.TabIndex = 5;
            this.lblDateFin.Text = "label1";
            // 
            // lblbudget
            // 
            this.lblbudget.AutoSize = true;
            this.lblbudget.Location = new System.Drawing.Point(396, 169);
            this.lblbudget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbudget.Name = "lblbudget";
            this.lblbudget.Size = new System.Drawing.Size(69, 20);
            this.lblbudget.TabIndex = 2;
            this.lblbudget.Text = "Budget: ";
            // 
            // lblBudgetText
            // 
            this.lblBudgetText.AutoSize = true;
            this.lblBudgetText.Location = new System.Drawing.Point(473, 175);
            this.lblBudgetText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBudgetText.Name = "lblBudgetText";
            this.lblBudgetText.Size = new System.Drawing.Size(0, 20);
            this.lblBudgetText.TabIndex = 3;
            // 
            // picDep
            // 
            this.picDep.Image = global::saeStargateTUAILLON_LONGO_YURTSEBEN.Properties.Resources.fuseeBetter;
            this.picDep.Location = new System.Drawing.Point(227, 97);
            this.picDep.Name = "picDep";
            this.picDep.Size = new System.Drawing.Size(25, 28);
            this.picDep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDep.TabIndex = 9;
            this.picDep.TabStop = false;
            // 
            // btnGenererPdf
            // 
            this.btnGenererPdf.BackgroundImage = global::saeStargateTUAILLON_LONGO_YURTSEBEN.Properties.Resources.pdfAdobe;
            this.btnGenererPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenererPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenererPdf.Location = new System.Drawing.Point(498, 69);
            this.btnGenererPdf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenererPdf.Name = "btnGenererPdf";
            this.btnGenererPdf.Size = new System.Drawing.Size(84, 77);
            this.btnGenererPdf.TabIndex = 8;
            this.btnGenererPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenererPdf.UseVisualStyleBackColor = true;
            this.btnGenererPdf.Click += new System.EventHandler(this.btnGenererPdf_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = global::saeStargateTUAILLON_LONGO_YURTSEBEN.Properties.Resources.detailLogo;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Location = new System.Drawing.Point(616, 69);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(84, 77);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // pbPlanete
            // 
            this.pbPlanete.Location = new System.Drawing.Point(24, 17);
            this.pbPlanete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPlanete.Name = "pbPlanete";
            this.pbPlanete.Size = new System.Drawing.Size(195, 172);
            this.pbPlanete.TabIndex = 6;
            this.pbPlanete.TabStop = false;
            // 
            // picRet
            // 
            this.picRet.Image = global::saeStargateTUAILLON_LONGO_YURTSEBEN.Properties.Resources.drapeau;
            this.picRet.Location = new System.Drawing.Point(374, 97);
            this.picRet.Name = "picRet";
            this.picRet.Size = new System.Drawing.Size(25, 28);
            this.picRet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRet.TabIndex = 10;
            this.picRet.TabStop = false;
            // 
            // Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.picRet);
            this.Controls.Add(this.picDep);
            this.Controls.Add(this.btnGenererPdf);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.pbPlanete);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDepart);
            this.Controls.Add(this.lblBudgetText);
            this.Controls.Add(this.lblbudget);
            this.Controls.Add(this.lblNomCapitaine);
            this.Controls.Add(this.lblNomMission);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Mission";
            this.Size = new System.Drawing.Size(724, 206);
            this.Load += new System.EventHandler(this.Mission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomMission;
        private System.Windows.Forms.Label lblNomCapitaine;
        private System.Windows.Forms.Label lblDateDepart;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.PictureBox pbPlanete;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnGenererPdf;
        private System.Windows.Forms.Label lblbudget;
        private System.Windows.Forms.Label lblBudgetText;
        private System.Windows.Forms.PictureBox picDep;
        private System.Windows.Forms.PictureBox picRet;
    }
}
