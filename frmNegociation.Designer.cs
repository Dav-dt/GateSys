namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    partial class frmNegociation
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
            this.pnlNegoc = new System.Windows.Forms.Panel();
            this.grpNegoc = new System.Windows.Forms.GroupBox();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.cmbAllie = new System.Windows.Forms.ComboBox();
            this.txtQtDatabaz = new System.Windows.Forms.TextBox();
            this.btnValiderDemande = new System.Windows.Forms.Button();
            this.picExtra = new System.Windows.Forms.PictureBox();
            this.lblDatabaz = new System.Windows.Forms.Label();
            this.picDatabaz = new System.Windows.Forms.PictureBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.menuBar1 = new saeStargateTUAILLON_LONGO_YURTSEBEN.control.menuBar();
            this.grpNegoc.SuspendLayout();
            this.grpContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDatabaz)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNegoc
            // 
            this.pnlNegoc.AutoScroll = true;
            this.pnlNegoc.Location = new System.Drawing.Point(15, 26);
            this.pnlNegoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlNegoc.Name = "pnlNegoc";
            this.pnlNegoc.Size = new System.Drawing.Size(619, 435);
            this.pnlNegoc.TabIndex = 0;
            // 
            // grpNegoc
            // 
            this.grpNegoc.Controls.Add(this.pnlNegoc);
            this.grpNegoc.Location = new System.Drawing.Point(310, 58);
            this.grpNegoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpNegoc.Name = "grpNegoc";
            this.grpNegoc.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpNegoc.Size = new System.Drawing.Size(651, 468);
            this.grpNegoc.TabIndex = 1;
            this.grpNegoc.TabStop = false;
            this.grpNegoc.Text = "Négociations passées pour cette Mission";
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.cmbAllie);
            this.grpContact.Controls.Add(this.txtQtDatabaz);
            this.grpContact.Controls.Add(this.btnValiderDemande);
            this.grpContact.Controls.Add(this.picExtra);
            this.grpContact.Controls.Add(this.lblDatabaz);
            this.grpContact.Controls.Add(this.picDatabaz);
            this.grpContact.Controls.Add(this.lblExtra);
            this.grpContact.Location = new System.Drawing.Point(10, 74);
            this.grpContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpContact.Name = "grpContact";
            this.grpContact.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpContact.Size = new System.Drawing.Size(296, 445);
            this.grpContact.TabIndex = 2;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contacter un extraterrestre";
            // 
            // cmbAllie
            // 
            this.cmbAllie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAllie.FormattingEnabled = true;
            this.cmbAllie.Location = new System.Drawing.Point(10, 71);
            this.cmbAllie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbAllie.Name = "cmbAllie";
            this.cmbAllie.Size = new System.Drawing.Size(143, 21);
            this.cmbAllie.TabIndex = 6;
            this.cmbAllie.SelectedIndexChanged += new System.EventHandler(this.cmbAllie_SelectedIndexChanged);
            // 
            // txtQtDatabaz
            // 
            this.txtQtDatabaz.Location = new System.Drawing.Point(24, 274);
            this.txtQtDatabaz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQtDatabaz.Name = "txtQtDatabaz";
            this.txtQtDatabaz.Size = new System.Drawing.Size(87, 20);
            this.txtQtDatabaz.TabIndex = 5;
            // 
            // btnValiderDemande
            // 
            this.btnValiderDemande.Location = new System.Drawing.Point(101, 380);
            this.btnValiderDemande.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValiderDemande.Name = "btnValiderDemande";
            this.btnValiderDemande.Size = new System.Drawing.Size(182, 48);
            this.btnValiderDemande.TabIndex = 4;
            this.btnValiderDemande.Text = "Soumettre la demande";
            this.btnValiderDemande.UseVisualStyleBackColor = true;
            this.btnValiderDemande.Click += new System.EventHandler(this.btnValiderDemande_Click);
            // 
            // picExtra
            // 
            this.picExtra.Image = global::saeStargateTUAILLON_LONGO_YURTSEBEN.Properties.Resources.telephone;
            this.picExtra.Location = new System.Drawing.Point(194, 52);
            this.picExtra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picExtra.Name = "picExtra";
            this.picExtra.Size = new System.Drawing.Size(89, 88);
            this.picExtra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExtra.TabIndex = 3;
            this.picExtra.TabStop = false;
            // 
            // lblDatabaz
            // 
            this.lblDatabaz.AutoSize = true;
            this.lblDatabaz.Location = new System.Drawing.Point(21, 220);
            this.lblDatabaz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatabaz.Name = "lblDatabaz";
            this.lblDatabaz.Size = new System.Drawing.Size(122, 13);
            this.lblDatabaz.TabIndex = 2;
            this.lblDatabaz.Text = "Qté qDatabaz souhaitée";
            // 
            // picDatabaz
            // 
            this.picDatabaz.Image = global::saeStargateTUAILLON_LONGO_YURTSEBEN.Properties.Resources.qDatabaz;
            this.picDatabaz.Location = new System.Drawing.Point(191, 220);
            this.picDatabaz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picDatabaz.Name = "picDatabaz";
            this.picDatabaz.Size = new System.Drawing.Size(93, 86);
            this.picDatabaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDatabaz.TabIndex = 1;
            this.picDatabaz.TabStop = false;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(21, 42);
            this.lblExtra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(69, 13);
            this.lblExtra.TabIndex = 0;
            this.lblExtra.Text = "Allie souhaité";
            // 
            // menuBar1
            // 
            this.menuBar1.AutoSize = true;
            this.menuBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(971, 32);
            this.menuBar1.TabIndex = 3;
            // 
            // frmNegociation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 549);
            this.Controls.Add(this.menuBar1);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.grpNegoc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(985, 538);
            this.Name = "frmNegociation";
            this.Text = "frmNegociation";
            this.Load += new System.EventHandler(this.frmNegociation_Load);
            this.grpNegoc.ResumeLayout(false);
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDatabaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNegoc;
        private System.Windows.Forms.GroupBox grpNegoc;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.PictureBox picDatabaz;
        private System.Windows.Forms.PictureBox picExtra;
        private System.Windows.Forms.Label lblDatabaz;
        private System.Windows.Forms.Button btnValiderDemande;
        private System.Windows.Forms.TextBox txtQtDatabaz;
        private System.Windows.Forms.ComboBox cmbAllie;
        private control.menuBar menuBar1;
    }
}