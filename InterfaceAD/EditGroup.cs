using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacePowShell
{
    class EditGroup
    {
        public string name;
        public string description;

        public void UpdateGroup()
        {
            // Connexion à L'AD
            try
            {
                DirectoryEntry dirEntry = new DirectoryEntry(/*ldap, adusername, adpassword*/);
                DirectorySearcher searcher = new DirectorySearcher(/*cn*/);
                searcher.Filter = ("sAMAccountName=" + name);

                SearchResult result = searcher.FindOne();
                if (result != null)
                {
                    // create new object from search result    
                    DirectoryEntry entryToUpdate = result.GetDirectoryEntry();
                    if (name == "----Select/Add Group----")
                    {
                        MessageBox.Show("Le groupe n'existe pas!", "Error", MessageBoxButtons.OK);
                        return;
                    }
                    entryToUpdate.Properties["SAMAccountName"].Value = (name);
                    entryToUpdate.Properties["Description"].Value = (description);

                    entryToUpdate.CommitChanges();

                    MessageBox.Show("Le groupe a été mis a jour!", "Done", MessageBoxButtons.OK);
                }
            }
            catch
            {
                return;
            }
        }
    }
}
