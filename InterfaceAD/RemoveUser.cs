using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacePowShell
{
    class RemoveUser
    {
        public string samaccountname;

        public void DelUser()
        {
            try
            {
                DirectoryEntry dirEntry = new DirectoryEntry(/*ldap, adusername, adpassword*/);
                // set up domain context
                PrincipalContext ctx = new PrincipalContext(ContextType.Domain);
                // find the user you want to delete
                UserPrincipal user = UserPrincipal.FindByIdentity(ctx, samaccountname);
                if (samaccountname == "----Select/Add Username----")
                {
                    MessageBox.Show("Please select a valid username", "", MessageBoxButtons.OK);
                    return;
                }
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
            }
            catch
            {
            }
        }
    }
}
