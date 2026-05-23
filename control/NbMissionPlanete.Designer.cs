namespace saeStargateTUAILLON_LONGO_YURTSEBEN.control
{
    partial class NbMissionPlanete
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
            this.flpPlanete = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpPlanete
            // 
            this.flpPlanete.AutoScroll = true;
            this.flpPlanete.Location = new System.Drawing.Point(21, 19);
            this.flpPlanete.Name = "flpPlanete";
            this.flpPlanete.Size = new System.Drawing.Size(713, 345);
            this.flpPlanete.TabIndex = 0;
            // 
            // NbMissionPlanete
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flpPlanete);
            this.Name = "NbMissionPlanete";
            this.Size = new System.Drawing.Size(750, 384);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPlanete;
    }
}
