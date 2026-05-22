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
            this.SuspendLayout();
            // 
            // flpBudget
            // 
            this.flpBudget.AutoScroll = true;
            this.flpBudget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBudget.Location = new System.Drawing.Point(957, 10);
            this.flpBudget.Name = "flpBudget";
            this.flpBudget.Size = new System.Drawing.Size(566, 515);
            this.flpBudget.TabIndex = 0;
            // 
            // frmStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 729);
            this.Controls.Add(this.flpBudget);
            this.Name = "frmStat";
            this.Text = "frmStat";
            this.Load += new System.EventHandler(this.frmStat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBudget;
    }
}