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
            this.menuBar1 = new saeStargateTUAILLON_LONGO_YURTSEBEN.control.menuBar();
            this.SuspendLayout();
            // 
            // labelEspece
            // 
            this.labelEspece.AutoSize = true;
            this.labelEspece.Location = new System.Drawing.Point(18, 340);
            this.labelEspece.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEspece.Name = "labelEspece";
            this.labelEspece.Size = new System.Drawing.Size(120, 20);
            this.labelEspece.TabIndex = 0;
            this.labelEspece.Text = "Espece vivante:";
            // 
            // lbMission
            // 
            this.lbMission.FormattingEnabled = true;
            this.lbMission.ItemHeight = 20;
            this.lbMission.Items.AddRange(new object[] {
            ""});
            this.lbMission.Location = new System.Drawing.Point(496, 386);
            this.lbMission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbMission.Name = "lbMission";
            this.lbMission.Size = new System.Drawing.Size(508, 204);
            this.lbMission.TabIndex = 3;
            // 
            // labelMission
            // 
            this.labelMission.AutoSize = true;
            this.labelMission.Location = new System.Drawing.Point(492, 340);
            this.labelMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMission.Name = "labelMission";
            this.labelMission.Size = new System.Drawing.Size(66, 20);
            this.labelMission.TabIndex = 2;
            this.labelMission.Text = "Mission:";
            // 
            // buttonBack1
            // 
            this.buttonBack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.buttonBack1.Location = new System.Drawing.Point(918, 602);
            this.buttonBack1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Size = new System.Drawing.Size(88, 92);
            this.buttonBack1.TabIndex = 4;
            // 
            // menuBar1
            // 
            this.menuBar1.AutoSize = true;
            this.menuBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuBar1.Location = new System.Drawing.Point(-1, -1);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(1053, 48);
            this.menuBar1.TabIndex = 5;
            // 
            // frmInfoPlanete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 712);
            this.Controls.Add(this.menuBar1);
            this.Controls.Add(this.buttonBack1);
            this.Controls.Add(this.lbMission);
            this.Controls.Add(this.labelMission);
            this.Controls.Add(this.labelEspece);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private control.menuBar menuBar1;
    }
}