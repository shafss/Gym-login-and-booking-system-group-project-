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
    public partial class ExterLoggedIn : Form
    {
        internal string fileName = "GymInfo.xml";

        internal string passingId = "";
        internal string fName = "";
        internal string lName = "";
        internal string email = "";
        internal string password = "";
        internal string motivation = "";

        public ExterLoggedIn(string id)
        {/*The form is initialized, inserting the name and user ID of the account at the top of the form.
            *The listbox is also filled out with PTs that match the current user's motivation level.*/
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm";
            PTListbx.Items.Clear();

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(fileName);

            string PTfName = "";
            string PTlName = "";
            string PTemail = "";
            string PTmotivation = "";
            XmlNodeList xnList = xmldoc.SelectNodes("/Users/Externals/record");
            XmlNodeList PTNodeList = xmldoc.SelectNodes("/Users/PTs/record");

            for (int i = 0; i < xnList.Count; i++)
            {
                if (id == xnList[i]["ID"].InnerText)
                {
                    fName = xnList[i]["FirstName"].InnerText;
                    lName = xnList[i]["LastName"].InnerText;
                    email = xnList[i]["Email"].InnerText;
                    password = xnList[i]["Password"].InnerText;
                    motivation = xnList[i]["Motivation"].InnerText;
                    break;
                }
            }
            NameLbl.Text = "Name:" + fName + " " + lName + "\r\nUser ID:" + id;
            passingId = id;
            for (int i = 0; i < PTNodeList.Count; i++)
            {
                if (motivation == PTNodeList[i]["Motivation"].InnerText)
                {
                    PTfName = PTNodeList[i]["FirstName"].InnerText;
                    PTlName = PTNodeList[i]["LastName"].InnerText;
                    PTemail = PTNodeList[i]["Email"].InnerText;
                    PTmotivation = PTNodeList[i]["Motivation"].InnerText;
                    PTListbx.Items.Add("Name: " + PTfName + " " + PTlName + "   Email: " + PTemail + "   Motivation: " + PTmotivation);
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {/*This calls the edit details method, passing through the account details*/
            EditDetails form = new EditDetails(passingId, fName, lName, email, password, motivation, "Externals");
            form.ShowDialog();
            Close();
        }
    }
}
