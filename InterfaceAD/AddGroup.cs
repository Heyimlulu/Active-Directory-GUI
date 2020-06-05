using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacePowShell
{
    class AddGroup
    {
        public string name;
        public string description;

        public void NewGroup()
        {
            try
            {
                DirectoryEntry dirEntry = new DirectoryEntry(/*ldap, adusername, adpassword*/);
                dirEntry.Path = "cn"; // <-- Change this later !!!
                DirectorySearcher searcher = new DirectorySearcher(dirEntry);
                // On vérifie dans si un utilisateur existe déjà dans l'AD
                searcher.Filter = ("sAMAccountName=" + name);

                SearchResult result = searcher.FindOne();
                if (result != null)
                {
                    MessageBox.Show("Le groupe existe déjà!", "Error", MessageBoxButtons.OK);
                    return;
                }
                // create group entry
                DirectoryEntry group = dirEntry.Children.Add("CN=" + name, "group");
                if (name == "----Select/Add Group----")
                {
                    MessageBox.Show("Invalid group name!", "Error", MessageBoxButtons.OK);
                    return;
                }
                // set properties
                group.Properties["sAmAccountName"].Add(name); group.Properties["Description"].Add(description);
                // save group
                group.CommitChanges();

                MessageBox.Show("Le groupe a été crée avec succés!", "Done", MessageBoxButtons.OK);
            }
            catch
            {
                return;
            }
        }
    }
}
