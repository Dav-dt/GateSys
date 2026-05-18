namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    partial class frmJournal
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
            this.grpEventsJournal = new System.Windows.Forms.GroupBox();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnTTfin = new System.Windows.Forms.Button();
            this.btnTTdebut = new System.Windows.Forms.Button();
            this.lblEventJournal = new System.Windows.Forms.Label();
            this.dtEventJournal = new System.Windows.Forms.DateTimePicker();
            this.btnDepenses = new System.Windows.Forms.Button();
            this.btnIndics = new System.Windows.Forms.Button();
            this.btnCapturesAfficher = new System.Windows.Forms.Button();
            this.grpEventsJournal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEventsJournal
            // 
            this.grpEventsJournal.Controls.Add(this.btnSuivant);
            this.grpEventsJournal.Controls.Add(this.btnPrecedent);
            this.grpEventsJournal.Controls.Add(this.btnTTfin);
            this.grpEventsJournal.Controls.Add(this.btnTTdebut);
            this.grpEventsJournal.Controls.Add(this.lblEventJournal);
            this.grpEventsJournal.Controls.Add(this.dtEventJournal);
            this.grpEventsJournal.Location = new System.Drawing.Point(12, 28);
            this.grpEventsJournal.Name = "grpEventsJournal";
            this.grpEventsJournal.Size = new System.Drawing.Size(712, 293);
            this.grpEventsJournal.TabIndex = 0;
            this.grpEventsJournal.TabStop = false;
            this.grpEventsJournal.Text = "Evénements du journal";
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(410, 205);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(106, 47);
            this.btnSuivant.TabIndex = 5;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(212, 205);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(113, 47);
            this.btnPrecedent.TabIndex = 4;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnTTfin
            // 
            this.btnTTfin.Location = new System.Drawing.Point(585, 205);
            this.btnTTfin.Name = "btnTTfin";
            this.btnTTfin.Size = new System.Drawing.Size(110, 47);
            this.btnTTfin.TabIndex = 3;
            this.btnTTfin.Text = "Fin";
            this.btnTTfin.UseVisualStyleBackColor = true;
            this.btnTTfin.Click += new System.EventHandler(this.btnTTfin_Click);
            // 
            // btnTTdebut
            // 
            this.btnTTdebut.Location = new System.Drawing.Point(19, 205);
            this.btnTTdebut.Name = "btnTTdebut";
            this.btnTTdebut.Size = new System.Drawing.Size(101, 47);
            this.btnTTdebut.TabIndex = 2;
            this.btnTTdebut.Text = "Début";
            this.btnTTdebut.UseVisualStyleBackColor = true;
            this.btnTTdebut.Click += new System.EventHandler(this.btnTTdebut_Click);
            // 
            // lblEventJournal
            // 
            this.lblEventJournal.AutoSize = true;
            this.lblEventJournal.Location = new System.Drawing.Point(15, 129);
            this.lblEventJournal.Name = "lblEventJournal";
            this.lblEventJournal.Size = new System.Drawing.Size(188, 20);
            this.lblEventJournal.TabIndex = 1;
            this.lblEventJournal.Text = "Aucun Evenement trouvé";
            // 
            // dtEventJournal
            // 
            this.dtEventJournal.Enabled = false;
            this.dtEventJournal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEventJournal.Location = new System.Drawing.Point(289, 58);
            this.dtEventJournal.Name = "dtEventJournal";
            this.dtEventJournal.Size = new System.Drawing.Size(200, 26);
            this.dtEventJournal.TabIndex = 0;
            // 
            // btnDepenses
            // 
            this.btnDepenses.Location = new System.Drawing.Point(31, 379);
            this.btnDepenses.Name = "btnDepenses";
            this.btnDepenses.Size = new System.Drawing.Size(143, 64);
            this.btnDepenses.TabIndex = 1;
            this.btnDepenses.Text = "Consulter les dépenses";
            this.btnDepenses.UseVisualStyleBackColor = true;
            this.btnDepenses.Click += new System.EventHandler(this.btnDepenses_Click);
            // 
            // btnIndics
            // 
            this.btnIndics.Location = new System.Drawing.Point(564, 379);
            this.btnIndics.Name = "btnIndics";
            this.btnIndics.Size = new System.Drawing.Size(143, 64);
            this.btnIndics.TabIndex = 2;
            this.btnIndics.Text = "Consulter les contacts";
            this.btnIndics.UseVisualStyleBackColor = true;
            this.btnIndics.Click += new System.EventHandler(this.btnIndics_Click);
            // 
            // btnCapturesAfficher
            // 
            this.btnCapturesAfficher.Location = new System.Drawing.Point(301, 379);
            this.btnCapturesAfficher.Name = "btnCapturesAfficher";
            this.btnCapturesAfficher.Size = new System.Drawing.Size(165, 64);
            this.btnCapturesAfficher.TabIndex = 3;
            this.btnCapturesAfficher.Text = "Afficher l\'avancée des captures";
            this.btnCapturesAfficher.UseVisualStyleBackColor = true;
            this.btnCapturesAfficher.Click += new System.EventHandler(this.btnCapturesAfficher_Click);
            // 
            // frmJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 467);
            this.Controls.Add(this.btnCapturesAfficher);
            this.Controls.Add(this.btnIndics);
            this.Controls.Add(this.btnDepenses);
            this.Controls.Add(this.grpEventsJournal);
            this.Name = "frmJournal";
            this.Text = "frmJournal";
            this.Load += new System.EventHandler(this.frmJournal_Load);
            this.grpEventsJournal.ResumeLayout(false);
            this.grpEventsJournal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEventsJournal;
        private System.Windows.Forms.Label lblEventJournal;
        private System.Windows.Forms.DateTimePicker dtEventJournal;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnTTfin;
        private System.Windows.Forms.Button btnTTdebut;
        private System.Windows.Forms.Button btnDepenses;
        private System.Windows.Forms.Button btnIndics;
        private System.Windows.Forms.Button btnCapturesAfficher;
    }
}