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
            this.flpPlanete.Location = new System.Drawing.Point(13, 64);
            this.flpPlanete.Name = "flpPlanete";
            this.flpPlanete.Size = new System.Drawing.Size(793, 503);
            this.flpPlanete.TabIndex = 1;
            // 
            // menuBar1
            // 
            this.menuBar1.AutoSize = true;
            this.menuBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuBar1.Location = new System.Drawing.Point(551, 11);
            this.menuBar1.Margin = new System.Windows.Forms.Padding(2);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(264, 32);
            this.menuBar1.TabIndex = 2;
            // 
            // frmPlanete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(826, 579);
            this.Controls.Add(this.menuBar1);
            this.Controls.Add(this.flpPlanete);
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