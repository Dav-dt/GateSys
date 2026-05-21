namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    partial class frmChargement
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
            this.pb = new System.Windows.Forms.ProgressBar();
            this.lblDetails = new System.Windows.Forms.Label();
            this.picCharg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCharg)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(29, 33);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(508, 104);
            this.pb.TabIndex = 0;
            this.pb.Value = 65;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(36, 203);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(258, 20);
            this.lblDetails.TabIndex = 1;
            this.lblDetails.Text = "Chargement des données en cours";
            // 
            // picCharg
            // 
            this.picCharg.Location = new System.Drawing.Point(395, 162);
            this.picCharg.Name = "picCharg";
            this.picCharg.Size = new System.Drawing.Size(142, 108);
            this.picCharg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCharg.TabIndex = 2;
            this.picCharg.TabStop = false;
            // 
            // frmChargement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 282);
            this.Controls.Add(this.picCharg);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.pb);
            this.Name = "frmChargement";
            this.Text = "Chargement des données";
            ((System.ComponentModel.ISupportInitialize)(this.picCharg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.PictureBox picCharg;
    }
}