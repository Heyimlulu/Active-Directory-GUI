using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Management.Automation;
using System.DirectoryServices.AccountManagement;

namespace InterfacePowShell
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // disabled the button at app launch
            button1.Enabled = false;
        }
        private void TextBoxDel_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDel.Text == "")
            {
                button1.Enabled = false;
            }
            if (textBoxDel.Text != "")
            {
                button1.Enabled = true;
            }
            //
            if (textBoxDel.Text == "Administrateur")
            {
                button1.Enabled = false;
            }
            //
            if (textBoxDel.Text == "Invité")
            {
                button1.Enabled = false;
            }
            if (textBoxDel.Text == "Invitè")
            {
                button1.Enabled = false;
            }
            if (textBoxDel.Text == "Invite")
            {
                button1.Enabled = false;
            }
            //
            if (textBoxDel.Text == "WIN-DM0HHA3RDF3$")
            {
                button1.Enabled = false;
            }
            //
            if (textBoxDel.Text == "krbtgt")
            {
                button1.Enabled = false;
            }
        }
        private void ButtonAD_Click(object sender, EventArgs e)
        {
            DirectoryEntry Ldap = new DirectoryEntry("LDAP://Forest.Gump", "Administrateur", "Serveur2019");
            DirectorySearcher searcher = new DirectorySearcher(Ldap);

            {
                searcher.Filter = ("objectClass=user");

                String donneeAD = "";
                foreach (SearchResult result in searcher.FindAll())
                {

                    DirectoryEntry DirEntry = result.GetDirectoryEntry();

                    donneeAD = (donneeAD + "\r\nLogin : " + DirEntry.Properties["SAMAccountName"].Value + "\r\n" +
                                    "Description : " + DirEntry.Properties["description"].Value + "\r\n" +
                                    "-------------------");
                }
                textBoxAD.Text = (donneeAD);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            DirectoryEntry dirEntry = new DirectoryEntry("LDAP://Forest.Gump", "Administrateur", "Serveur2019");
            // set up domain context
            PrincipalContext ctx = new PrincipalContext(ContextType.Domain);
            // find the user you want to delete
            UserPrincipal user = UserPrincipal.FindByIdentity(ctx, textBoxDel.Text);

            if (user != null)
            {
                DialogResult dialogResult = MessageBox.Show("Souhaitez-vous supprimer définitivement cet utilisateur?", "Validation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    user.Delete();
                    MessageBox.Show("L'utilisateur a été supprimé avec succés",
                        "Done", MessageBoxButtons.OK);
                }
                else if (dialogResult == DialogResult.No)
                {                  
                }
            }

            /*
            DirectoryEntry dirEntry = new DirectoryEntry("LDAP://Forest.Gump", "Administrateur", "Serveur2019");
            PowerShell shell = PowerShell.Create();
            shell.AddCommand("Remove-ADUser")
                 .AddParameter("Identity", textBoxDel.Text);
                 //.AddScript("Confirm:$false");

            shell.Invoke();
            MessageBox.Show("Utilisateur supprimé avec succés!",
                   "Done", MessageBoxButtons.OK);
            */
        }
    }
}
