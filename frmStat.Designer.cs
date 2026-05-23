namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    partial class frmStat
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
            this.flpBudget = new System.Windows.Forms.FlowLayoutPanel();
            this.grpCollegue = new System.Windows.Forms.GroupBox();
            this.flpCollegue = new System.Windows.Forms.FlowLayoutPanel();
            this.btnValider = new System.Windows.Forms.Button();
            this.cboCollegue = new System.Windows.Forms.ComboBox();
            this.cboMission = new System.Windows.Forms.ComboBox();
            this.btnValiderInofrmateur = new System.Windows.Forms.Button();
            this.flpInformteur = new System.Windows.Forms.FlowLayoutPanel();
            this.gbInformateur = new System.Windows.Forms.GroupBox();
            this.grpCollegue.SuspendLayout();
            this.gbInformateur.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpBudget
            // 
            this.flpBudget.AutoScroll = true;
            this.flpBudget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBudget.Location = new System.Drawing.Point(858, 12);
            this.flpBudget.Name = "flpBudget";
            this.flpBudget.Size = new System.Drawing.Size(566, 478);
            this.flpBudget.TabIndex = 0;
            // 
            // grpCollegue
            // 
            this.grpCollegue.Controls.Add(this.flpCollegue);
            this.grpCollegue.Controls.Add(this.btnValider);
            this.grpCollegue.Controls.Add(this.cboCollegue);
            this.grpCollegue.Location = new System.Drawing.Point(6, 549);
            this.grpCollegue.Name = "grpCollegue";
            this.grpCollegue.Size = new System.Drawing.Size(646, 370);
            this.grpCollegue.TabIndex = 1;
            this.grpCollegue.TabStop = false;
            this.grpCollegue.Text = "Collègue(s)";
            // 
            // flpCollegue
            // 
            this.flpCollegue.AutoScroll = true;
            this.flpCollegue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpCollegue.Location = new System.Drawing.Point(19, 83);
            this.flpCollegue.Name = "flpCollegue";
            this.flpCollegue.Size = new System.Drawing.Size(606, 269);
            this.flpCollegue.TabIndex = 2;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(233, 20);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(148, 21);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // cboCollegue
            // 
            this.cboCollegue.FormattingEnabled = true;
            this.cboCollegue.Location = new System.Drawing.Point(10, 21);
            this.cboCollegue.Name = "cboCollegue";
            this.cboCollegue.Size = new System.Drawing.Size(140, 21);
            this.cboCollegue.TabIndex = 0;
            // 
            // cboMission
            // 
            this.cboMission.FormattingEnabled = true;
            this.cboMission.Location = new System.Drawing.Point(10, 21);
            this.cboMission.Name = "cboMission";
            this.cboMission.Size = new System.Drawing.Size(140, 21);
            this.cboMission.TabIndex = 0;
            // 
            // btnValiderInofrmateur
            // 
            this.btnValiderInofrmateur.Location = new System.Drawing.Point(233, 20);
            this.btnValiderInofrmateur.Name = "btnValiderInofrmateur";
            this.btnValiderInofrmateur.Size = new System.Drawing.Size(148, 21);
            this.btnValiderInofrmateur.TabIndex = 1;
            this.btnValiderInofrmateur.Text = "Valider";
            this.btnValiderInofrmateur.UseVisualStyleBackColor = true;
            this.btnValiderInofrmateur.Click += new System.EventHandler(this.btnValiderInofrmateur_Click);
            // 
            // flpInformteur
            // 
            this.flpInformteur.AutoScroll = true;
            this.flpInformteur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpInformteur.Location = new System.Drawing.Point(19, 83);
            this.flpInformteur.Name = "flpInformteur";
            this.flpInformteur.Size = new System.Drawing.Size(606, 269);
            this.flpInformteur.TabIndex = 2;
            // 
            // gbInformateur
            // 
            this.gbInformateur.Controls.Add(this.flpInformteur);
            this.gbInformateur.Controls.Add(this.btnValiderInofrmateur);
            this.gbInformateur.Controls.Add(this.cboMission);
            this.gbInformateur.Location = new System.Drawing.Point(737, 549);
            this.gbInformateur.Name = "gbInformateur";
            this.gbInformateur.Size = new System.Drawing.Size(646, 370);
            this.gbInformateur.TabIndex = 3;
            this.gbInformateur.TabStop = false;
            this.gbInformateur.Text = "Informateur(s) moins payé(s)";
            // 
            // frmStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1547, 952);
            this.Controls.Add(this.gbInformateur);
            this.Controls.Add(this.grpCollegue);
            this.Controls.Add(this.flpBudget);
            this.Name = "frmStat";
            this.Text = "frmStat";
            this.Load += new System.EventHandler(this.frmStat_Load);
            this.grpCollegue.ResumeLayout(false);
            this.gbInformateur.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBudget;
        private System.Windows.Forms.GroupBox grpCollegue;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cboCollegue;
        private System.Windows.Forms.FlowLayoutPanel flpCollegue;
        private System.Windows.Forms.ComboBox cboMission;
        private System.Windows.Forms.Button btnValiderInofrmateur;
        private System.Windows.Forms.FlowLayoutPanel flpInformteur;
        private System.Windows.Forms.GroupBox gbInformateur;
    }
}