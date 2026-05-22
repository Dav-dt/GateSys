namespace saeStargateTUAILLON_LONGO_YURTSEBEN.control
{
    partial class BarBudget
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
            this.lblZero = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.pBarBudget = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblZero
            // 
            this.lblZero.AutoSize = true;
            this.lblZero.Location = new System.Drawing.Point(12, 58);
            this.lblZero.Name = "lblZero";
            this.lblZero.Size = new System.Drawing.Size(13, 13);
            this.lblZero.TabIndex = 1;
            this.lblZero.Text = "0";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(297, 58);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(35, 13);
            this.lblBudget.TabIndex = 2;
            this.lblBudget.Text = "label2";
            // 
            // pBarBudget
            // 
            this.pBarBudget.Location = new System.Drawing.Point(43, 43);
            this.pBarBudget.Name = "pBarBudget";
            this.pBarBudget.Size = new System.Drawing.Size(231, 42);
            this.pBarBudget.TabIndex = 3;
            // 
            // BarBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pBarBudget);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblZero);
            this.Name = "BarBudget";
            this.Size = new System.Drawing.Size(347, 138);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZero;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.ProgressBar pBarBudget;
    }
}
