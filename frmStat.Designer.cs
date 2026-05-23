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
            this.cboCollegue = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.flpCollegue = new System.Windows.Forms.FlowLayoutPanel();
            this.grpCollegue.SuspendLayout();
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
            // cboCollegue
            // 
            this.cboCollegue.FormattingEnabled = true;
            this.cboCollegue.Location = new System.Drawing.Point(10, 21);
            this.cboCollegue.Name = "cboCollegue";
            this.cboCollegue.Size = new System.Drawing.Size(140, 21);
            this.cboCollegue.TabIndex = 0;
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
            // flpCollegue
            // 
            this.flpCollegue.AutoScroll = true;
            this.flpCollegue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpCollegue.Location = new System.Drawing.Point(19, 83);
            this.flpCollegue.Name = "flpCollegue";
            this.flpCollegue.Size = new System.Drawing.Size(606, 269);
            this.flpCollegue.TabIndex = 2;
            // 
            // frmStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1547, 952);
            this.Controls.Add(this.grpCollegue);
            this.Controls.Add(this.flpBudget);
            this.Name = "frmStat";
            this.Text = "frmStat";
            this.Load += new System.EventHandler(this.frmStat_Load);
            this.grpCollegue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBudget;
        private System.Windows.Forms.GroupBox grpCollegue;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cboCollegue;
        private System.Windows.Forms.FlowLayoutPanel flpCollegue;
    }
}