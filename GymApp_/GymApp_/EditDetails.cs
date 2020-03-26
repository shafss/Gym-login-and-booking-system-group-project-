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
    public partial class EditDetails : Form
    {

        internal string fileName = "GymInfo.xml";
        internal string passingId = "";
        internal string password = "";
        internal string passType = "";
        internal string passMotiv = "";
        
        public EditDetails(string id, string fName, string lName, string email, string pass, string motiv, string type)
        {/*This initializer assigns the textboxes with the existing account details*/
            InitializeComponent();
            passType = type;
            passingId = id;
            password = pass;
            FirstNameTB.Text = fName;
            LastNameTB.Text = lName;
            EmailTB.Text = email;
            passMotiv = motiv;
            if (motiv != "")
            {
                MotivationTBDB.SelectedItem = motiv;
                MotivationTBDB.Visible = true;
                motivLbl.Visible = true;
            }
            
        }

        private void ChangeDetailsButton_Click(object sender, EventArgs e)
        {
            /*Once the button is clicked, the password textboxes are checked if they are both empty in order to not break the xml file.
             *Then the record that corresponds with the ID is used to change the inner text to the text within the textboxes/combobox. 
             * A validation method is also called before the change is implemented. */
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(fileName);
            XDocument doc = XDocument.Load(fileName);
            XmlNodeList xnList = xmldoc.SelectNodes("/Users/"+passType+"/record");
            bool newPass = true;
            if (string.IsNullOrEmpty(OldPassTB.Text) && string.IsNullOrEmpty(NewPassTB.Text))
            {
                newPass = false;
            }
            else
            {
                newPass = true;
                password = NewPassTB.Text;
            }
            for (int i = 0; i < xnList.Count; i++)
            {
                if (passingId == xnList[i]["ID"].InnerText)
                {
                    if (Validation.Validate(FirstNameTB.Text, LastNameTB.Text, EmailTB.Text, password) == true)
                    {

                        if (newPass == false || OldPassTB.Text == xnList[i]["Password"].InnerText)
                        {
                            if (newPass == false || OldPassTB.Text != NewPassTB.Text)
                            {
                                xnList[i]["FirstName"].InnerText = FirstNameTB.Text;
                                xnList[i]["LastName"].InnerText = LastNameTB.Text;
                                xnList[i]["Email"].InnerText = EmailTB.Text;
                                xnList[i]["Password"].InnerText = password;
                                if (passMotiv != "")
                                {
                                    xnList[i]["Motivation"].InnerText = MotivationTBDB.SelectedItem.ToString();
                                }
                                doc.Save(fileName);
                                xmldoc.Save(fileName);
                                MessageBox.Show("You will now be redirected backwards...");
                                Close();
                            }
                            else
                            {
                                newPassLbl.ForeColor = Color.Red;
                                newPassLbl.Text = "New Password is identical to old";
                            }
                        }
                        else
                        {
                            oldPassLbl.ForeColor = Color.Red;
                            oldPassLbl.Text = "Old Password - Password incorrect";
                        }

                    }
                    else
                    {
                        MessageBox.Show("A field is either not filled in or the value is not valid");
                    }

                }
            }
            

        }
    }
}
