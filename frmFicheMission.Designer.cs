namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    partial class frmFicheMission
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
            this.tabCtrlEdition = new System.Windows.Forms.TabControl();
            this.tabNouveauContact = new System.Windows.Forms.TabPage();
            this.btnValiderIndic = new System.Windows.Forms.Button();
            this.cmbINomIndic = new System.Windows.Forms.ComboBox();
            this.lblNomIndic = new System.Windows.Forms.Label();
            this.txtAppreciationIndic = new System.Windows.Forms.TextBox();
            this.lblAppreciationIndic = new System.Windows.Forms.Label();
            this.txtSoudoiementIndic = new System.Windows.Forms.TextBox();
            this.lblSommeIndic = new System.Windows.Forms.Label();
            this.dtIndic = new System.Windows.Forms.DateTimePicker();
            this.lblDateIndic = new System.Windows.Forms.Label();
            this.tabNouvelleDepense = new System.Windows.Forms.TabPage();
            this.btnValiderDepense = new System.Windows.Forms.Button();
            this.cmbIdDepense = new System.Windows.Forms.ComboBox();
            this.lblIdDepense = new System.Windows.Forms.Label();
            this.txtMotifDepense = new System.Windows.Forms.TextBox();
            this.lblMotifDepense = new System.Windows.Forms.Label();
            this.txtMontantDepense = new System.Windows.Forms.TextBox();
            this.lblDepense = new System.Windows.Forms.Label();
            this.dtDepense = new System.Windows.Forms.DateTimePicker();
            this.lblDtDepense = new System.Windows.Forms.Label();
            this.tabNouvelEvenement = new System.Windows.Forms.TabPage();
            this.btnValiderNouvelEvent = new System.Windows.Forms.Button();
            this.txtNouvelEvent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNouvelEvent = new System.Windows.Forms.DateTimePicker();
            this.lblDtNouvelEvent = new System.Windows.Forms.Label();
            this.lblMission = new System.Windows.Forms.Label();
            this.lblDtDepart = new System.Windows.Forms.Label();
            this.lblDtRetour = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblBudgetApresDepenses = new System.Windows.Forms.Label();
            this.grpFeuilleDeRoute = new System.Windows.Forms.GroupBox();
            this.txtFeuilleDeRoute = new System.Windows.Forms.TextBox();
            this.grpMembresEquipe = new System.Windows.Forms.GroupBox();
            this.pnlMembres = new System.Windows.Forms.Panel();
            this.grpCapture = new System.Windows.Forms.GroupBox();
            this.pnlCapture = new System.Windows.Forms.Panel();
            this.btnJournal = new System.Windows.Forms.Button();
            this.tabCtrlEdition.SuspendLayout();
            this.tabNouveauContact.SuspendLayout();
            this.tabNouvelleDepense.SuspendLayout();
            this.tabNouvelEvenement.SuspendLayout();
            this.grpFeuilleDeRoute.SuspendLayout();
            this.grpMembresEquipe.SuspendLayout();
            this.grpCapture.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlEdition
            // 
            this.tabCtrlEdition.Controls.Add(this.tabNouveauContact);
            this.tabCtrlEdition.Controls.Add(this.tabNouvelleDepense);
            this.tabCtrlEdition.Controls.Add(this.tabNouvelEvenement);
            this.tabCtrlEdition.Location = new System.Drawing.Point(530, 10);
            this.tabCtrlEdition.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabCtrlEdition.Name = "tabCtrlEdition";
            this.tabCtrlEdition.SelectedIndex = 0;
            this.tabCtrlEdition.Size = new System.Drawing.Size(432, 648);
            this.tabCtrlEdition.TabIndex = 0;
            // 
            // tabNouveauContact
            // 
            this.tabNouveauContact.Controls.Add(this.btnValiderIndic);
            this.tabNouveauContact.Controls.Add(this.cmbINomIndic);
            this.tabNouveauContact.Controls.Add(this.lblNomIndic);
            this.tabNouveauContact.Controls.Add(this.txtAppreciationIndic);
            this.tabNouveauContact.Controls.Add(this.lblAppreciationIndic);
            this.tabNouveauContact.Controls.Add(this.txtSoudoiementIndic);
            this.tabNouveauContact.Controls.Add(this.lblSommeIndic);
            this.tabNouveauContact.Controls.Add(this.dtIndic);
            this.tabNouveauContact.Controls.Add(this.lblDateIndic);
            this.tabNouveauContact.Location = new System.Drawing.Point(4, 31);
            this.tabNouveauContact.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabNouveauContact.Name = "tabNouveauContact";
            this.tabNouveauContact.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabNouveauContact.Size = new System.Drawing.Size(424, 613);
            this.tabNouveauContact.TabIndex = 0;
            this.tabNouveauContact.Text = "Nouveau contact";
            this.tabNouveauContact.UseVisualStyleBackColor = true;
            // 
            // btnValiderIndic
            // 
            this.btnValiderIndic.Location = new System.Drawing.Point(294, 547);
            this.btnValiderIndic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnValiderIndic.Name = "btnValiderIndic";
            this.btnValiderIndic.Size = new System.Drawing.Size(112, 51);
            this.btnValiderIndic.TabIndex = 8;
            this.btnValiderIndic.Text = "Valider";
            this.btnValiderIndic.UseVisualStyleBackColor = true;
            this.btnValiderIndic.Click += new System.EventHandler(this.btnValiderIndic_Click);
            // 
            // cmbINomIndic
            // 
            this.cmbINomIndic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbINomIndic.FormattingEnabled = true;
            this.cmbINomIndic.Location = new System.Drawing.Point(136, 443);
            this.cmbINomIndic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbINomIndic.Name = "cmbINomIndic";
            this.cmbINomIndic.Size = new System.Drawing.Size(248, 30);
            this.cmbINomIndic.TabIndex = 7;
            // 
            // lblNomIndic
            // 
            this.lblNomIndic.AutoSize = true;
            this.lblNomIndic.Location = new System.Drawing.Point(16, 445);
            this.lblNomIndic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomIndic.Name = "lblNomIndic";
            this.lblNomIndic.Size = new System.Drawing.Size(100, 22);
            this.lblNomIndic.TabIndex = 6;
            this.lblNomIndic.Text = "Informateur";
            // 
            // txtAppreciationIndic
            // 
            this.txtAppreciationIndic.Location = new System.Drawing.Point(16, 227);
            this.txtAppreciationIndic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAppreciationIndic.Multiline = true;
            this.txtAppreciationIndic.Name = "txtAppreciationIndic";
            this.txtAppreciationIndic.Size = new System.Drawing.Size(392, 177);
            this.txtAppreciationIndic.TabIndex = 5;
            // 
            // lblAppreciationIndic
            // 
            this.lblAppreciationIndic.AutoSize = true;
            this.lblAppreciationIndic.Location = new System.Drawing.Point(12, 172);
            this.lblAppreciationIndic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppreciationIndic.Name = "lblAppreciationIndic";
            this.lblAppreciationIndic.Size = new System.Drawing.Size(110, 22);
            this.lblAppreciationIndic.TabIndex = 4;
            this.lblAppreciationIndic.Text = "Appréciation";
            // 
            // txtSoudoiementIndic
            // 
            this.txtSoudoiementIndic.Location = new System.Drawing.Point(226, 97);
            this.txtSoudoiementIndic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSoudoiementIndic.Name = "txtSoudoiementIndic";
            this.txtSoudoiementIndic.Size = new System.Drawing.Size(84, 28);
            this.txtSoudoiementIndic.TabIndex = 3;
            this.txtSoudoiementIndic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnlyField_KeyPress);
            // 
            // lblSommeIndic
            // 
            this.lblSommeIndic.AutoSize = true;
            this.lblSommeIndic.Location = new System.Drawing.Point(12, 97);
            this.lblSommeIndic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSommeIndic.Name = "lblSommeIndic";
            this.lblSommeIndic.Size = new System.Drawing.Size(180, 22);
            this.lblSommeIndic.TabIndex = 2;
            this.lblSommeIndic.Text = "Somme Soudoiement";
            // 
            // dtIndic
            // 
            this.dtIndic.Location = new System.Drawing.Point(126, 33);
            this.dtIndic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtIndic.Name = "dtIndic";
            this.dtIndic.Size = new System.Drawing.Size(258, 28);
            this.dtIndic.TabIndex = 1;
            // 
            // lblDateIndic
            // 
            this.lblDateIndic.AutoSize = true;
            this.lblDateIndic.Location = new System.Drawing.Point(22, 33);
            this.lblDateIndic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateIndic.Name = "lblDateIndic";
            this.lblDateIndic.Size = new System.Drawing.Size(48, 22);
            this.lblDateIndic.TabIndex = 0;
            this.lblDateIndic.Text = "Date";
            // 
            // tabNouvelleDepense
            // 
            this.tabNouvelleDepense.Controls.Add(this.btnValiderDepense);
            this.tabNouvelleDepense.Controls.Add(this.cmbIdDepense);
            this.tabNouvelleDepense.Controls.Add(this.lblIdDepense);
            this.tabNouvelleDepense.Controls.Add(this.txtMotifDepense);
            this.tabNouvelleDepense.Controls.Add(this.lblMotifDepense);
            this.tabNouvelleDepense.Controls.Add(this.txtMontantDepense);
            this.tabNouvelleDepense.Controls.Add(this.lblDepense);
            this.tabNouvelleDepense.Controls.Add(this.dtDepense);
            this.tabNouvelleDepense.Controls.Add(this.lblDtDepense);
            this.tabNouvelleDepense.Location = new System.Drawing.Point(4, 31);
            this.tabNouvelleDepense.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabNouvelleDepense.Name = "tabNouvelleDepense";
            this.tabNouvelleDepense.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabNouvelleDepense.Size = new System.Drawing.Size(424, 613);
            this.tabNouvelleDepense.TabIndex = 1;
            this.tabNouvelleDepense.Text = "NouvelleDepense";
            this.tabNouvelleDepense.UseVisualStyleBackColor = true;
            // 
            // btnValiderDepense
            // 
            this.btnValiderDepense.Location = new System.Drawing.Point(298, 539);
            this.btnValiderDepense.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnValiderDepense.Name = "btnValiderDepense";
            this.btnValiderDepense.Size = new System.Drawing.Size(112, 51);
            this.btnValiderDepense.TabIndex = 17;
            this.btnValiderDepense.Text = "Valider";
            this.btnValiderDepense.UseVisualStyleBackColor = true;
            this.btnValiderDepense.Click += new System.EventHandler(this.btnValiderDepense_Click);
            // 
            // cmbIdDepense
            // 
            this.cmbIdDepense.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdDepense.FormattingEnabled = true;
            this.cmbIdDepense.Location = new System.Drawing.Point(139, 434);
            this.cmbIdDepense.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbIdDepense.Name = "cmbIdDepense";
            this.cmbIdDepense.Size = new System.Drawing.Size(248, 30);
            this.cmbIdDepense.TabIndex = 16;
            // 
            // lblIdDepense
            // 
            this.lblIdDepense.AutoSize = true;
            this.lblIdDepense.Location = new System.Drawing.Point(19, 436);
            this.lblIdDepense.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdDepense.Name = "lblIdDepense";
            this.lblIdDepense.Size = new System.Drawing.Size(125, 22);
            this.lblIdDepense.TabIndex = 15;
            this.lblIdDepense.Text = "Type dépense";
            // 
            // txtMotifDepense
            // 
            this.txtMotifDepense.Location = new System.Drawing.Point(19, 218);
            this.txtMotifDepense.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMotifDepense.Multiline = true;
            this.txtMotifDepense.Name = "txtMotifDepense";
            this.txtMotifDepense.Size = new System.Drawing.Size(392, 177);
            this.txtMotifDepense.TabIndex = 14;
            // 
            // lblMotifDepense
            // 
            this.lblMotifDepense.AutoSize = true;
            this.lblMotifDepense.Location = new System.Drawing.Point(15, 164);
            this.lblMotifDepense.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotifDepense.Name = "lblMotifDepense";
            this.lblMotifDepense.Size = new System.Drawing.Size(125, 22);
            this.lblMotifDepense.TabIndex = 13;
            this.lblMotifDepense.Text = "Motif Dépense";
            // 
            // txtMontantDepense
            // 
            this.txtMontantDepense.Location = new System.Drawing.Point(229, 88);
            this.txtMontantDepense.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMontantDepense.Name = "txtMontantDepense";
            this.txtMontantDepense.Size = new System.Drawing.Size(84, 28);
            this.txtMontantDepense.TabIndex = 12;
            // 
            // lblDepense
            // 
            this.lblDepense.AutoSize = true;
            this.lblDepense.Location = new System.Drawing.Point(15, 88);
            this.lblDepense.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepense.Name = "lblDepense";
            this.lblDepense.Size = new System.Drawing.Size(148, 22);
            this.lblDepense.TabIndex = 11;
            this.lblDepense.Text = "Montant dépense";
            // 
            // dtDepense
            // 
            this.dtDepense.Location = new System.Drawing.Point(129, 25);
            this.dtDepense.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtDepense.Name = "dtDepense";
            this.dtDepense.Size = new System.Drawing.Size(258, 28);
            this.dtDepense.TabIndex = 10;
            // 
            // lblDtDepense
            // 
            this.lblDtDepense.AutoSize = true;
            this.lblDtDepense.Location = new System.Drawing.Point(25, 25);
            this.lblDtDepense.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDtDepense.Name = "lblDtDepense";
            this.lblDtDepense.Size = new System.Drawing.Size(48, 22);
            this.lblDtDepense.TabIndex = 9;
            this.lblDtDepense.Text = "Date";
            // 
            // tabNouvelEvenement
            // 
            this.tabNouvelEvenement.Controls.Add(this.btnValiderNouvelEvent);
            this.tabNouvelEvenement.Controls.Add(this.txtNouvelEvent);
            this.tabNouvelEvenement.Controls.Add(this.label1);
            this.tabNouvelEvenement.Controls.Add(this.dtNouvelEvent);
            this.tabNouvelEvenement.Controls.Add(this.lblDtNouvelEvent);
            this.tabNouvelEvenement.Location = new System.Drawing.Point(4, 31);
            this.tabNouvelEvenement.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabNouvelEvenement.Name = "tabNouvelEvenement";
            this.tabNouvelEvenement.Size = new System.Drawing.Size(424, 613);
            this.tabNouvelEvenement.TabIndex = 2;
            this.tabNouvelEvenement.Text = "Nouvel évènement";
            this.tabNouvelEvenement.UseVisualStyleBackColor = true;
            // 
            // btnValiderNouvelEvent
            // 
            this.btnValiderNouvelEvent.Location = new System.Drawing.Point(299, 545);
            this.btnValiderNouvelEvent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnValiderNouvelEvent.Name = "btnValiderNouvelEvent";
            this.btnValiderNouvelEvent.Size = new System.Drawing.Size(112, 51);
            this.btnValiderNouvelEvent.TabIndex = 18;
            this.btnValiderNouvelEvent.Text = "Valider";
            this.btnValiderNouvelEvent.UseVisualStyleBackColor = true;
            this.btnValiderNouvelEvent.Click += new System.EventHandler(this.btnValiderNouvelEvent_Click);
            // 
            // txtNouvelEvent
            // 
            this.txtNouvelEvent.Location = new System.Drawing.Point(19, 147);
            this.txtNouvelEvent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNouvelEvent.Multiline = true;
            this.txtNouvelEvent.Name = "txtNouvelEvent";
            this.txtNouvelEvent.Size = new System.Drawing.Size(392, 177);
            this.txtNouvelEvent.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Commentaire";
            // 
            // dtNouvelEvent
            // 
            this.dtNouvelEvent.Location = new System.Drawing.Point(129, 27);
            this.dtNouvelEvent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtNouvelEvent.Name = "dtNouvelEvent";
            this.dtNouvelEvent.Size = new System.Drawing.Size(258, 28);
            this.dtNouvelEvent.TabIndex = 12;
            // 
            // lblDtNouvelEvent
            // 
            this.lblDtNouvelEvent.AutoSize = true;
            this.lblDtNouvelEvent.Location = new System.Drawing.Point(25, 27);
            this.lblDtNouvelEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDtNouvelEvent.Name = "lblDtNouvelEvent";
            this.lblDtNouvelEvent.Size = new System.Drawing.Size(48, 22);
            this.lblDtNouvelEvent.TabIndex = 11;
            this.lblDtNouvelEvent.Text = "Date";
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Location = new System.Drawing.Point(144, 10);
            this.lblMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(70, 22);
            this.lblMission.TabIndex = 1;
            this.lblMission.Text = "Mission";
            // 
            // lblDtDepart
            // 
            this.lblDtDepart.AutoSize = true;
            this.lblDtDepart.Location = new System.Drawing.Point(28, 73);
            this.lblDtDepart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDtDepart.Name = "lblDtDepart";
            this.lblDtDepart.Size = new System.Drawing.Size(58, 22);
            this.lblDtDepart.TabIndex = 2;
            this.lblDtDepart.Text = "label1";
            // 
            // lblDtRetour
            // 
            this.lblDtRetour.AutoSize = true;
            this.lblDtRetour.Location = new System.Drawing.Point(28, 103);
            this.lblDtRetour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDtRetour.Name = "lblDtRetour";
            this.lblDtRetour.Size = new System.Drawing.Size(58, 22);
            this.lblDtRetour.TabIndex = 3;
            this.lblDtRetour.Text = "label1";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(294, 73);
            this.lblBudget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(58, 22);
            this.lblBudget.TabIndex = 4;
            this.lblBudget.Text = "label1";
            // 
            // lblBudgetApresDepenses
            // 
            this.lblBudgetApresDepenses.AutoSize = true;
            this.lblBudgetApresDepenses.Location = new System.Drawing.Point(294, 103);
            this.lblBudgetApresDepenses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBudgetApresDepenses.Name = "lblBudgetApresDepenses";
            this.lblBudgetApresDepenses.Size = new System.Drawing.Size(58, 22);
            this.lblBudgetApresDepenses.TabIndex = 5;
            this.lblBudgetApresDepenses.Text = "label1";
            // 
            // grpFeuilleDeRoute
            // 
            this.grpFeuilleDeRoute.Controls.Add(this.txtFeuilleDeRoute);
            this.grpFeuilleDeRoute.Location = new System.Drawing.Point(32, 146);
            this.grpFeuilleDeRoute.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpFeuilleDeRoute.Name = "grpFeuilleDeRoute";
            this.grpFeuilleDeRoute.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpFeuilleDeRoute.Size = new System.Drawing.Size(467, 156);
            this.grpFeuilleDeRoute.TabIndex = 6;
            this.grpFeuilleDeRoute.TabStop = false;
            this.grpFeuilleDeRoute.Text = "Feuille de Route";
            // 
            // txtFeuilleDeRoute
            // 
            this.txtFeuilleDeRoute.Location = new System.Drawing.Point(17, 27);
            this.txtFeuilleDeRoute.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFeuilleDeRoute.Multiline = true;
            this.txtFeuilleDeRoute.Name = "txtFeuilleDeRoute";
            this.txtFeuilleDeRoute.ReadOnly = true;
            this.txtFeuilleDeRoute.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFeuilleDeRoute.Size = new System.Drawing.Size(438, 110);
            this.txtFeuilleDeRoute.TabIndex = 0;
            // 
            // grpMembresEquipe
            // 
            this.grpMembresEquipe.Controls.Add(this.pnlMembres);
            this.grpMembresEquipe.Location = new System.Drawing.Point(32, 338);
            this.grpMembresEquipe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpMembresEquipe.Name = "grpMembresEquipe";
            this.grpMembresEquipe.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpMembresEquipe.Size = new System.Drawing.Size(467, 157);
            this.grpMembresEquipe.TabIndex = 7;
            this.grpMembresEquipe.TabStop = false;
            this.grpMembresEquipe.Text = "Membres de l\'équipage";
            // 
            // pnlMembres
            // 
            this.pnlMembres.AutoScroll = true;
            this.pnlMembres.Location = new System.Drawing.Point(5, 27);
            this.pnlMembres.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlMembres.Name = "pnlMembres";
            this.pnlMembres.Size = new System.Drawing.Size(450, 124);
            this.pnlMembres.TabIndex = 0;
            // 
            // grpCapture
            // 
            this.grpCapture.Controls.Add(this.pnlCapture);
            this.grpCapture.Location = new System.Drawing.Point(32, 524);
            this.grpCapture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpCapture.Name = "grpCapture";
            this.grpCapture.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpCapture.Size = new System.Drawing.Size(345, 131);
            this.grpCapture.TabIndex = 0;
            this.grpCapture.TabStop = false;
            this.grpCapture.Text = "Objectifs de Capture";
            // 
            // pnlCapture
            // 
            this.pnlCapture.AutoScroll = true;
            this.pnlCapture.Location = new System.Drawing.Point(5, 27);
            this.pnlCapture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlCapture.Name = "pnlCapture";
            this.pnlCapture.Size = new System.Drawing.Size(335, 99);
            this.pnlCapture.TabIndex = 0;
            // 
            // btnJournal
            // 
            this.btnJournal.Location = new System.Drawing.Point(404, 533);
            this.btnJournal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnJournal.Name = "btnJournal";
            this.btnJournal.Size = new System.Drawing.Size(95, 44);
            this.btnJournal.TabIndex = 8;
            this.btnJournal.Text = "Journal";
            this.btnJournal.UseVisualStyleBackColor = true;
            this.btnJournal.Click += new System.EventHandler(this.btnJournal_Click);
            // 
            // frmFicheMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 679);
            this.Controls.Add(this.btnJournal);
            this.Controls.Add(this.grpCapture);
            this.Controls.Add(this.grpMembresEquipe);
            this.Controls.Add(this.grpFeuilleDeRoute);
            this.Controls.Add(this.lblBudgetApresDepenses);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblDtRetour);
            this.Controls.Add(this.lblDtDepart);
            this.Controls.Add(this.lblMission);
            this.Controls.Add(this.tabCtrlEdition);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmFicheMission";
            this.Text = "frmFicheMission";
            this.Load += new System.EventHandler(this.frmFicheMission_Load);
            this.tabCtrlEdition.ResumeLayout(false);
            this.tabNouveauContact.ResumeLayout(false);
            this.tabNouveauContact.PerformLayout();
            this.tabNouvelleDepense.ResumeLayout(false);
            this.tabNouvelleDepense.PerformLayout();
            this.tabNouvelEvenement.ResumeLayout(false);
            this.tabNouvelEvenement.PerformLayout();
            this.grpFeuilleDeRoute.ResumeLayout(false);
            this.grpFeuilleDeRoute.PerformLayout();
            this.grpMembresEquipe.ResumeLayout(false);
            this.grpCapture.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlEdition;
        private System.Windows.Forms.TabPage tabNouveauContact;
        private System.Windows.Forms.TabPage tabNouvelleDepense;
        private System.Windows.Forms.TabPage tabNouvelEvenement;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.Label lblDtDepart;
        private System.Windows.Forms.Label lblDtRetour;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblBudgetApresDepenses;
        private System.Windows.Forms.GroupBox grpFeuilleDeRoute;
        private System.Windows.Forms.GroupBox grpMembresEquipe;
        private System.Windows.Forms.Panel pnlMembres;
        private System.Windows.Forms.GroupBox grpCapture;
        private System.Windows.Forms.Panel pnlCapture;
        private System.Windows.Forms.Button btnJournal;
        private System.Windows.Forms.Label lblSommeIndic;
        private System.Windows.Forms.DateTimePicker dtIndic;
        private System.Windows.Forms.Label lblDateIndic;
        private System.Windows.Forms.TextBox txtSoudoiementIndic;
        private System.Windows.Forms.Button btnValiderIndic;
        private System.Windows.Forms.ComboBox cmbINomIndic;
        private System.Windows.Forms.Label lblNomIndic;
        private System.Windows.Forms.TextBox txtAppreciationIndic;
        private System.Windows.Forms.Label lblAppreciationIndic;
        private System.Windows.Forms.Button btnValiderDepense;
        private System.Windows.Forms.ComboBox cmbIdDepense;
        private System.Windows.Forms.Label lblIdDepense;
        private System.Windows.Forms.TextBox txtMotifDepense;
        private System.Windows.Forms.Label lblMotifDepense;
        private System.Windows.Forms.TextBox txtMontantDepense;
        private System.Windows.Forms.Label lblDepense;
        private System.Windows.Forms.DateTimePicker dtDepense;
        private System.Windows.Forms.Label lblDtDepense;
        private System.Windows.Forms.TextBox txtFeuilleDeRoute;
        private System.Windows.Forms.DateTimePicker dtNouvelEvent;
        private System.Windows.Forms.Label lblDtNouvelEvent;
        private System.Windows.Forms.Button btnValiderNouvelEvent;
        private System.Windows.Forms.TextBox txtNouvelEvent;
        private System.Windows.Forms.Label label1;
    }
}