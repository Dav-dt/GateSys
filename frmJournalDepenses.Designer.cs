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
            this.lblTotalSommeTitre = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlDepenses
            // 
            this.pnlDepenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDepenses.Location = new System.Drawing.Point(104, 34);
            this.pnlDepenses.Name = "pnlDepenses";
            this.pnlDepenses.Size = new System.Drawing.Size(791, 465);
            this.pnlDepenses.TabIndex = 0;
            // 
            // lblTotalSommeTitre
            // 
            this.lblTotalSommeTitre.AutoSize = true;
            this.lblTotalSommeTitre.Location = new System.Drawing.Point(12, 540);
            this.lblTotalSommeTitre.Name = "lblTotalSommeTitre";
            this.lblTotalSommeTitre.Size = new System.Drawing.Size(156, 20);
            this.lblTotalSommeTitre.TabIndex = 1;
            this.lblTotalSommeTitre.Text = "Total des dépenses :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(228, 540);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 20);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "label1";
            // 
            // frmJournalDepenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 594);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalSommeTitre);
            this.Controls.Add(this.pnlDepenses);
            this.Name = "frmJournalDepenses";
            this.Text = "frmJournalDepenses";
            this.Load += new System.EventHandler(this.frmJournalDepenses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDepenses;
        private System.Windows.Forms.Label lblTotalSommeTitre;
        private System.Windows.Forms.Label lblTotal;
    }
}