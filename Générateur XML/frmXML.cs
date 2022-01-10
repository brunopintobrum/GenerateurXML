using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using GenerateurXML.Data;
using System.Linq;
using System.IO;

namespace GenerateurXML
{
    public partial class frmXML : Form
    {
        public frmXML()
        {
            InitializeComponent();
        }

        public static class Global
        {

            // Variables globales du projet.
            public static bool checkFile;
            public static string checkboxValue = "";
            public static string appPath = @"C:\AudioClick\BaseTemp\DB.xml";
            public static string dllPath = @"C:\AudioClick\";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Global.checkFile = false;
            Global.checkFile = CheckXmlExists(Global.checkFile);

            if (Global.checkFile == true)
            {
                ReadAndLoadXML();
                Buttons(true);
                //btnLire.Enabled = false;
            }
            else
            {
                CreateNewXML();
                ReadAndLoadXML();
            }
            VerifierCheckbox();
            Global.checkboxValue = txtStation.Text;
        }

        public void CreateNewXML()
        {
            //Fonction pour créer le nouveau fichier XML sur le client.

            XmlTextWriter writer = new XmlTextWriter(Global.appPath, System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("audioclicknet");

            CreateNode("", "", "", "", writer);

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            MsgCreation();

        }

        public void SaveXML()
        {
            //Fonction pour créer le nouveau fichier XML sur le client.

            XmlTextWriter writer = new XmlTextWriter(Global.appPath, System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("audioclicknet");

            CreateNode(txtIP.Text, cboOrdinateur.Text, txtCodeInstallation.Text, txtStation.Text, writer);

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            MsgEnregistrer();

        }

        public void CreateNode(string ip, string ordinateur, string codeinstallation, string numerostation, XmlTextWriter writer)
        {
            // Création des noeuds.

            //Node IP
            writer.WriteStartElement("ip");
            writer.WriteString(ip);
            writer.WriteEndElement();

            //Node Ordinateur
            writer.WriteStartElement("ordinateur");
            writer.WriteString(ordinateur);
            writer.WriteEndElement();

            //Node Ordinateur
            writer.WriteStartElement("codeinstall");
            writer.WriteString(codeinstallation);
            writer.WriteEndElement();

            //Node Ordinateur
            writer.WriteStartElement("numerostation");
            writer.WriteString(numerostation);
            writer.WriteEndElement();

        }

        public void NettoyerChamps()
        {
            //Nettoyer les champs
            ckbNouveau.Checked = false;
            ckbTS.Checked = false;
            txtIP.Text = "";
            cboOrdinateur.SelectedIndex = -1;
            txtCodeInstallation.Text = "";
            lblStatusBar.Text = "";
            txtStation.Text = "";

        }

        public void ReadAndLoadXML()
        {

            //Lire le fichier et charger les champs.

            XmlTextReader reader = new XmlTextReader(Global.appPath);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "ip")
                {
                    txtIP.Text = reader.ReadString();
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "ordinateur")
                {
                    var ordinateur = reader.ReadString();

                    if (ordinateur.ToUpper() == "SERVEUR")
                    {
                        cboOrdinateur.SelectedIndex = 0;
                    }
                    else
                    {
                        cboOrdinateur.SelectedIndex = 1;
                    }
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "codeinstall")
                {
                    txtCodeInstallation.Text = reader.ReadString();
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "numerostation")
                {
                    txtStation.Text = reader.ReadString();
                }

            }
            reader.Close();
            reader.Dispose();

            if (Global.checkFile == true)
            {
                MsgLeiture();
            }
        }

        public bool CheckXmlExists(bool exist)
        {
            // Vérifie si le fichier DB.xml existe sur l’ordinateur du client.

            if (System.IO.File.Exists(Global.appPath))
            {
                exist = true;
            }
            else
            {
                exist = false;
            }
            return exist;
        }


        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLire_Click(object sender, EventArgs e)
        {

            ReadAndLoadXML();
            Buttons(true);
            VerifierCheckbox();

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            var ordinateur = cboOrdinateur.Text;
            var codeInstall = txtCodeInstallation.Text;

            // Enregistrer le fichier DB.xml

            if (txtIP.Text == "" || cboOrdinateur.Text == "" || txtCodeInstallation.Text == "" || txtStation.Text == "")
            {
                NettoyerChamps();
                return;
            }

            SaveXML();
            NettoyerChamps();
            Buttons(false);
            VerifierCheckbox();

            CreationFileDLL(ordinateur, codeInstall);



        }

        private void CreationFileDLL(string ordinateur, string codeinstall)
        {
            //Fonction de créer les fichiers dlls.
            if (ordinateur == "SERVEUR")
            {
                //Appelle la fonction pour créer le fichier wct.dll
                CreationWCT(codeinstall);
            }
            else // =STATION
            {
                //Appelle la fonction pour créer le fichier wcli.dll
                CreationWCLI(codeinstall);
            }
        }

        private void CreationWCT(string codeinstall)
        {
            //Fonction de création du fichier wct.dll
            try
            {
                var path = Global.dllPath + "wct.dll";
                using (FileStream fs = File.Create(path))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write(codeinstall);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Le fichier wct.dll a été correctement créé");
        }

        private void CreationWCLI(string codeinstall)
        {
            //Fonction de création du fichier wcli.dll
            try
            {
                var path = Global.dllPath + "wcli.dll";
                using (FileStream fs = File.Create(path))

                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write(codeinstall);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Le fichier wcli.dll a été correctement créé");
        }


        private void VerifierCheckbox()
        {
            //Vérifier l’état de l’outil Checkbox
            if (txtStation.Text == "-1")
            {
                ckbNouveau.Checked = true;
            }
            else if (txtStation.Text == "0")
            {
                ckbTS.Checked = true;
            }
        }

        private void Buttons(bool option)
        {
            switch (option)
            {
                case true:
                    btnLire.Enabled = false;
                    btnEnregistrer.Enabled = true;
                    break;

                case false:
                    btnLire.Enabled = true;
                    btnEnregistrer.Enabled = false;
                    break;
            }
        }

        private void MsgLeiture()
        {
            lblStatusBar.Text = "Le fichier DB.xml a été chargé avec succès.";
            MessageBox.Show("Le fichier XML a été chargé avec succès.");
        }

        private void MsgEnregistrer()
        {
            lblStatusBar.Text = "Le fichier DB.xml a été enregistré avec succès.";
            MessageBox.Show("Le fichier a été enregistré avec succès.");
        }

        private void MsgCreation()
        {
            lblStatusBar.Text = "Le fichier DB.xml a été créé avec succès. Veuillez entrer les champs, puis cliquez sur le bouton d’enregistrer.";
            MessageBox.Show("Le fichier DB.xml a été créé avec succès. Veuillez entrer les champs, puis cliquez sur le bouton d’enregistrer.");
        }

        private void txtCodeInstallation_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txtStation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void ckbNouveau_CheckStateChanged(object sender, EventArgs e)
        {


            if (ckbNouveau.Checked == true)
            {
                ckbTS.Checked = false;
                txtStation.Enabled = false;
                txtStation.Text = "-1";

            }
            else
            {
                txtStation.Enabled = true;
                txtStation.Text = Global.checkboxValue;
            }

        }

        private void ckbTS_CheckStateChanged(object sender, EventArgs e)
        {

            if (ckbTS.Checked == true)
            {
                ckbNouveau.Checked = false;
                txtStation.Enabled = false;
                txtStation.Text = "0";

            }
            else
            {
                txtStation.Enabled = true;
                txtStation.Text = Global.checkboxValue;
            }

        }
    }
}
