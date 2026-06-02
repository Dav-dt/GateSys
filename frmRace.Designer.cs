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
            this.grpFiltre = new System.Windows.Forms.GroupBox();
            this.rbEnnemi = new System.Windows.Forms.RadioButton();
            this.rbAllie = new System.Windows.Forms.RadioButton();
            this.rbTous = new System.Windows.Forms.RadioButton();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.cboCouleur = new System.Windows.Forms.ComboBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.menuBar1 = new saeStargateTUAILLON_LONGO_YURTSEBEN.control.menuBar();
            this.buttonBack1 = new saeStargateTUAILLON_LONGO_YURTSEBEN.control.ButtonBack();
            this.grpFiltre.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpRace
            // 
            this.flpRace.AutoScroll = true;
            this.flpRace.Location = new System.Drawing.Point(39, 285);
            this.flpRace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpRace.Name = "flpRace";
            this.flpRace.Size = new System.Drawing.Size(1176, 654);
            this.flpRace.TabIndex = 0;
            // 
            // grpFiltre
            // 
            this.grpFiltre.Controls.Add(this.rbEnnemi);
            this.grpFiltre.Controls.Add(this.rbAllie);
            this.grpFiltre.Controls.Add(this.rbTous);
            this.grpFiltre.Controls.Add(this.btnFiltre);
            this.grpFiltre.Controls.Add(this.cboCouleur);
            this.grpFiltre.Controls.Add(this.txtNom);
            this.grpFiltre.Controls.Add(this.lblCouleur);
            this.grpFiltre.Controls.Add(this.lblNom);
            this.grpFiltre.Location = new System.Drawing.Point(39, 52);
            this.grpFiltre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFiltre.Name = "grpFiltre";
            this.grpFiltre.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFiltre.Size = new System.Drawing.Size(1160, 203);
            this.grpFiltre.TabIndex = 1;
            this.grpFiltre.TabStop = false;
            this.grpFiltre.Text = "Filtres";
            // 
            // rbEnnemi
            // 
            this.rbEnnemi.AutoSize = true;
            this.rbEnnemi.Location = new System.Drawing.Point(621, 152);
            this.rbEnnemi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbEnnemi.Name = "rbEnnemi";
            this.rbEnnemi.Size = new System.Drawing.Size(88, 24);
            this.rbEnnemi.TabIndex = 7;
            this.rbEnnemi.TabStop = true;
            this.rbEnnemi.Text = "Ennemi";
            this.rbEnnemi.UseVisualStyleBackColor = true;
            this.rbEnnemi.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbAllie
            // 
            this.rbAllie.AutoSize = true;
            this.rbAllie.Location = new System.Drawing.Point(621, 102);
            this.rbAllie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbAllie.Name = "rbAllie";
            this.rbAllie.Size = new System.Drawing.Size(63, 24);
            this.rbAllie.TabIndex = 6;
            this.rbAllie.TabStop = true;
            this.rbAllie.Text = "Allie";
            this.rbAllie.UseVisualStyleBackColor = true;
            this.rbAllie.CheckedChanged += new System.EventHandler(this.rbAllie_CheckedChanged);
            // 
            // rbTous
            // 
            this.rbTous.AutoSize = true;
            this.rbTous.Location = new System.Drawing.Point(621, 51);
            this.rbTous.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbTous.Name = "rbTous";
            this.rbTous.Size = new System.Drawing.Size(69, 24);
            this.rbTous.TabIndex = 5;
            this.rbTous.TabStop = true;
            this.rbTous.Text = "Tous";
            this.rbTous.UseVisualStyleBackColor = true;
            this.rbTous.CheckedChanged += new System.EventHandler(this.rbTous_CheckedChanged);
            // 
            // btnFiltre
            // 
            this.btnFiltre.BackgroundImage = global::saeStargateTUAILLON_LONGO_YURTSEBEN.Properties.Resources.loupeBetter;
            this.btnFiltre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltre.Location = new System.Drawing.Point(1018, 49);
            this.btnFiltre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(117, 98);
            this.btnFiltre.TabIndex = 4;
            this.btnFiltre.UseVisualStyleBackColor = true;
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            // 
            // cboCouleur
            // 
            this.cboCouleur.FormattingEnabled = true;
            this.cboCouleur.Location = new System.Drawing.Point(99, 109);
            this.cboCouleur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCouleur.Name = "cboCouleur";
            this.cboCouleur.Size = new System.Drawing.Size(220, 28);
            this.cboCouleur.TabIndex = 3;
            this.cboCouleur.SelectedIndexChanged += new System.EventHandler(this.cboCouleur_SelectedIndexChanged);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(99, 42);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(212, 26);
            this.txtNom.TabIndex = 2;
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Location = new System.Drawing.Point(9, 114);
            this.lblCouleur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(64, 20);
            this.lblCouleur.TabIndex = 1;
            this.lblCouleur.Text = "Couleur";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(15, 46);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // menuBar1
            // 
            this.menuBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuBar1.Location = new System.Drawing.Point(3, -3);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(1244, 58);
            this.menuBar1.TabIndex = 3;
            // 
            // buttonBack1
            // 
            this.buttonBack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.buttonBack1.Location = new System.Drawing.Point(1079, 949);
            this.buttonBack1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Size = new System.Drawing.Size(136, 91);
            this.buttonBack1.TabIndex = 2;
            // 
            // frmRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 1045);
            this.Controls.Add(this.menuBar1);
            this.Controls.Add(this.buttonBack1);
            this.Controls.Add(this.grpFiltre);
            this.Controls.Add(this.flpRace);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRace";
            this.Text = "frmRace";
            this.Load += new System.EventHandler(this.frmRace_Load);
            this.grpFiltre.ResumeLayout(false);
            this.grpFiltre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpRace;
        private System.Windows.Forms.GroupBox grpFiltre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cboCouleur;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnFiltre;
        private System.Windows.Forms.RadioButton rbAllie;
        private System.Windows.Forms.RadioButton rbTous;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.RadioButton rbEnnemi;
        private control.ButtonBack buttonBack1;
        private control.menuBar menuBar1;
    }
}