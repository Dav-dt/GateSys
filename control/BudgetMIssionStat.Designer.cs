namespace saeStargateTUAILLON_LONGO_YURTSEBEN.control
{
    partial class BudgetMIssionStat
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
            this.pbPlanete = new System.Windows.Forms.PictureBox();
            this.dgDepense = new System.Windows.Forms.DataGridView();
            this.lblMission = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepense)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlanete
            // 
            this.pbPlanete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbPlanete.Location = new System.Drawing.Point(23, 55);
            this.pbPlanete.Name = "pbPlanete";
            this.pbPlanete.Size = new System.Drawing.Size(102, 96);
            this.pbPlanete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlanete.TabIndex = 0;
            this.pbPlanete.TabStop = false;
            // 
            // dgDepense
            // 
            this.dgDepense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDepense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepense.Location = new System.Drawing.Point(23, 174);
            this.dgDepense.Name = "dgDepense";
            this.dgDepense.Size = new System.Drawing.Size(486, 245);
            this.dgDepense.TabIndex = 1;
            // 
            // lblMission
            // 
            this.lblMission.Location = new System.Drawing.Point(23, 16);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(102, 18);
            this.lblMission.TabIndex = 2;
            this.lblMission.Text = "label1";
            this.lblMission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BudgetMIssionStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblMission);
            this.Controls.Add(this.dgDepense);
            this.Controls.Add(this.pbPlanete);
            this.Name = "BudgetMIssionStat";
            this.Size = new System.Drawing.Size(540, 435);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlanete;
        private System.Windows.Forms.DataGridView dgDepense;
        private System.Windows.Forms.Label lblMission;
    }
}
