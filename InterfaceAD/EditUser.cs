using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacePowShell
{
    class EditUser
    {
        public string samaccountname;
        public string login;
        public string password;
        public string firstname;
        public string lastname;
        public string fullname;
        public string description;

        public void UpdateUser()
        {
            // Connexion à L'AD
            try
            {
                DirectoryEntry dirEntry = new DirectoryEntry(/*ldap, adusername, adpassword*/);
                DirectorySearcher searcher = new DirectorySearcher(dirEntry);
                if (samaccountname == "----Select/Add Username----")
                {
                    MessageBox.Show("Please select a valid username", "", MessageBoxButtons.OK);
                    return;
                }
                searcher.Filter = ("sAMAccountName=" + samaccountname);

                SearchResult result = searcher.FindOne();
                if (result != null)
                {
                    // create new object from search result    
                    DirectoryEntry entryToUpdate = result.GetDirectoryEntry();

                    entryToUpdate.Properties["SAMAccountName"].Value = (samaccountname);
                    entryToUpdate.Properties["userPrincipalName"].Value = (login);
                    entryToUpdate.Properties["sn"].Value = (lastname);
                    entryToUpdate.Properties["givenName"].Value = (firstname);
                    entryToUpdate.Properties["displayName"].Value = (fullname);
                    entryToUpdate.Properties["description"].Value = (description);

                    entryToUpdate.CommitChanges();

                    MessageBox.Show("L'utilisateur a été mis a jour!",
                                                            "Done", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("L'utilisateur n'existe pas!",
                                        "Error", MessageBoxButtons.OK);
                }
            }
            catch
            {
            }
        }
    }
}
