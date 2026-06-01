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
            this.menuBar1 = new saeStargateTUAILLON_LONGO_YURTSEBEN.control.menuBar();
            this.buttonBack1 = new saeStargateTUAILLON_LONGO_YURTSEBEN.control.ButtonBack();
            this.SuspendLayout();
            // 
            // pnlDepenses
            // 
            this.pnlDepenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDepenses.Location = new System.Drawing.Point(48, 82);
            this.pnlDepenses.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDepenses.Name = "pnlDepenses";
            this.pnlDepenses.Size = new System.Drawing.Size(686, 303);
            this.pnlDepenses.TabIndex = 0;
            // 
            // lblTotalSommeTitre
            // 
            this.lblTotalSommeTitre.AutoSize = true;
            this.lblTotalSommeTitre.Location = new System.Drawing.Point(19, 411);
            this.lblTotalSommeTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSommeTitre.Name = "lblTotalSommeTitre";
            this.lblTotalSommeTitre.Size = new System.Drawing.Size(106, 13);
            this.lblTotalSommeTitre.TabIndex = 1;
            this.lblTotalSommeTitre.Text = "Total des dépenses :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(221, 411);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "label1";
            // 
            // menuBar1
            // 
            this.menuBar1.AutoSize = true;
            this.menuBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuBar1.Location = new System.Drawing.Point(556, 11);
            this.menuBar1.Margin = new System.Windows.Forms.Padding(2);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(178, 32);
            this.menuBar1.TabIndex = 4;
            this.menuBar1.Load += new System.EventHandler(this.menuBar1_Load);
            // 
            // buttonBack1
            // 
            this.buttonBack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.buttonBack1.Location = new System.Drawing.Point(688, 398);
            this.buttonBack1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Size = new System.Drawing.Size(58, 67);
            this.buttonBack1.TabIndex = 3;
            // 
            // frmJournalDepenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 464);
            this.Controls.Add(this.menuBar1);
            this.Controls.Add(this.buttonBack1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalSommeTitre);
            this.Controls.Add(this.pnlDepenses);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private control.ButtonBack buttonBack1;
        private control.menuBar menuBar1;
    }
}