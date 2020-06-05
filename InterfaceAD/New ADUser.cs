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
using System.Security;

namespace InterfacePowShell
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Btn_AddUser_Click(object sender, EventArgs e)
        {
            // Connexion à l'annuaire
            DirectoryEntry dirEntry = new DirectoryEntry("LDAP://Forest.Gump", "Administrateur", "Serveur2019");
            dirEntry.Path = "LDAP://CN=Users,DC=Forest,DC=Gump";
            // Création de string et ajouter des données
            string samaccountname = username.Text;
            string login = logon.Text;
            string lastname = lname.Text;
            string firstname = fname.Text;
            string displayname = fullname.Text;
            string Description = description.Text;
            string Pass = password.Text;
            // Création du user et initialisation de ses propriétés
            DirectoryEntry user = dirEntry.Children.Add("CN=" + displayname, "user");
            user.Properties["SAMAccountName"].Add(samaccountname);
            user.Properties["userPrincipalName"].Add(login);
            user.Properties["sn"].Add(lastname);
            user.Properties["givenName"].Add(firstname);
            user.Properties["displayName"].Add(displayname);
            user.Properties["description"].Add(Description);
            // On envoie les modifications au serveur
            user.CommitChanges();

            // On va maintenant lui définir son password. L'utilisateur doit avoir été créé
            // et sauvé avant de pouvoir faire cette étape
            user.Invoke("SetPassword", new object[] { Pass });
            // On va maintenant activer le compte : ADS_UF_NORMAL_ACCOUNT
            user.Properties["userAccountControl"].Value = 0x0200;
            // On envoie les modifications au serveur
            user.CommitChanges();
            MessageBox.Show("C'est tout bon!",
                                "Done", MessageBoxButtons.OK);
        }

        private void Fullname_Enter(object sender, EventArgs e)
        {
            if (fullname.Text == "FullName")
            {
                fullname.Text = "";

                fullname.ForeColor = Color.Black;
            }
            fullname.Text = fname.Text + " " + lname.Text;
            {
                fullname.ForeColor = Color.Black;
            }
        }
        private void Fullname_Leave(object sender, EventArgs e)
        {
            if (fullname.Text == "")
            {
                fullname.Text = "FullName";

                fullname.ForeColor = Color.Silver;
            }
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Username") {
                username.Text = "";

                username.ForeColor = Color.Black;
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Username";

                username.ForeColor = Color.Silver;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";

                password.ForeColor = Color.Black;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Password";

                password.ForeColor = Color.Silver;
            }
        }

        private void Logon_Enter(object sender, EventArgs e)
        {
            if (logon.Text == "Login")
            {
                logon.Text = "";

                logon.ForeColor = Color.Black;
            }
        }

        private void Logon_Leave(object sender, EventArgs e)
        {
            if (logon.Text == "")
            {
                logon.Text = "Login";

                logon.ForeColor = Color.Silver;
            }
        }

        private void Fname_Enter(object sender, EventArgs e)
        {
            if (fname.Text == "Firstname")
            {
                fname.Text = "";

                fname.ForeColor = Color.Black;
            }
        }

        private void Fname_Leave(object sender, EventArgs e)
        {
            if (fname.Text == "")
            {
                fname.Text = "Firstname";

                fname.ForeColor = Color.Silver;
            }
        }

        private void Lname_Enter(object sender, EventArgs e)
        {
            if (lname.Text == "Lastname")
            {
                lname.Text = "";

                lname.ForeColor = Color.Black;
            }
        }

        private void Lname_Leave(object sender, EventArgs e)
        {
            if (lname.Text == "")
            {
                lname.Text = "Lastname";

                lname.ForeColor = Color.Silver;
            }
        }

        private void Description_Enter(object sender, EventArgs e)
        {
            if (description.Text == "Description")
            {
                description.Text = "";

                description.ForeColor = Color.Black;
            }
        }

        private void Description_Leave(object sender, EventArgs e)
        {
            if (description.Text == "")
            {
                description.Text = "Description";

                description.ForeColor = Color.Silver;
            }
        }
    }
}

/*   
{
   DirectoryEntry dirEntry = new DirectoryEntry("LDAP://Forest.Gump", "Administrateur", "Serveur2019");
   dirEntry.Path = "LDAP://CN=Users,DC=Forest,DC=Gump";
   {
       {
           //
           if (username != null)
           {
                   PowerShell shell = PowerShell.Create();

                   shell.AddCommand("New-ADUser")
                        .AddParameter("Name", "Maxime Dufour")
                        .AddParameter("GivenName", "Maxime")
                        .AddParameter("Surname", "Dufour")
                        .AddParameter("SamAccountName", "M.Dufour")
                        .AddParameter("UserPrincipalName", "MDufour");
                        //.AddParameter("AccountPassword", "$SecurePassword");

               foreach (PSObject result in shell.Invoke())
               {

               }
               MessageBox.Show("C'est tout bon!",
                   "Done", MessageBoxButtons.OK);
           }
           else
           {
               MessageBox.Show("ça marche pas!",
                   "Error", MessageBoxButtons.OK);
           }                    
       }
   }
}
   */

