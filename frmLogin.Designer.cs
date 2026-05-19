namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    partial class frmLogin
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
            this.lblTitreLogin = new System.Windows.Forms.Label();
            this.lblDetailsLogin = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAfficherMdp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitreLogin
            // 
            this.lblTitreLogin.AutoSize = true;
            this.lblTitreLogin.Location = new System.Drawing.Point(233, 9);
            this.lblTitreLogin.Name = "lblTitreLogin";
            this.lblTitreLogin.Size = new System.Drawing.Size(204, 26);
            this.lblTitreLogin.TabIndex = 0;
            this.lblTitreLogin.Text = "L\'accès est restreint";
            // 
            // lblDetailsLogin
            // 
            this.lblDetailsLogin.AutoSize = true;
            this.lblDetailsLogin.Location = new System.Drawing.Point(111, 135);
            this.lblDetailsLogin.Name = "lblDetailsLogin";
            this.lblDetailsLogin.Size = new System.Drawing.Size(460, 26);
            this.lblDetailsLogin.TabIndex = 1;
            this.lblDetailsLogin.Text = "Veuillez entrer vos informations pour continuer";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(116, 265);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(186, 26);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Nom d\'utilisateur :";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(111, 360);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(154, 26);
            this.lblMdp.TabIndex = 3;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(350, 264);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(221, 32);
            this.txtLogin.TabIndex = 4;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(350, 354);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '●';
            this.txtMdp.Size = new System.Drawing.Size(221, 32);
            this.txtMdp.TabIndex = 5;
            this.txtMdp.TextChanged += new System.EventHandler(this.txtMd_TextChanged);
            this.txtMdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMdp_KeyPress);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmer.Location = new System.Drawing.Point(494, 482);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(159, 48);
            this.btnConfirmer.TabIndex = 6;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.Location = new System.Drawing.Point(294, 482);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(159, 48);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAfficherMdp
            // 
            this.btnAfficherMdp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAfficherMdp.Location = new System.Drawing.Point(598, 354);
            this.btnAfficherMdp.Name = "btnAfficherMdp";
            this.btnAfficherMdp.Size = new System.Drawing.Size(55, 32);
            this.btnAfficherMdp.TabIndex = 8;
            this.btnAfficherMdp.Text = "?";
            this.btnAfficherMdp.UseVisualStyleBackColor = true;
            this.btnAfficherMdp.Click += new System.EventHandler(this.btnAfficherMdp_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 559);
            this.Controls.Add(this.btnAfficherMdp);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblDetailsLogin);
            this.Controls.Add(this.lblTitreLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreLogin;
        private System.Windows.Forms.Label lblDetailsLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAfficherMdp;
    }
}