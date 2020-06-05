using System;
using System.DirectoryServices;
using System.Management.Automation;
using System.Windows.Forms;


namespace InterfacePowShell{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAD_Click(object sender, EventArgs e)
        {
            DirectoryEntry Ldap = new DirectoryEntry("LDAP://Forest.Gump", "Administrateur", "Serveur2019");
            DirectorySearcher searcher = new DirectorySearcher(Ldap);

            if (comboBoxAD.Text == "Users List")
            {
                searcher.Filter = ("objectClass=user");

                String donneeAD = "";
                foreach (SearchResult result in searcher.FindAll())
                {

                    DirectoryEntry DirEntry = result.GetDirectoryEntry();

                    donneeAD = (donneeAD + "\r\nLogin : " + DirEntry.Properties["SAMAccountName"].Value + "\r\n" +
                                    "Nom : " + DirEntry.Properties["sn"].Value + "\r\n" +
                                    "Prénom : " + DirEntry.Properties["givenName"].Value + "\r\n" +
                                    "Email : " + DirEntry.Properties["mail"].Value + "\r\n" +
                                    "Tél : " + DirEntry.Properties["TelephoneNumber"].Value + "\r\n" +
                                    "Description : " + DirEntry.Properties["description"].Value + "\r\n" +
                                    "-------------------");
                }
                textBoxAD.Text = (donneeAD);

            }
            else if (comboBoxAD.Text == "Groups List")
            {

                searcher.Filter = ("objectClass=group");
                String donneeDomaine = "";


                foreach (SearchResult result in searcher.FindAll())
                {
                    DirectoryEntry DirEntry = result.GetDirectoryEntry();
                    donneeDomaine = (donneeDomaine + "Nom du groupe : " + DirEntry.Properties["SAMAccountName"].Value + "\r\n");

                }
                textBoxAD.Text = (donneeDomaine);

            }
            else if (comboBoxAD.Text == "PC Name")
            {

                searcher.Filter = ("objectClass=computer");
                String donneeDomaineID = "";


                foreach (SearchResult result in searcher.FindAll())
                {
                    DirectoryEntry DirEntry = result.GetDirectoryEntry();
                    donneeDomaineID = (donneeDomaineID + "Nom du PC : " + DirEntry.Properties["SAMAccountName"].Value + "\r\n");

                }
                textBoxAD.Text = (donneeDomaineID);

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();

            this.Hide();
        }

        private void NewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();

            this.Hide();
        }
    }
}
/*
 PowerShell shell = PowerShell.Create();
                    shell.AddCommand("VM-ipconfig")
                         .AddStatement();
                         

                    foreach (PSObject result in shell.Invoke())
                    {
                    donneeDomaine = (donneeDomaine + result+"\r\n");
                    } 
 */
