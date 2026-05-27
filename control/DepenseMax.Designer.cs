namespace saeStargateTUAILLON_LONGO_YURTSEBEN.control
{
    partial class DepenseMax
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
            this.dgvDepense = new System.Windows.Forms.DataGridView();
            this.lblNomChef = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNomMission = new System.Windows.Forms.Label();
            this.pbChef = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChef)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDepense
            // 
            this.dgvDepense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepense.Location = new System.Drawing.Point(16, 118);
            this.dgvDepense.Name = "dgvDepense";
            this.dgvDepense.Size = new System.Drawing.Size(412, 73);
            this.dgvDepense.TabIndex = 1;
            // 
            // lblNomChef
            // 
            this.lblNomChef.AutoSize = true;
            this.lblNomChef.Location = new System.Drawing.Point(251, 20);
            this.lblNomChef.Name = "lblNomChef";
            this.lblNomChef.Size = new System.Drawing.Size(35, 13);
            this.lblNomChef.TabIndex = 2;
            this.lblNomChef.Text = "label1";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(251, 60);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(35, 13);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "label1";
            // 
            // lblNomMission
            // 
            this.lblNomMission.AutoSize = true;
            this.lblNomMission.Location = new System.Drawing.Point(23, 20);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(35, 13);
            this.lblNomMission.TabIndex = 4;
            this.lblNomMission.Text = "label1";
            // 
            // pbChef
            // 
            this.pbChef.Image = global::saeStargateTUAILLON_LONGO_YURTSEBEN.Properties.Resources.pengu;
            this.pbChef.Location = new System.Drawing.Point(354, 15);
            this.pbChef.Name = "pbChef";
            this.pbChef.Size = new System.Drawing.Size(86, 82);
            this.pbChef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChef.TabIndex = 0;
            this.pbChef.TabStop = false;
            // 
            // DepenseMax
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblNomMission);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNomChef);
            this.Controls.Add(this.dgvDepense);
            this.Controls.Add(this.pbChef);
            this.Name = "DepenseMax";
            this.Size = new System.Drawing.Size(451, 207);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbChef;
        private System.Windows.Forms.DataGridView dgvDepense;
        private System.Windows.Forms.Label lblNomChef;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNomMission;
    }
}
