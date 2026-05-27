namespace saeStargateTUAILLON_LONGO_YURTSEBEN.control
{
    partial class Planete
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlanete = new System.Windows.Forms.Label();
            this.rtxtTemp = new System.Windows.Forms.RichTextBox();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.lblGravite = new System.Windows.Forms.Label();
            this.chkDatabaz = new System.Windows.Forms.CheckBox();
            this.pbPlanete = new System.Windows.Forms.PictureBox();
            this.btnDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanete)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlanete
            // 
            this.lblPlanete.AutoSize = true;
            this.lblPlanete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanete.Location = new System.Drawing.Point(189, 21);
            this.lblPlanete.Name = "lblPlanete";
            this.lblPlanete.Size = new System.Drawing.Size(66, 24);
            this.lblPlanete.TabIndex = 1;
            this.lblPlanete.Text = "label1";
            // 
            // rtxtTemp
            // 
            this.rtxtTemp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtxtTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTemp.Location = new System.Drawing.Point(192, 52);
            this.rtxtTemp.Name = "rtxtTemp";
            this.rtxtTemp.ReadOnly = true;
            this.rtxtTemp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtTemp.ShortcutsEnabled = false;
            this.rtxtTemp.Size = new System.Drawing.Size(122, 39);
            this.rtxtTemp.TabIndex = 2;
            this.rtxtTemp.TabStop = false;
            this.rtxtTemp.Text = "";
            this.rtxtTemp.TextChanged += new System.EventHandler(this.rtxtTemp_TextChanged);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // lblGravite
            // 
            this.lblGravite.AutoSize = true;
            this.lblGravite.Location = new System.Drawing.Point(189, 128);
            this.lblGravite.Name = "lblGravite";
            this.lblGravite.Size = new System.Drawing.Size(47, 13);
            this.lblGravite.TabIndex = 3;
            this.lblGravite.Text = "Gravité: ";
            // 
            // chkDatabaz
            // 
            this.chkDatabaz.AutoCheck = false;
            this.chkDatabaz.AutoSize = true;
            this.chkDatabaz.Location = new System.Drawing.Point(183, 159);
            this.chkDatabaz.Name = "chkDatabaz";
            this.chkDatabaz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDatabaz.Size = new System.Drawing.Size(66, 17);
            this.chkDatabaz.TabIndex = 5;
            this.chkDatabaz.Text = "Databaz";
            this.chkDatabaz.UseVisualStyleBackColor = true;
            this.chkDatabaz.CheckedChanged += new System.EventHandler(this.chkDatabaz_CheckedChanged);
            // 
            // pbPlanete
            // 
            this.pbPlanete.Location = new System.Drawing.Point(13, 21);
            this.pbPlanete.Name = "pbPlanete";
            this.pbPlanete.Size = new System.Drawing.Size(155, 155);
            this.pbPlanete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlanete.TabIndex = 0;
            this.pbPlanete.TabStop = false;
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(285, 154);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(83, 24);
            this.btnDetail.TabIndex = 6;
            this.btnDetail.Text = "Détails";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // Planete
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.chkDatabaz);
            this.Controls.Add(this.lblGravite);
            this.Controls.Add(this.rtxtTemp);
            this.Controls.Add(this.lblPlanete);
            this.Controls.Add(this.pbPlanete);
            this.Name = "Planete";
            this.Size = new System.Drawing.Size(373, 198);
            this.Load += new System.EventHandler(this.Planete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlanete;
        private System.Windows.Forms.Label lblPlanete;
        private System.Windows.Forms.RichTextBox rtxtTemp;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Label lblGravite;
        private System.Windows.Forms.CheckBox chkDatabaz;
        private System.Windows.Forms.Button btnDetail;
    }
}
