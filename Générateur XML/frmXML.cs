using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
//using XML_BD.Dados;
using System.Linq;

namespace WindowsFormsApp2
{
    public partial class frmXML : Form
    {
        public frmXML()
        {
            InitializeComponent();
        }

        String appPath = @"C:\AudioClick\BaseTemp\DB.xml";

        private void Form1_Load(object sender, EventArgs e)
        {

            bool checkFile = false;
            checkFile = CheckXmlExists(checkFile);

            if (checkFile == true)
            {
                ReadAndLoadXML();
                lblStatusBar.Text = "Le fichier XML a été chargé avec succès.";
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

            XmlTextWriter writer = new XmlTextWriter(appPath, System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("audioclicknet");

            CreateNode("", "", "", "", writer);

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            MessageBox.Show("The DB.xml file has been created ! ");

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

        public void ReadAndLoadXML()
        {

            //Lire le fichier et charger les champs.

            XmlTextReader reader = new XmlTextReader(appPath);

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
            MessageBox.Show("Lecture du fichier XML effectuée avec succès!");
        }

        public bool CheckXmlExists(bool exist)
        {
            // Vérifie si le fichier DB.xml existe sur l’ordinateur du client.

            if (System.IO.File.Exists(appPath))
            {
                exist = true;
            }
            else
            {
                exist = false;
            }
            return exist;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            // Enregistrer le fichier DB.xml





        }

    }
}
