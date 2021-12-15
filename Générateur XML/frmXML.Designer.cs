namespace GenerateurXML
{
    partial class frmXML
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXML));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.PanelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnLire = new System.Windows.Forms.Button();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.ckbTS = new System.Windows.Forms.CheckBox();
            this.ckbNouveau = new System.Windows.Forms.CheckBox();
            this.txtCodeInstallation = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.cboOrdinateur = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.SERVEUR = new DevComponents.Editors.ComboItem();
            this.STATION = new DevComponents.Editors.ComboItem();
            this.txtIP = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblIP = new DevComponents.DotNetBar.LabelX();
            this.lblStation = new DevComponents.DotNetBar.LabelX();
            this.lblCodeInstallation = new DevComponents.DotNetBar.LabelX();
            this.txtStation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblOrdinateur = new DevComponents.DotNetBar.LabelX();
            this.lblTitre = new DevComponents.DotNetBar.LabelX();
            this.Highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx5 = new DevComponents.DotNetBar.PanelEx();
            this.metroStatusBar = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lblStatusBar = new DevComponents.DotNetBar.LabelItem();
            this.StyleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.StyleManagerAmbient1 = new DevComponents.DotNetBar.StyleManagerAmbient(this.components);
            this.panelEx1.SuspendLayout();
            this.PanelEx2.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panelEx4.SuspendLayout();
            this.panelEx5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.PanelEx2);
            this.panelEx1.Controls.Add(this.lblTitre);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(5, 5);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(734, 264);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // PanelEx2
            // 
            this.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelEx2.Controls.Add(this.btnEnregistrer);
            this.PanelEx2.Controls.Add(this.btnLire);
            this.PanelEx2.Controls.Add(this.panelEx3);
            this.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEx2.Location = new System.Drawing.Point(0, 32);
            this.PanelEx2.Name = "PanelEx2";
            this.PanelEx2.Padding = new System.Windows.Forms.Padding(1);
            this.PanelEx2.Size = new System.Drawing.Size(734, 232);
            this.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx2.Style.GradientAngle = 90;
            this.PanelEx2.TabIndex = 952;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.AutoSize = true;
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnEnregistrer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnEnregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEnregistrer.Location = new System.Drawing.Point(531, 51);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(177, 29);
            this.btnEnregistrer.TabIndex = 953;
            this.btnEnregistrer.Text = "Enregistrer le fichier XML";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnLire
            // 
            this.btnLire.AutoSize = true;
            this.btnLire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnLire.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnLire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnLire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLire.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLire.Location = new System.Drawing.Point(531, 16);
            this.btnLire.Name = "btnLire";
            this.btnLire.Size = new System.Drawing.Size(177, 29);
            this.btnLire.TabIndex = 953;
            this.btnLire.Text = "Charger le fichier XML";
            this.btnLire.UseVisualStyleBackColor = false;
            this.btnLire.Click += new System.EventHandler(this.btnLire_Click);
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.ckbTS);
            this.panelEx3.Controls.Add(this.ckbNouveau);
            this.panelEx3.Controls.Add(this.txtCodeInstallation);
            this.panelEx3.Controls.Add(this.cboOrdinateur);
            this.panelEx3.Controls.Add(this.txtIP);
            this.panelEx3.Controls.Add(this.lblIP);
            this.panelEx3.Controls.Add(this.lblStation);
            this.panelEx3.Controls.Add(this.lblCodeInstallation);
            this.panelEx3.Controls.Add(this.txtStation);
            this.panelEx3.Controls.Add(this.lblOrdinateur);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Location = new System.Drawing.Point(12, 16);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Padding = new System.Windows.Forms.Padding(1);
            this.panelEx3.Size = new System.Drawing.Size(494, 201);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 952;
            // 
            // ckbTS
            // 
            this.ckbTS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.ckbTS.Location = new System.Drawing.Point(326, 160);
            this.ckbTS.Name = "ckbTS";
            this.ckbTS.Size = new System.Drawing.Size(104, 24);
            this.ckbTS.TabIndex = 13;
            this.ckbTS.Text = "0 = TS";
            this.ckbTS.UseVisualStyleBackColor = true;
            // 
            // ckbNouveau
            // 
            this.ckbNouveau.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.ckbNouveau.Location = new System.Drawing.Point(189, 160);
            this.ckbNouveau.Name = "ckbNouveau";
            this.ckbNouveau.Size = new System.Drawing.Size(125, 24);
            this.ckbNouveau.TabIndex = 13;
            this.ckbNouveau.Text = "Nouveau = -1";
            this.ckbNouveau.UseVisualStyleBackColor = true;
            // 
            // txtCodeInstallation
            // 
            // 
            // 
            // 
            this.txtCodeInstallation.BackgroundStyle.Class = "TextBoxBorder";
            this.txtCodeInstallation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodeInstallation.ButtonClear.Visible = true;
            this.txtCodeInstallation.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCodeInstallation.Location = new System.Drawing.Point(189, 88);
            this.txtCodeInstallation.Mask = "00.00.00.00";
            this.txtCodeInstallation.Name = "txtCodeInstallation";
            this.txtCodeInstallation.Size = new System.Drawing.Size(286, 27);
            this.txtCodeInstallation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtCodeInstallation.TabIndex = 12;
            this.txtCodeInstallation.Text = "";
            // 
            // cboOrdinateur
            // 
            this.cboOrdinateur.DisplayMember = "Text";
            this.cboOrdinateur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboOrdinateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdinateur.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cboOrdinateur.ForeColor = System.Drawing.Color.Black;
            this.cboOrdinateur.FormattingEnabled = true;
            this.cboOrdinateur.ItemHeight = 21;
            this.cboOrdinateur.Items.AddRange(new object[] {
            this.SERVEUR,
            this.STATION});
            this.cboOrdinateur.Location = new System.Drawing.Point(189, 52);
            this.cboOrdinateur.Name = "cboOrdinateur";
            this.cboOrdinateur.Size = new System.Drawing.Size(286, 27);
            this.cboOrdinateur.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboOrdinateur.TabIndex = 11;
            // 
            // SERVEUR
            // 
            this.SERVEUR.Text = "SERVEUR";
            // 
            // STATION
            // 
            this.STATION.Text = "STATION";
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtIP.Border.Class = "TextBoxBorder";
            this.txtIP.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIP.DisabledBackColor = System.Drawing.Color.White;
            this.txtIP.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtIP.ForeColor = System.Drawing.Color.Black;
            this.txtIP.Location = new System.Drawing.Point(189, 16);
            this.txtIP.Name = "txtIP";
            this.txtIP.PreventEnterBeep = true;
            this.txtIP.Size = new System.Drawing.Size(286, 27);
            this.txtIP.TabIndex = 7;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            // 
            // 
            // 
            this.lblIP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblIP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblIP.Location = new System.Drawing.Point(20, 18);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(83, 22);
            this.lblIP.TabIndex = 6;
            this.lblIP.Text = "Numéro IP:";
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            // 
            // 
            // 
            this.lblStation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblStation.Location = new System.Drawing.Point(20, 126);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(155, 22);
            this.lblStation.TabIndex = 3;
            this.lblStation.Text = "Numéro de la station:";
            // 
            // lblCodeInstallation
            // 
            this.lblCodeInstallation.AutoSize = true;
            // 
            // 
            // 
            this.lblCodeInstallation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCodeInstallation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCodeInstallation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblCodeInstallation.Location = new System.Drawing.Point(20, 90);
            this.lblCodeInstallation.Name = "lblCodeInstallation";
            this.lblCodeInstallation.Size = new System.Drawing.Size(139, 22);
            this.lblCodeInstallation.TabIndex = 5;
            this.lblCodeInstallation.Text = "Code d\'installation:";
            // 
            // txtStation
            // 
            this.txtStation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtStation.Border.Class = "TextBoxBorder";
            this.txtStation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStation.DisabledBackColor = System.Drawing.Color.White;
            this.txtStation.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtStation.ForeColor = System.Drawing.Color.Black;
            this.txtStation.Location = new System.Drawing.Point(189, 124);
            this.txtStation.Name = "txtStation";
            this.txtStation.PreventEnterBeep = true;
            this.txtStation.Size = new System.Drawing.Size(286, 27);
            this.txtStation.TabIndex = 8;
            // 
            // lblOrdinateur
            // 
            this.lblOrdinateur.AutoSize = true;
            // 
            // 
            // 
            this.lblOrdinateur.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblOrdinateur.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblOrdinateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblOrdinateur.Location = new System.Drawing.Point(20, 54);
            this.lblOrdinateur.Name = "lblOrdinateur";
            this.lblOrdinateur.Size = new System.Drawing.Size(84, 22);
            this.lblOrdinateur.TabIndex = 4;
            this.lblOrdinateur.Text = "Ordinateur:";
            // 
            // lblTitre
            // 
            this.lblTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblTitre.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.lblTitre.BackgroundStyle.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblTitre.BackgroundStyle.BorderBottomWidth = 1;
            this.lblTitre.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.lblTitre.BackgroundStyle.BorderLeftWidth = 1;
            this.lblTitre.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.lblTitre.BackgroundStyle.BorderRightWidth = 1;
            this.lblTitre.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.lblTitre.BackgroundStyle.BorderTopWidth = 1;
            this.lblTitre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitre.Location = new System.Drawing.Point(0, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(734, 32);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Gestion du fichier XML";
            this.lblTitre.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Highlighter1
            // 
            this.Highlighter1.CustomHighlightColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(203)))), ((int)(((byte)(233))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(186)))), ((int)(((byte)(217))))),
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty};
            this.Highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Custom;
            this.Highlighter1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(1, 1);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(748, 39);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.ToolTipText = "Quitter";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx4.Controls.Add(this.panelEx5);
            this.panelEx4.Controls.Add(this.bindingNavigator1);
            this.panelEx4.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx4.Location = new System.Drawing.Point(0, 0);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Padding = new System.Windows.Forms.Padding(1);
            this.panelEx4.Size = new System.Drawing.Size(750, 340);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelEx4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 952;
            // 
            // panelEx5
            // 
            this.panelEx5.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx5.Controls.Add(this.metroStatusBar);
            this.panelEx5.Controls.Add(this.panelEx1);
            this.panelEx5.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx5.Location = new System.Drawing.Point(1, 40);
            this.panelEx5.Name = "panelEx5";
            this.panelEx5.Padding = new System.Windows.Forms.Padding(5);
            this.panelEx5.Size = new System.Drawing.Size(748, 299);
            this.panelEx5.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx5.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelEx5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx5.Style.GradientAngle = 90;
            this.panelEx5.TabIndex = 952;
            // 
            // metroStatusBar
            // 
            // 
            // 
            // 
            this.metroStatusBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar.ContainerControlProcessDialogKey = true;
            this.metroStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar.DragDropSupport = true;
            this.metroStatusBar.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.metroStatusBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblStatusBar});
            this.metroStatusBar.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.metroStatusBar.Location = new System.Drawing.Point(5, 272);
            this.metroStatusBar.Name = "metroStatusBar";
            this.metroStatusBar.Size = new System.Drawing.Size(738, 22);
            this.metroStatusBar.TabIndex = 2;
            this.metroStatusBar.Text = "metroStatusBar1";
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(53)))), ((int)(((byte)(93)))));
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // StyleManager1
            // 
            this.StyleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.OfficeMobile2014;
            this.StyleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230))))));
            // 
            // frmXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 340);
            this.Controls.Add(this.panelEx4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXML";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion du fichier XML";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelEx1.ResumeLayout(false);
            this.PanelEx2.ResumeLayout(false);
            this.PanelEx2.PerformLayout();
            this.panelEx3.ResumeLayout(false);
            this.panelEx3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panelEx4.ResumeLayout(false);
            this.panelEx4.PerformLayout();
            this.panelEx5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX lblTitre;
        internal DevComponents.DotNetBar.Validator.Highlighter Highlighter1;
        internal DevComponents.DotNetBar.StyleManager StyleManager1;
        internal DevComponents.DotNetBar.StyleManagerAmbient StyleManagerAmbient1;
        internal DevComponents.DotNetBar.PanelEx PanelEx2;
        private DevComponents.DotNetBar.LabelX lblIP;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIP;
        private DevComponents.DotNetBar.LabelX lblCodeInstallation;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStation;
        private DevComponents.DotNetBar.LabelX lblOrdinateur;
        private DevComponents.DotNetBar.LabelX lblStation;
        internal DevComponents.DotNetBar.PanelEx panelEx3;
        private System.Windows.Forms.Button btnEnregistrer;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboOrdinateur;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        internal DevComponents.DotNetBar.PanelEx panelEx4;
        internal DevComponents.DotNetBar.PanelEx panelEx5;
        private DevComponents.Editors.ComboItem SERVEUR;
        private DevComponents.Editors.ComboItem STATION;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txtCodeInstallation;
        private System.Windows.Forms.CheckBox ckbNouveau;
        private System.Windows.Forms.CheckBox ckbTS;
        private System.Windows.Forms.Button btnLire;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar;
        private DevComponents.DotNetBar.LabelItem lblStatusBar;
    }
}

