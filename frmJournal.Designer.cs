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
            this.lblCompteur = new System.Windows.Forms.Label();
            this.dtEventJournal = new System.Windows.Forms.DateTimePicker();
            this.lblEventJournal = new System.Windows.Forms.Label();
            this.btnTTdebut = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnTTfin = new System.Windows.Forms.Button();
            this.btnDepenses = new System.Windows.Forms.Button();
            this.btnCapturesAfficher = new System.Windows.Forms.Button();
            this.btnIndics = new System.Windows.Forms.Button();
            this.grpEventsJournal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEventsJournal
            // 
            this.grpEventsJournal.Controls.Add(this.lblCompteur);
            this.grpEventsJournal.Controls.Add(this.dtEventJournal);
            this.grpEventsJournal.Controls.Add(this.lblEventJournal);
            this.grpEventsJournal.Controls.Add(this.btnTTdebut);
            this.grpEventsJournal.Controls.Add(this.btnPrecedent);
            this.grpEventsJournal.Controls.Add(this.btnSuivant);
            this.grpEventsJournal.Controls.Add(this.btnTTfin);
            this.grpEventsJournal.Location = new System.Drawing.Point(12, 28);
            this.grpEventsJournal.Name = "grpEventsJournal";
            this.grpEventsJournal.Size = new System.Drawing.Size(712, 338);
            this.grpEventsJournal.TabIndex = 0;
            this.grpEventsJournal.TabStop = false;
            this.grpEventsJournal.Text = "Évènements du journal";
            // 
            // lblCompteur
            // 
            this.lblCompteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCompteur.Location = new System.Drawing.Point(15, 51);
            this.lblCompteur.Name = "lblCompteur";
            this.lblCompteur.Size = new System.Drawing.Size(226, 39);
            this.lblCompteur.TabIndex = 6;
            this.lblCompteur.Text = "Évènement - / -";
            // 
            // dtEventJournal
            // 
            this.dtEventJournal.CustomFormat = "dd/MM/yyyy";
            this.dtEventJournal.Enabled = false;
            this.dtEventJournal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEventJournal.Location = new System.Drawing.Point(470, 25);
            this.dtEventJournal.Name = "dtEventJournal";
            this.dtEventJournal.Size = new System.Drawing.Size(200, 26);
            this.dtEventJournal.TabIndex = 0;
            // 
            // lblEventJournal
            // 
            this.lblEventJournal.Location = new System.Drawing.Point(6, 90);
            this.lblEventJournal.Name = "lblEventJournal";
            this.lblEventJournal.Size = new System.Drawing.Size(700, 145);
            this.lblEventJournal.TabIndex = 1;
            this.lblEventJournal.Text = "Aucun événement trouvé";
            // 
            // btnTTdebut
            // 
            this.btnTTdebut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTTdebut.Location = new System.Drawing.Point(5, 238);
            this.btnTTdebut.Name = "btnTTdebut";
            this.btnTTdebut.Size = new System.Drawing.Size(126, 85);
            this.btnTTdebut.TabIndex = 2;
            this.btnTTdebut.Text = "|<  Début";
            this.btnTTdebut.UseVisualStyleBackColor = true;
            this.btnTTdebut.Click += new System.EventHandler(this.btnTTdebut_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrecedent.Location = new System.Drawing.Point(193, 238);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(143, 85);
            this.btnPrecedent.TabIndex = 4;
            this.btnPrecedent.Text = "<  Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuivant.Location = new System.Drawing.Point(396, 238);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(131, 85);
            this.btnSuivant.TabIndex = 5;
            this.btnSuivant.Text = "Suivant  >";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnTTfin
            // 
            this.btnTTfin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTTfin.Location = new System.Drawing.Point(571, 238);
            this.btnTTfin.Name = "btnTTfin";
            this.btnTTfin.Size = new System.Drawing.Size(135, 85);
            this.btnTTfin.TabIndex = 3;
            this.btnTTfin.Text = "Fin  >|";
            this.btnTTfin.UseVisualStyleBackColor = true;
            this.btnTTfin.Click += new System.EventHandler(this.btnTTfin_Click);
            // 
            // btnDepenses
            // 
            this.btnDepenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepenses.Location = new System.Drawing.Point(23, 372);
            this.btnDepenses.Name = "btnDepenses";
            this.btnDepenses.Size = new System.Drawing.Size(190, 100);
            this.btnDepenses.TabIndex = 1;
            this.btnDepenses.Text = "Consulter les dépenses";
            this.btnDepenses.UseVisualStyleBackColor = true;
            this.btnDepenses.Click += new System.EventHandler(this.btnDepenses_Click);
            // 
            // btnCapturesAfficher
            // 
            this.btnCapturesAfficher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapturesAfficher.Location = new System.Drawing.Point(516, 372);
            this.btnCapturesAfficher.Name = "btnCapturesAfficher";
            this.btnCapturesAfficher.Size = new System.Drawing.Size(202, 100);
            this.btnCapturesAfficher.TabIndex = 3;
            this.btnCapturesAfficher.Text = "Afficher l\'avancée des captures";
            this.btnCapturesAfficher.UseVisualStyleBackColor = true;
            this.btnCapturesAfficher.Click += new System.EventHandler(this.btnCapturesAfficher_Click);
            // 
            // btnIndics
            // 
            this.btnIndics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIndics.Location = new System.Drawing.Point(279, 375);
            this.btnIndics.Name = "btnIndics";
            this.btnIndics.Size = new System.Drawing.Size(202, 95);
            this.btnIndics.TabIndex = 2;
            this.btnIndics.Text = "Consulter les contacts";
            this.btnIndics.UseVisualStyleBackColor = true;
            this.btnIndics.Click += new System.EventHandler(this.btnIndics_Click);
            // 
            // frmJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 484);
            this.Controls.Add(this.btnCapturesAfficher);
            this.Controls.Add(this.btnIndics);
            this.Controls.Add(this.btnDepenses);
            this.Controls.Add(this.grpEventsJournal);
            this.Name = "frmJournal";
            this.Text = "Journal de bord";
            this.Load += new System.EventHandler(this.frmJournal_Load);
            this.grpEventsJournal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEventsJournal;
        private System.Windows.Forms.Label lblCompteur;
        private System.Windows.Forms.DateTimePicker dtEventJournal;
        private System.Windows.Forms.Label lblEventJournal;
        private System.Windows.Forms.Button btnTTdebut;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnTTfin;
        private System.Windows.Forms.Button btnDepenses;
        private System.Windows.Forms.Button btnCapturesAfficher;
        private System.Windows.Forms.Button btnIndics;
    }
}