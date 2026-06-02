namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    partial class frmPlanete
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
            this.flpPlanete = new System.Windows.Forms.FlowLayoutPanel();
            this.menuBar1 = new saeStargateTUAILLON_LONGO_YURTSEBEN.control.menuBar();
            this.SuspendLayout();
            // 
            // flpPlanete
            // 
            this.flpPlanete.AutoScroll = true;
            this.flpPlanete.Location = new System.Drawing.Point(20, 98);
            this.flpPlanete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpPlanete.Name = "flpPlanete";
            this.flpPlanete.Size = new System.Drawing.Size(1190, 774);
            this.flpPlanete.TabIndex = 1;
            // 
            // menuBar1
            // 
            this.menuBar1.AutoSize = true;
            this.menuBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuBar1.Location = new System.Drawing.Point(1075, 0);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(163, 48);
            this.menuBar1.TabIndex = 2;
            // 
            // frmPlanete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1239, 891);
            this.Controls.Add(this.menuBar1);
            this.Controls.Add(this.flpPlanete);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPlanete";
            this.Text = "frmPlanete";
            this.Load += new System.EventHandler(this.frmPlanete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpPlanete;
        private control.menuBar menuBar1;
    }
}