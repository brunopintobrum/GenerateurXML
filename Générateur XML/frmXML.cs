using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using GenerateurXML.Data;
using System.Linq;

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
            public static string appPath = @"C:\AudioClick\BaseTemp\DB.xml";

        }    

        private void Form1_Load(object sender, EventArgs e)
        {

            Global.checkFile = false;
            Global.checkFile = CheckXmlExists(Global.checkFile);

            if (Global.checkFile == true)
            {
                ReadAndLoadXML();
                btnLire.Enabled = false;
            }
            else
            {
                CreateNewXML();
                ReadAndLoadXML();
            }
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

            txtIP.Text = "";
            cboOrdinateur.SelectedIndex = -1;
            txtCodeInstallation.Text = "";
            txtStation.Text = "";
            ckbNouveau.Checked = false;
            ckbTS.Checked = false;
            lblStatusBar.Text = "";

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


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLire_Click(object sender, EventArgs e)
        {

            ReadAndLoadXML();

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            // Enregistrer le fichier DB.xml

            if (txtIP.Text == "" || cboOrdinateur.Text == "" || txtCodeInstallation.Text == "" || txtStation.Text == "")
            {
                NettoyerChamps();
                return;
            }

            SaveXML();
            NettoyerChamps();
            btnLire.Enabled = true;


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
    }
}
