using System;
using System.Windows.Forms;
using System.Xml;
using System.Data;

namespace WindowsFormsApp2
{
    public partial class frmXML : Form
    {
        public frmXML()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            bool checkFile = false;
            checkFile = CheckXmlExists(checkFile);

            if (checkFile == true)
            {
                ReadAndLoadXML();
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

            XmlTextWriter writer = new XmlTextWriter(@"C:\AudioClick\BaseTemp\DB.xml", System.Text.Encoding.UTF8);
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

            XmlTextReader reader = new XmlTextReader(@"C:\AudioClick\BaseTemp\DB.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "ip")
                {
                    txtIP.Text = reader.ReadString();
                }

                if (reader.NodeType == XmlNodeType.Element && reader.Name == "ordinateur")
                {
                    txtOrdinateur.Text = reader.ReadString();
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

            if (System.IO.File.Exists(@"C:\AudioClick\BaseTemp\DB.xml"))
            {
                exist = true;
            }
            else
            {
                exist = false;
            }
            return exist;
        }



    }
}
