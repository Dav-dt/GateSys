namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    partial class frmCreationMission
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCreationMission = new System.Windows.Forms.GroupBox();
            this.lblChoixPlanete = new System.Windows.Forms.Label();
            this.cmbPlanete = new System.Windows.Forms.ComboBox();
            this.btnValiderPlanete = new System.Windows.Forms.Button();
            this.lblNomMission = new System.Windows.Forms.Label();
            this.lblChefMission = new System.Windows.Forms.Label();
            this.cmbChefMission = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCreationMission.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCreationMission
            // 
            this.grpCreationMission.Controls.Add(this.label1);
            this.grpCreationMission.Controls.Add(this.cmbChefMission);
            this.grpCreationMission.Controls.Add(this.lblChefMission);
            this.grpCreationMission.Controls.Add(this.lblNomMission);
            this.grpCreationMission.Controls.Add(this.btnValiderPlanete);
            this.grpCreationMission.Controls.Add(this.cmbPlanete);
            this.grpCreationMission.Controls.Add(this.lblChoixPlanete);
            this.grpCreationMission.Location = new System.Drawing.Point(72, 12);
            this.grpCreationMission.Name = "grpCreationMission";
            this.grpCreationMission.Size = new System.Drawing.Size(675, 737);
            this.grpCreationMission.TabIndex = 0;
            this.grpCreationMission.TabStop = false;
            this.grpCreationMission.Text = "Nouvelle Mission";
            // 
            // lblChoixPlanete
            // 
            this.lblChoixPlanete.AutoSize = true;
            this.lblChoixPlanete.Location = new System.Drawing.Point(6, 57);
            this.lblChoixPlanete.Name = "lblChoixPlanete";
            this.lblChoixPlanete.Size = new System.Drawing.Size(226, 26);
            this.lblChoixPlanete.TabIndex = 0;
            this.lblChoixPlanete.Text = "1) Choix de la Planète";
            // 
            // cmbPlanete
            // 
            this.cmbPlanete.FormattingEnabled = true;
            this.cmbPlanete.Location = new System.Drawing.Point(340, 56);
            this.cmbPlanete.Name = "cmbPlanete";
            this.cmbPlanete.Size = new System.Drawing.Size(179, 34);
            this.cmbPlanete.TabIndex = 1;
            // 
            // btnValiderPlanete
            // 
            this.btnValiderPlanete.Location = new System.Drawing.Point(525, 57);
            this.btnValiderPlanete.Name = "btnValiderPlanete";
            this.btnValiderPlanete.Size = new System.Drawing.Size(144, 33);
            this.btnValiderPlanete.TabIndex = 2;
            this.btnValiderPlanete.Text = "Valider";
            this.btnValiderPlanete.UseVisualStyleBackColor = true;
            // 
            // lblNomMission
            // 
            this.lblNomMission.AutoSize = true;
            this.lblNomMission.Location = new System.Drawing.Point(180, 123);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(204, 26);
            this.lblNomMission.TabIndex = 3;
            this.lblNomMission.Text = "Nom de la Mission :";
            // 
            // lblChefMission
            // 
            this.lblChefMission.AutoSize = true;
            this.lblChefMission.Location = new System.Drawing.Point(6, 197);
            this.lblChefMission.Name = "lblChefMission";
            this.lblChefMission.Size = new System.Drawing.Size(303, 26);
            this.lblChefMission.TabIndex = 4;
            this.lblChefMission.Text = "2) Choix du chef de la Mission";
            // 
            // cmbChefMission
            // 
            this.cmbChefMission.FormattingEnabled = true;
            this.cmbChefMission.Location = new System.Drawing.Point(340, 197);
            this.cmbChefMission.Name = "cmbChefMission";
            this.cmbChefMission.Size = new System.Drawing.Size(179, 34);
            this.cmbChefMission.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "3) Détails de la Mission";
            // 
            // frmCreationMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 761);
            this.Controls.Add(this.grpCreationMission);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCreationMission";
            this.Text = "Création d\'une nouvelle mission";
            this.grpCreationMission.ResumeLayout(false);
            this.grpCreationMission.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCreationMission;
        private System.Windows.Forms.Button btnValiderPlanete;
        private System.Windows.Forms.ComboBox cmbPlanete;
        private System.Windows.Forms.Label lblChoixPlanete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChefMission;
        private System.Windows.Forms.Label lblChefMission;
        private System.Windows.Forms.Label lblNomMission;
    }
}