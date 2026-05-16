namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    partial class frmRace
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
            this.flpRace = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpRace
            // 
            this.flpRace.AutoScroll = true;
            this.flpRace.Location = new System.Drawing.Point(23, 18);
            this.flpRace.Name = "flpRace";
            this.flpRace.Size = new System.Drawing.Size(784, 425);
            this.flpRace.TabIndex = 0;
            // 
            // frmRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 581);
            this.Controls.Add(this.flpRace);
            this.Name = "frmRace";
            this.Text = "frmRace";
            this.Load += new System.EventHandler(this.frmRace_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpRace;
    }
}