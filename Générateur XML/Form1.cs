using System;
using System.Windows.Forms;
using System.Xml;

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

            bool verifierFichier = false;
            verifierFichier = VerifierXMLExistant(verifierFichier);
                       
            if (verifierFichier == true) {

                //Lire le fichier et charger les champs.

                



            }

        }

        public bool VerifierXMLExistant(bool exist)
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
