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
            this.lblTitre = new DevComponents.DotNetBar.LabelX();
            this.Highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.StyleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.StyleManagerAmbient1 = new DevComponents.DotNetBar.StyleManagerAmbient(this.components);
            this.txtIP = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtStation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCodeInstallation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtOrdinateur = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblStation = new DevComponents.DotNetBar.LabelX();
            this.lblOrdinateur = new DevComponents.DotNetBar.LabelX();
            this.lblCodeInstalation = new DevComponents.DotNetBar.LabelX();
            this.lblIP = new DevComponents.DotNetBar.LabelX();
            this.PanelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.panelEx1.SuspendLayout();
            this.PanelEx2.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.PanelEx2);
            this.panelEx1.Controls.Add(this.lblTitre);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(506, 273);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
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
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitre.Location = new System.Drawing.Point(0, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(506, 32);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Générateur de fichier XML.";
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
            // StyleManager1
            // 
            this.StyleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.OfficeMobile2014;
            this.StyleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230))))));
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
            this.txtIP.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.ForeColor = System.Drawing.Color.Black;
            this.txtIP.Location = new System.Drawing.Point(183, 13);
            this.txtIP.Name = "txtIP";
            this.txtIP.PreventEnterBeep = true;
            this.txtIP.Size = new System.Drawing.Size(286, 27);
            this.txtIP.TabIndex = 7;
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
            this.txtStation.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStation.ForeColor = System.Drawing.Color.Black;
            this.txtStation.Location = new System.Drawing.Point(183, 127);
            this.txtStation.Name = "txtStation";
            this.txtStation.PreventEnterBeep = true;
            this.txtStation.Size = new System.Drawing.Size(286, 27);
            this.txtStation.TabIndex = 8;
            // 
            // lblCodeInstallation
            // 
            this.lblCodeInstallation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblCodeInstallation.Border.Class = "TextBoxBorder";
            this.lblCodeInstallation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCodeInstallation.DisabledBackColor = System.Drawing.Color.White;
            this.lblCodeInstallation.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeInstallation.ForeColor = System.Drawing.Color.Black;
            this.lblCodeInstallation.Location = new System.Drawing.Point(183, 89);
            this.lblCodeInstallation.Name = "lblCodeInstallation";
            this.lblCodeInstallation.PreventEnterBeep = true;
            this.lblCodeInstallation.Size = new System.Drawing.Size(286, 27);
            this.lblCodeInstallation.TabIndex = 9;
            // 
            // txtOrdinateur
            // 
            this.txtOrdinateur.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtOrdinateur.Border.Class = "TextBoxBorder";
            this.txtOrdinateur.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOrdinateur.DisabledBackColor = System.Drawing.Color.White;
            this.txtOrdinateur.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdinateur.ForeColor = System.Drawing.Color.Black;
            this.txtOrdinateur.Location = new System.Drawing.Point(183, 51);
            this.txtOrdinateur.Name = "txtOrdinateur";
            this.txtOrdinateur.PreventEnterBeep = true;
            this.txtOrdinateur.Size = new System.Drawing.Size(286, 27);
            this.txtOrdinateur.TabIndex = 10;
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            // 
            // 
            // 
            this.lblStation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblStation.Location = new System.Drawing.Point(14, 129);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(155, 22);
            this.lblStation.TabIndex = 3;
            this.lblStation.Text = "Numéro de la station:";
            // 
            // lblOrdinateur
            // 
            this.lblOrdinateur.AutoSize = true;
            // 
            // 
            // 
            this.lblOrdinateur.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblOrdinateur.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdinateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblOrdinateur.Location = new System.Drawing.Point(14, 53);
            this.lblOrdinateur.Name = "lblOrdinateur";
            this.lblOrdinateur.Size = new System.Drawing.Size(84, 22);
            this.lblOrdinateur.TabIndex = 4;
            this.lblOrdinateur.Text = "Ordinateur:";
            // 
            // lblCodeInstalation
            // 
            this.lblCodeInstalation.AutoSize = true;
            // 
            // 
            // 
            this.lblCodeInstalation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCodeInstalation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeInstalation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblCodeInstalation.Location = new System.Drawing.Point(14, 91);
            this.lblCodeInstalation.Name = "lblCodeInstalation";
            this.lblCodeInstalation.Size = new System.Drawing.Size(139, 22);
            this.lblCodeInstalation.TabIndex = 5;
            this.lblCodeInstalation.Text = "Code d\'installation:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            // 
            // 
            // 
            this.lblIP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblIP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblIP.Location = new System.Drawing.Point(14, 15);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(83, 22);
            this.lblIP.TabIndex = 6;
            this.lblIP.Text = "Numéro IP:";
            // 
            // PanelEx2
            // 
            this.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelEx2.Controls.Add(this.btnEnregistrer);
            this.PanelEx2.Controls.Add(this.panelEx3);
            this.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEx2.Location = new System.Drawing.Point(0, 32);
            this.PanelEx2.Name = "PanelEx2";
            this.PanelEx2.Padding = new System.Windows.Forms.Padding(1);
            this.PanelEx2.Size = new System.Drawing.Size(506, 241);
            this.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PanelEx2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx2.Style.GradientAngle = 90;
            this.PanelEx2.TabIndex = 952;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.txtIP);
            this.panelEx3.Controls.Add(this.lblIP);
            this.panelEx3.Controls.Add(this.txtOrdinateur);
            this.panelEx3.Controls.Add(this.lblStation);
            this.panelEx3.Controls.Add(this.lblCodeInstalation);
            this.panelEx3.Controls.Add(this.lblCodeInstallation);
            this.panelEx3.Controls.Add(this.txtStation);
            this.panelEx3.Controls.Add(this.lblOrdinateur);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Location = new System.Drawing.Point(12, 12);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Padding = new System.Windows.Forms.Padding(1);
            this.panelEx3.Size = new System.Drawing.Size(482, 167);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 952;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.AutoSize = true;
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnEnregistrer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnEnregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(165, 194);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(177, 29);
            this.btnEnregistrer.TabIndex = 953;
            this.btnEnregistrer.Text = "Enregistrer le fichier XML";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // frmXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 273);
            this.Controls.Add(this.panelEx1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXML";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Générateur de fichier XML.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelEx1.ResumeLayout(false);
            this.PanelEx2.ResumeLayout(false);
            this.PanelEx2.PerformLayout();
            this.panelEx3.ResumeLayout(false);
            this.panelEx3.PerformLayout();
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
        private DevComponents.DotNetBar.LabelX lblCodeInstalation;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStation;
        private DevComponents.DotNetBar.LabelX lblOrdinateur;
        private DevComponents.DotNetBar.Controls.TextBoxX lblCodeInstallation;
        private DevComponents.DotNetBar.LabelX lblStation;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOrdinateur;
        internal DevComponents.DotNetBar.PanelEx panelEx3;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}

