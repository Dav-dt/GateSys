namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    partial class frmJournalDepenses
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
            this.pnlDepenses = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlDepenses
            // 
            this.pnlDepenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDepenses.Location = new System.Drawing.Point(104, 34);
            this.pnlDepenses.Name = "pnlDepenses";
            this.pnlDepenses.Size = new System.Drawing.Size(791, 465);
            this.pnlDepenses.TabIndex = 0;
            this.pnlDepenses.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDepenses_Paint);
            // 
            // frmJournalDepenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 663);
            this.Controls.Add(this.pnlDepenses);
            this.Name = "frmJournalDepenses";
            this.Text = "frmJournalDepenses";
            this.Load += new System.EventHandler(this.frmJournalDepenses_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDepenses;
    }
}