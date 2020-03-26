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
    public partial class MainForm : Form
    {
        internal string fileName = "GymInfo.xml";
        public MainForm()
        {
            InitializeComponent();
        }
        
        
        

        private void callCreateAccount_Click_1(object sender, EventArgs e)
        {
            /*The code below identifies whether the type of account that is to be created and then redirects the user to the according form*/
            if (createUserType.SelectedItem == null)
            {
                SelectUserLbl.Text = "Select type of user * (This must not be empty)";
                SelectUserLbl.ForeColor = Color.Red;
            }

            else
            {
                string userType = createUserType.SelectedItem.ToString();
                switch (createUserType.SelectedItem)
                {
                    case "Student":
                        {
                            CreateAccountStudent form = new CreateAccountStudent();
                            form.ShowDialog();
                            break;
                        }
                    case "Personal Trainer":
                        {
                            CreateAccountPT form = new CreateAccountPT();
                            form.ShowDialog();
                            break;
                        }
                    case "Volunteer":
                        {
                            CreateAccountVol form = new CreateAccountVol();
                            form.ShowDialog();
                            break;
                        }
                    case "Management Staff":
                        {
                            CreateAccountStaff form = new CreateAccountStaff();
                            form.ShowDialog();
                            break;
                        }
                    case "External User":
                        {
                            CreateAccountExt form = new CreateAccountExt();
                            form.ShowDialog();
                            break;
                        }

                    default:
                        break;
                }
            }
        }

        private void LogInBtn_Click_1(object sender, EventArgs e)
        {
            /*The code below identifies whether the type of account that is to be signed in and then checks if the user ID and password correctly matches with an existing record. 
             * If the inputs are correct then the user is redirected to the according form*/
            string id = IDTxtbx.Text;
            string password = passTxtbx.Text;
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(fileName);
            XDocument doc = XDocument.Load(fileName);
            bool loggedIn = false;

            switch (selectUserCombo.SelectedItem)
            {
                case "Student":
                    {
                        typeLbl.ForeColor = Color.DarkBlue;

                        XmlNodeList xnList = xmldoc.SelectNodes("/Users/Students/record");

                        foreach (XmlNode xn in xnList)
                        {
                            if (IDTxtbx.Text == xn["ID"].InnerText && passTxtbx.Text == xn["Password"].InnerText)
                            {
                                loggedIn = true;
                                break;
                            }
                            else
                            {
                                loggedIn = false;
                            }
                        }
                        if (loggedIn)
                        {
                            loginLbl.Text = "Log in";
                            loginLbl.ForeColor = Color.DarkBlue;
                            StudentLoggedIn form = new StudentLoggedIn(id);
                            form.ShowDialog();
                        }
                        else
                        {
                            loginLbl.Text = "Log in - ID or password is incorrect";
                            loginLbl.ForeColor = Color.Red;
                            break;
                        }

                        break;
                    }
                case "Personal Trainer":
                    {
                        typeLbl.ForeColor = Color.DarkBlue;
                        XmlNodeList xnList = xmldoc.SelectNodes("/Users/PTs/record");

                        foreach (XmlNode xn in xnList)
                        {
                            if (IDTxtbx.Text == xn["ID"].InnerText && passTxtbx.Text == xn["Password"].InnerText)
                            {
                                loggedIn = true;
                                break;
                            }
                            else
                            {
                                loggedIn = false;
                            }
                        }
                        if (loggedIn)
                        {
                            loginLbl.Text = "Log in";
                            loginLbl.ForeColor = Color.DarkBlue;
                            PTLoggedIn form = new PTLoggedIn(id);
                            form.ShowDialog();
                        }
                        else
                        {
                            loginLbl.Text = "Log in - ID or password is incorrect";
                            loginLbl.ForeColor = Color.Red;
                            break;
                        }
                        break;
                    }
                case "Volunteer":
                    {
                        typeLbl.ForeColor = Color.DarkBlue;
                        XmlNodeList xnList = xmldoc.SelectNodes("/Users/Volunteers/record");

                        foreach (XmlNode xn in xnList)
                        {
                            if (IDTxtbx.Text == xn["ID"].InnerText && passTxtbx.Text == xn["Password"].InnerText)
                            {
                                loggedIn = true;
                                break;
                            }
                            else
                            {
                                loggedIn = false;
                            }
                        }
                        if (loggedIn)
                        {
                            loginLbl.Text = "Log in";
                            loginLbl.ForeColor = Color.DarkBlue;
                            VolLoggedIn form = new VolLoggedIn(id);
                            form.ShowDialog();
                        }
                        else
                        {
                            loginLbl.Text = "Log in - ID or password is incorrect";
                            loginLbl.ForeColor = Color.Red;
                            break;
                        }
                        break;
                    }
                case "Management Staff":
                    {
                        typeLbl.ForeColor = Color.DarkBlue;
                        XmlNodeList xnList = xmldoc.SelectNodes("/Users/Staff/record");

                        foreach (XmlNode xn in xnList)
                        {
                            if (IDTxtbx.Text == xn["ID"].InnerText && passTxtbx.Text == xn["Password"].InnerText)
                            {
                                loggedIn = true;
                                break;
                            }
                            else
                            {
                                loggedIn = false;
                            }
                        }
                        if (loggedIn)
                        {
                            loginLbl.Text = "Log in";
                            loginLbl.ForeColor = Color.DarkBlue;
                            StaffLoggedIn form = new StaffLoggedIn(id);
                            form.ShowDialog();
                        }
                        else
                        {
                            loginLbl.Text = "Log in - ID or password is incorrect";
                            loginLbl.ForeColor = Color.Red;
                            break;
                        }
                        break;
                    }
                case "External User":
                    {
                        typeLbl.ForeColor = Color.DarkBlue;
                        XmlNodeList xnList = xmldoc.SelectNodes("/Users/Externals/record");

                        foreach (XmlNode xn in xnList)
                        {
                            if (IDTxtbx.Text == xn["ID"].InnerText && passTxtbx.Text == xn["Password"].InnerText)
                            {
                                loggedIn = true;
                                break;
                            }
                            else
                            {
                                loggedIn = false;
                            }
                        }
                        if (loggedIn)
                        {
                            loginLbl.Text = "Log in";
                            loginLbl.ForeColor = Color.DarkBlue;
                            ExterLoggedIn form = new ExterLoggedIn(id);
                            form.ShowDialog();
                        }
                        else
                        {
                            loginLbl.Text = "Log in - ID or password is incorrect";
                            loginLbl.ForeColor = Color.Red;
                            break;
                        }
                        break;
                    }

                default:
                    {
                        typeLbl.ForeColor = Color.Red;
                        break;
                    }
            }
        }
    }
}
