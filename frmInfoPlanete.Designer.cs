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
            this.labelEspece.Location = new System.Drawing.Point(22, 283);
            this.labelEspece.Name = "labelEspece";
            this.labelEspece.Size = new System.Drawing.Size(106, 13);
            this.labelEspece.TabIndex = 0;
            this.labelEspece.Text = "Espece(s) vivante(s):";
            this.labelEspece.Click += new System.EventHandler(this.labelEspece_Click);
            // 
            // lbMission
            // 
            this.lbMission.FormattingEnabled = true;
            this.lbMission.Items.AddRange(new object[] {
            ""});
            this.lbMission.Location = new System.Drawing.Point(349, 313);
            this.lbMission.Name = "lbMission";
            this.lbMission.Size = new System.Drawing.Size(340, 134);
            this.lbMission.TabIndex = 3;
            // 
            // labelMission
            // 
            this.labelMission.AutoSize = true;
            this.labelMission.Location = new System.Drawing.Point(346, 283);
            this.labelMission.Name = "labelMission";
            this.labelMission.Size = new System.Drawing.Size(56, 13);
            this.labelMission.TabIndex = 2;
            this.labelMission.Text = "Mission(s):";
            // 
            // buttonBack1
            // 
            this.buttonBack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.buttonBack1.Location = new System.Drawing.Point(630, 453);
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Size = new System.Drawing.Size(59, 60);
            this.buttonBack1.TabIndex = 4;
            // 
            // menuBar1
            // 
            this.menuBar1.AutoSize = true;
            this.menuBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.Margin = new System.Windows.Forms.Padding(1);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(701, 32);
            this.menuBar1.TabIndex = 5;
            // 
            // frmInfoPlanete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 524);
            this.Controls.Add(this.menuBar1);
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
        private control.menuBar menuBar1;
    }
}