using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacePowShell
{
    class AddUser
    {
        public string samaccountname;
        public string login;
        public string password;
        public string firstname;
        public string lastname;
        public string fullname;
        public string description;

        public void NewUser()
        {
            // Connexion à l'annuaire
            try
            {
                DirectoryEntry dirEntry = new DirectoryEntry(/*ldap, adusername, adpassword*/);
                DirectorySearcher searcher = new DirectorySearcher(fullname);
                // On vérifie dans si un utilisateur existe déjà dans l'AD
                searcher.Filter = ("sAMAccountName=" + samaccountname);

                SearchResult result = searcher.FindOne();
                if (result != null)
                {
                    MessageBox.Show("L'utilisateur existe déjà!",
                        "Error", MessageBoxButtons.OK);
                    return;
                }
                // Création du user et initialisation de ses propriétés
                DirectoryEntry user = dirEntry.Children.Add("CN=" + fullname, "user");
                user.Properties["SAMAccountName"].Add(samaccountname); user.Properties["userPrincipalName"].Add(login);
                user.Properties["sn"].Add(lastname); user.Properties["givenName"].Add(firstname);
                user.Properties["displayName"].Add(fullname); user.Properties["description"].Add(description);
                if (samaccountname == "----Select/Add Username----")
                {
                    MessageBox.Show("Username isn't available", "", MessageBoxButtons.OK);
                    return;
                }
                // On envoie les modifications au serveur
                user.CommitChanges();

                // On va maintenant lui définir son password. L'utilisateur doit avoir été créé
                // et sauvé avant de pouvoir faire cette étape
                user.Invoke("SetPassword", new object[] { password });
                // On va maintenant activer le compte : ADS_UF_NORMAL_ACCOUNT
                user.Properties["userAccountControl"].Value = 0x0200;
                // On envoie les modifications au serveur
                user.CommitChanges();

                MessageBox.Show("L'utilisateur a été crée avec succés!",
                                    "Done", MessageBoxButtons.OK);
            }
            catch
            {
            }
        }
    }
}
