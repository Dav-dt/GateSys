namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    partial class frmInfoPlanete
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
            this.labelEspece = new System.Windows.Forms.Label();
            this.lbMission = new System.Windows.Forms.ListBox();
            this.labelMission = new System.Windows.Forms.Label();
            this.buttonBack1 = new saeStargateTUAILLON_LONGO_YURTSEBEN.control.ButtonBack();
            this.SuspendLayout();
            // 
            // labelEspece
            // 
            this.labelEspece.AutoSize = true;
            this.labelEspece.Location = new System.Drawing.Point(9, 196);
            this.labelEspece.Name = "labelEspece";
            this.labelEspece.Size = new System.Drawing.Size(84, 13);
            this.labelEspece.TabIndex = 0;
            this.labelEspece.Text = "Espece vivante:";
            // 
            // lbMission
            // 
            this.lbMission.FormattingEnabled = true;
            this.lbMission.Items.AddRange(new object[] {
            ""});
            this.lbMission.Location = new System.Drawing.Point(427, 221);
            this.lbMission.Name = "lbMission";
            this.lbMission.Size = new System.Drawing.Size(244, 95);
            this.lbMission.TabIndex = 3;
            // 
            // labelMission
            // 
            this.labelMission.AutoSize = true;
            this.labelMission.Location = new System.Drawing.Point(424, 196);
            this.labelMission.Name = "labelMission";
            this.labelMission.Size = new System.Drawing.Size(45, 13);
            this.labelMission.TabIndex = 2;
            this.labelMission.Text = "Mission:";
            // 
            // buttonBack1
            // 
            this.buttonBack1.Location = new System.Drawing.Point(612, 391);
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Size = new System.Drawing.Size(59, 60);
            this.buttonBack1.TabIndex = 4;
            // 
            // frmInfoPlanete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 463);
            this.Controls.Add(this.buttonBack1);
            this.Controls.Add(this.lbMission);
            this.Controls.Add(this.labelMission);
            this.Controls.Add(this.labelEspece);
            this.Name = "frmInfoPlanete";
            this.Text = "InfoPlanete";
            this.Load += new System.EventHandler(this.frmInfoPlanete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEspece;
        private System.Windows.Forms.ListBox lbMission;
        private System.Windows.Forms.Label labelMission;
        private control.ButtonBack buttonBack1;
    }
}