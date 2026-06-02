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
            this.pnlNegoc.Location = new System.Drawing.Point(22, 40);
            this.pnlNegoc.Name = "pnlNegoc";
            this.pnlNegoc.Size = new System.Drawing.Size(928, 669);
            this.pnlNegoc.TabIndex = 0;
            // 
            // grpNegoc
            // 
            this.grpNegoc.Controls.Add(this.pnlNegoc);
            this.grpNegoc.Location = new System.Drawing.Point(465, 89);
            this.grpNegoc.Name = "grpNegoc";
            this.grpNegoc.Size = new System.Drawing.Size(976, 720);
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
            this.grpContact.Location = new System.Drawing.Point(15, 114);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(444, 685);
            this.grpContact.TabIndex = 2;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contacter un extraterrestre";
            // 
            // cmbAllie
            // 
            this.cmbAllie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAllie.FormattingEnabled = true;
            this.cmbAllie.Location = new System.Drawing.Point(15, 109);
            this.cmbAllie.Name = "cmbAllie";
            this.cmbAllie.Size = new System.Drawing.Size(212, 28);
            this.cmbAllie.TabIndex = 6;
            this.cmbAllie.SelectedIndexChanged += new System.EventHandler(this.cmbAllie_SelectedIndexChanged);
            // 
            // txtQtDatabaz
            // 
            this.txtQtDatabaz.Location = new System.Drawing.Point(36, 422);
            this.txtQtDatabaz.Name = "txtQtDatabaz";
            this.txtQtDatabaz.Size = new System.Drawing.Size(128, 26);
            this.txtQtDatabaz.TabIndex = 5;
            // 
            // btnValiderDemande
            // 
            this.btnValiderDemande.Location = new System.Drawing.Point(152, 585);
            this.btnValiderDemande.Name = "btnValiderDemande";
            this.btnValiderDemande.Size = new System.Drawing.Size(273, 74);
            this.btnValiderDemande.TabIndex = 4;
            this.btnValiderDemande.Text = "Soumettre la demande";
            this.btnValiderDemande.UseVisualStyleBackColor = true;
            this.btnValiderDemande.Click += new System.EventHandler(this.btnValiderDemande_Click);
            // 
            // picExtra
            // 
            this.picExtra.Image = global::saeStargateTUAILLON_LONGO_YURTSEBEN.Properties.Resources.telephone;
            this.picExtra.Location = new System.Drawing.Point(291, 80);
            this.picExtra.Name = "picExtra";
            this.picExtra.Size = new System.Drawing.Size(134, 135);
            this.picExtra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExtra.TabIndex = 3;
            this.picExtra.TabStop = false;
            // 
            // lblDatabaz
            // 
            this.lblDatabaz.AutoSize = true;
            this.lblDatabaz.Location = new System.Drawing.Point(32, 338);
            this.lblDatabaz.Name = "lblDatabaz";
            this.lblDatabaz.Size = new System.Drawing.Size(183, 20);
            this.lblDatabaz.TabIndex = 2;
            this.lblDatabaz.Text = "Qté qDatabaz souhaitée";
            // 
            // picDatabaz
            // 
            this.picDatabaz.Image = global::saeStargateTUAILLON_LONGO_YURTSEBEN.Properties.Resources.qDatabaz;
            this.picDatabaz.Location = new System.Drawing.Point(286, 338);
            this.picDatabaz.Name = "picDatabaz";
            this.picDatabaz.Size = new System.Drawing.Size(140, 132);
            this.picDatabaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDatabaz.TabIndex = 1;
            this.picDatabaz.TabStop = false;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(32, 65);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(103, 20);
            this.lblExtra.TabIndex = 0;
            this.lblExtra.Text = "Allie souhaité";
            // 
            // menuBar1
            // 
            this.menuBar1.AutoSize = true;
            this.menuBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(1458, 48);
            this.menuBar1.TabIndex = 3;
            // 
            // frmNegociation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 845);
            this.Controls.Add(this.menuBar1);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.grpNegoc);
            this.MinimumSize = new System.Drawing.Size(1470, 807);
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