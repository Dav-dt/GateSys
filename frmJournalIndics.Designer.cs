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
            this.buttonBack1 = new saeStargateTUAILLON_LONGO_YURTSEBEN.control.ButtonBack();
            this.menuBar1 = new saeStargateTUAILLON_LONGO_YURTSEBEN.control.menuBar();
            this.SuspendLayout();
            // 
            // pnlIndics
            // 
            this.pnlIndics.AutoScroll = true;
            this.pnlIndics.Location = new System.Drawing.Point(24, 126);
            this.pnlIndics.Name = "pnlIndics";
            this.pnlIndics.Size = new System.Drawing.Size(1071, 449);
            this.pnlIndics.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 631);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total des sommes versées :";
            // 
            // llblTotalSomme
            // 
            this.llblTotalSomme.AutoSize = true;
            this.llblTotalSomme.Location = new System.Drawing.Point(363, 631);
            this.llblTotalSomme.Name = "llblTotalSomme";
            this.llblTotalSomme.Size = new System.Drawing.Size(51, 20);
            this.llblTotalSomme.TabIndex = 2;
            this.llblTotalSomme.Text = "label2";
            // 
            // buttonBack1
            // 
            this.buttonBack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.buttonBack1.Location = new System.Drawing.Point(982, 586);
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Size = new System.Drawing.Size(112, 92);
            this.buttonBack1.TabIndex = 3;
            // 
            // menuBar1
            // 
            this.menuBar1.AutoSize = true;
            this.menuBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuBar1.Location = new System.Drawing.Point(1, -2);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(1140, 48);
            this.menuBar1.TabIndex = 4;
            // 
            // frmJournalIndics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 695);
            this.Controls.Add(this.menuBar1);
            this.Controls.Add(this.buttonBack1);
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
        private control.ButtonBack buttonBack1;
        private control.menuBar menuBar1;
    }
}