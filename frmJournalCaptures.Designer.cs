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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCapture
            // 
            this.dgvCapture.AllowUserToAddRows = false;
            this.dgvCapture.AllowUserToDeleteRows = false;
            this.dgvCapture.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCapture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapture.Location = new System.Drawing.Point(42, 31);
            this.dgvCapture.Name = "dgvCapture";
            this.dgvCapture.ReadOnly = true;
            this.dgvCapture.RowHeadersWidth = 62;
            this.dgvCapture.RowTemplate.Height = 28;
            this.dgvCapture.Size = new System.Drawing.Size(715, 390);
            this.dgvCapture.TabIndex = 0;
            // 
            // frmJournalCaptures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCapture);
            this.Name = "frmJournalCaptures";
            this.Text = "frmJournalCaptures";
            this.Load += new System.EventHandler(this.frmJournalCaptures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCapture;
    }
}