using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Management.Automation;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;


namespace InterfacePowShell
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private bool ActiveDirectoryAuthenticate(string username, string password)
        {
            bool result = false;
            using (DirectoryEntry _entry = new DirectoryEntry("LDAP://172.17.202.18" + "/CN=Users," + "Forest.Gump," + "Administrator," + "Server2019" + AuthenticationTypes.FastBind))
            {
                _entry.Username = username;
                _entry.Password = password;
                DirectorySearcher _searcher = new DirectorySearcher(_entry);
                _searcher.Filter = "(objectclass=user)";
                try
                {
                    SearchResult _sr = _searcher.FindOne();
                    string _name = _sr.Properties["displayname"][0].ToString();
                    result = true;
                }
                catch
                { /* Error handling omitted to keep code short: remember to handle exceptions !*/ }
            }

            return result; //true = user authenticated!
        }

        private void Btn_AddUser_Click(object sender, EventArgs e)
        {
            DirectoryEntry dirEntry = new DirectoryEntry("LDAP://172.17.202.18" + "/CN=Users," + "Forest.Gump," + "Administrator," + "Server2019" + AuthenticationTypes.FastBind);
            {
                //
                // (!=Inequality) || (==equality) 
                //
                {
                    string username = "username";
                    string password = "password";
                    //
                    // if (username != null)
                    if (username == string.Empty && password == string.Empty)
                    {
                        MessageBox.Show("ça marche pas!",
                            "Error", MessageBoxButtons.OK);
                    }
                    else
                    { 
                        // if (dirEntry.SchemaEntry.Name == "container");
                        //
                        //
                        DirectoryEntry user = dirEntry.Children.Add("CN=Users" + username, "user");
                        //
                        //
                        /*if (DirectoryEntry.Exists("LDAP:///CN=Users,Forest.Gump"))
                        {
                            MessageBox.Show("username already exist!",
                                "Error", MessageBoxButtons.OK);
                        }*/
                        // else
                        {
                            //
                            //
                            // fullname.Text = fname.Text + lname.Text;
                            //
                            //
                            //
                            user.Properties["sAMAccountName"].Value = username; //
                            user.Properties["givenName"].Value = fname;  // first name
                            user.Properties["sn"].Value = lname;    // last name
                            user.Properties["displayName"].Value = fullname; // fullname
                            user.Properties["logon"].Value = logon; // login
                            user.Properties["password"].Value = password; //
                            user.Properties["description"].Value = description; //
                            user.Properties["userAccountControl"].Value = 512;  // normal account
                            //
                            //
                            user.CommitChanges();
                            //
                            //
                            MessageBox.Show("C'est tout bon!",
                                "Done", MessageBoxButtons.OK);
                        }
                    }
                    /*else
                    {
                        MessageBox.Show("ça marche pas!",
                        "Error", MessageBoxButtons.OK);
                    }*/
                }
            }
        }
    }
}
