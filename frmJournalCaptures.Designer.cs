namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    partial class frmJournalCaptures
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
            this.dgvCapture = new System.Windows.Forms.DataGridView();
            this.menuBar1 = new saeStargateTUAILLON_LONGO_YURTSEBEN.control.menuBar();
            this.buttonBack1 = new saeStargateTUAILLON_LONGO_YURTSEBEN.control.ButtonBack();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCapture
            // 
            this.dgvCapture.AllowUserToAddRows = false;
            this.dgvCapture.AllowUserToDeleteRows = false;
            this.dgvCapture.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCapture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapture.Location = new System.Drawing.Point(37, 77);
            this.dgvCapture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCapture.Name = "dgvCapture";
            this.dgvCapture.ReadOnly = true;
            this.dgvCapture.RowHeadersWidth = 62;
            this.dgvCapture.RowTemplate.Height = 28;
            this.dgvCapture.Size = new System.Drawing.Size(477, 253);
            this.dgvCapture.TabIndex = 0;
            // 
            // menuBar1
            // 
            this.menuBar1.AutoSize = true;
            this.menuBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuBar1.Location = new System.Drawing.Point(320, 5);
            this.menuBar1.Margin = new System.Windows.Forms.Padding(2);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(233, 32);
            this.menuBar1.TabIndex = 2;
            // 
            // buttonBack1
            // 
            this.buttonBack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.buttonBack1.Location = new System.Drawing.Point(493, 344);
            this.buttonBack1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Size = new System.Drawing.Size(61, 65);
            this.buttonBack1.TabIndex = 1;
            this.buttonBack1.Load += new System.EventHandler(this.buttonBack1_Load);
            // 
            // frmJournalCaptures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 420);
            this.Controls.Add(this.menuBar1);
            this.Controls.Add(this.buttonBack1);
            this.Controls.Add(this.dgvCapture);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmJournalCaptures";
            this.Text = "frmJournalCaptures";
            this.Load += new System.EventHandler(this.frmJournalCaptures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCapture;
        private control.ButtonBack buttonBack1;
        private control.menuBar menuBar1;
    }
}