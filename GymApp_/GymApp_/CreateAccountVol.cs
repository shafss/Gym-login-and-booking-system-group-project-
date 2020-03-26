using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace GymApp_Group9
{
    public partial class CreateAccountVol : Form
    {
        internal string fileName = "GymInfo.xml";
        public CreateAccountVol()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            /*Code below creates a unique ID for the new account, validates all of the information within the textboxes and then adds a record containing the new account*/
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(fileName);
            XDocument doc = XDocument.Load(fileName);
            XmlNodeList xnList = xmldoc.SelectNodes("/Users/Volunteers/record");
            int id = 0;
            foreach (XmlNode xn in xnList)
            {
                id = Convert.ToInt32(xn["ID"].InnerText);
            }
            int newId = id + 1;
            if (Validation.Validate(ForenameTB.Text, SurnameTB.Text, EmailTB.Text, PassTB.Text) == true)
            {
                doc.Element("Users").Element("Volunteers").Add(
                new XElement("record",
                    new XElement("ID", newId),
                    new XElement("FirstName", ForenameTB.Text),
                    new XElement("LastName", SurnameTB.Text),
                    new XElement("Email", EmailTB.Text),
                    new XElement("Password", PassTB.Text)));
                doc.Save(fileName);
                Clipboard.SetText(Convert.ToString(newId));
                MessageBox.Show("Your User ID is " + newId + ".\r\nYour User ID has been copied to your clipboard, you must make note of it in order to log in. Once you've clicked 'OK' you will be redirected back to the menu.");
                Close();
            }
            else
            {
                MessageBox.Show("A field is either not filled in or the value is not valid");
            }
        }
    }
}
