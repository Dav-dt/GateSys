namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    partial class frmJournalIndics
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
            this.pnlIndics = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.llblTotalSomme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlIndics
            // 
            this.pnlIndics.AutoScroll = true;
            this.pnlIndics.Location = new System.Drawing.Point(133, 36);
            this.pnlIndics.Name = "pnlIndics";
            this.pnlIndics.Size = new System.Drawing.Size(744, 464);
            this.pnlIndics.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total des sommes versées :";
            // 
            // llblTotalSomme
            // 
            this.llblTotalSomme.AutoSize = true;
            this.llblTotalSomme.Location = new System.Drawing.Point(294, 544);
            this.llblTotalSomme.Name = "llblTotalSomme";
            this.llblTotalSomme.Size = new System.Drawing.Size(51, 20);
            this.llblTotalSomme.TabIndex = 2;
            this.llblTotalSomme.Text = "label2";
            // 
            // frmJournalIndics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 595);
            this.Controls.Add(this.llblTotalSomme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlIndics);
            this.Name = "frmJournalIndics";
            this.Text = "frmJournalIndics";
            this.Load += new System.EventHandler(this.frmJournalIndics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlIndics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label llblTotalSomme;
    }
}