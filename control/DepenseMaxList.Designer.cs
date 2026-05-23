namespace saeStargateTUAILLON_LONGO_YURTSEBEN.control
{
    partial class DepenseMaxList
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
            this.flpDepense = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpDepense
            // 
            this.flpDepense.AutoScroll = true;
            this.flpDepense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDepense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDepense.Location = new System.Drawing.Point(0, 0);
            this.flpDepense.Name = "flpDepense";
            this.flpDepense.Size = new System.Drawing.Size(493, 346);
            this.flpDepense.TabIndex = 0;
            // 
            // DepenseMaxList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flpDepense);
            this.Name = "DepenseMaxList";
            this.Size = new System.Drawing.Size(493, 346);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpDepense;
    }
}
