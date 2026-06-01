namespace saeStargateTUAILLON_LONGO_YURTSEBEN.control
{
    partial class menuBar
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
            this.picMoins = new System.Windows.Forms.PictureBox();
            this.picFermer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFermer)).BeginInit();
            this.SuspendLayout();
            // 
            // picMoins
            // 
            this.picMoins.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picMoins.Image = global::saeStargateTUAILLON_LONGO_YURTSEBEN.Properties.Resources.moins;
            this.picMoins.Location = new System.Drawing.Point(700, 2);
            this.picMoins.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picMoins.Name = "picMoins";
            this.picMoins.Size = new System.Drawing.Size(20, 27);
            this.picMoins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMoins.TabIndex = 0;
            this.picMoins.TabStop = false;
            this.picMoins.Click += new System.EventHandler(this.picMoins_Click);
            this.picMoins.MouseEnter += new System.EventHandler(this.picFermer_MouseEnter);
            this.picMoins.MouseLeave += new System.EventHandler(this.picFermer_MouseLeave);
            // 
            // picFermer
            // 
            this.picFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picFermer.Image = global::saeStargateTUAILLON_LONGO_YURTSEBEN.Properties.Resources.fermerFrm;
            this.picFermer.Location = new System.Drawing.Point(739, 2);
            this.picFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picFermer.Name = "picFermer";
            this.picFermer.Size = new System.Drawing.Size(20, 27);
            this.picFermer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFermer.TabIndex = 1;
            this.picFermer.TabStop = false;
            this.picFermer.Click += new System.EventHandler(this.picFermer_Click);
            this.picFermer.MouseEnter += new System.EventHandler(this.picFermer_MouseEnter);
            this.picFermer.MouseLeave += new System.EventHandler(this.picFermer_MouseLeave);
            // 
            // menuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.picFermer);
            this.Controls.Add(this.picMoins);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "menuBar";
            this.Size = new System.Drawing.Size(885, 46);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuBar_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picMoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFermer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMoins;
        private System.Windows.Forms.PictureBox picFermer;
    }
}
