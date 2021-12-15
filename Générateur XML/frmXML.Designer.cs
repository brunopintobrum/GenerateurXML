namespace WindowsFormsApp2
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
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.btnLire = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.StyleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.StyleManagerAmbient1 = new DevComponents.DotNetBar.StyleManagerAmbient(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx5 = new DevComponents.DotNetBar.PanelEx();
            this.metroStatusBar = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lblStatusBar = new DevComponents.DotNetBar.LabelItem();
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
            resources.ApplyResources(this.panelEx1, "panelEx1");
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            // 
            // PanelEx2
            // 
            this.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelEx2.Controls.Add(this.panelEx3);
            this.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.PanelEx2, "PanelEx2");
            this.PanelEx2.Name = "PanelEx2";
            this.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx2.Style.GradientAngle = 90;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.btnLire);
            this.panelEx3.Controls.Add(this.btnEnregistrer);
            this.panelEx3.Controls.Add(this.checkBox1);
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
            resources.ApplyResources(this.panelEx3, "panelEx3");
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            // 
            // btnLire
            // 
            resources.ApplyResources(this.btnLire, "btnLire");
            this.btnLire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnLire.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnLire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnLire.Name = "btnLire";
            this.btnLire.UseVisualStyleBackColor = false;
            this.btnLire.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnEnregistrer
            // 
            resources.ApplyResources(this.btnEnregistrer, "btnEnregistrer");
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnEnregistrer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnEnregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ckbNouveau
            // 
            resources.ApplyResources(this.ckbNouveau, "ckbNouveau");
            this.ckbNouveau.Name = "ckbNouveau";
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
            resources.ApplyResources(this.txtCodeInstallation, "txtCodeInstallation");
            this.txtCodeInstallation.Name = "txtCodeInstallation";
            this.txtCodeInstallation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // cboOrdinateur
            // 
            this.cboOrdinateur.DisplayMember = "Text";
            this.cboOrdinateur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboOrdinateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboOrdinateur, "cboOrdinateur");
            this.cboOrdinateur.ForeColor = System.Drawing.Color.Black;
            this.cboOrdinateur.FormattingEnabled = true;
            this.cboOrdinateur.Items.AddRange(new object[] {
            this.SERVEUR,
            this.STATION});
            this.cboOrdinateur.Name = "cboOrdinateur";
            this.cboOrdinateur.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // SERVEUR
            // 
            resources.ApplyResources(this.SERVEUR, "SERVEUR");
            // 
            // STATION
            // 
            resources.ApplyResources(this.STATION, "STATION");
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
            resources.ApplyResources(this.txtIP, "txtIP");
            this.txtIP.ForeColor = System.Drawing.Color.Black;
            this.txtIP.Name = "txtIP";
            this.txtIP.PreventEnterBeep = true;
            // 
            // lblIP
            // 
            resources.ApplyResources(this.lblIP, "lblIP");
            // 
            // 
            // 
            this.lblIP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblIP.Name = "lblIP";
            // 
            // lblStation
            // 
            resources.ApplyResources(this.lblStation, "lblStation");
            // 
            // 
            // 
            this.lblStation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblStation.Name = "lblStation";
            // 
            // lblCodeInstallation
            // 
            resources.ApplyResources(this.lblCodeInstallation, "lblCodeInstallation");
            // 
            // 
            // 
            this.lblCodeInstallation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCodeInstallation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblCodeInstallation.Name = "lblCodeInstallation";
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
            resources.ApplyResources(this.txtStation, "txtStation");
            this.txtStation.ForeColor = System.Drawing.Color.Black;
            this.txtStation.Name = "txtStation";
            this.txtStation.PreventEnterBeep = true;
            // 
            // lblOrdinateur
            // 
            resources.ApplyResources(this.lblOrdinateur, "lblOrdinateur");
            // 
            // 
            // 
            this.lblOrdinateur.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblOrdinateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblOrdinateur.Name = "lblOrdinateur";
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
            resources.ApplyResources(this.lblTitre, "lblTitre");
            this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitre.Name = "lblTitre";
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
            resources.ApplyResources(this.Highlighter1, "Highlighter1");
            this.Highlighter1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // StyleManager1
            // 
            this.StyleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.OfficeMobile2014;
            this.StyleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230))))));
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
            resources.ApplyResources(this.bindingNavigator1, "bindingNavigator1");
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx4.Controls.Add(this.panelEx5);
            this.panelEx4.Controls.Add(this.bindingNavigator1);
            this.panelEx4.DisabledBackColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.panelEx4, "panelEx4");
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelEx4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            // 
            // panelEx5
            // 
            this.panelEx5.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx5.Controls.Add(this.metroStatusBar);
            this.panelEx5.Controls.Add(this.panelEx1);
            this.panelEx5.DisabledBackColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.panelEx5, "panelEx5");
            this.panelEx5.Name = "panelEx5";
            this.panelEx5.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx5.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelEx5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx5.Style.GradientAngle = 90;
            // 
            // metroStatusBar
            // 
            // 
            // 
            // 
            this.metroStatusBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar.ContainerControlProcessDialogKey = true;
            resources.ApplyResources(this.metroStatusBar, "metroStatusBar");
            this.metroStatusBar.DragDropSupport = true;
            this.metroStatusBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblStatusBar});
            this.metroStatusBar.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.metroStatusBar.Name = "metroStatusBar";
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frmXML
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx4);
            this.Name = "frmXML";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelEx1.ResumeLayout(false);
            this.PanelEx2.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnLire;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar;
        private DevComponents.DotNetBar.LabelItem lblStatusBar;
    }
}

