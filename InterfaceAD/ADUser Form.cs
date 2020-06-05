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
using System.Runtime.InteropServices;
using System.IO;

namespace InterfacePowShell
{
    public partial class NewADUser : Form
    {
        // Design de l'application arrondi
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,     // x-coordinate of upper-left corner
    int nTopRect,      // y-coordinate of upper-left corner
    int nRightRect,    // x-coordinate of lower-right corner
    int nBottomRect,   // y-coordinate of lower-right corner
    int nWidthEllipse, // height of ellipse
    int nHeightEllipse // width of ellipse
);
        public NewADUser()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            comboBox_username.Text = "----Select/Add Username----";
            comboBox_username.ForeColor = Color.Silver;
        }
        // Make a borderless form movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Panel_move_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Label_aduser_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void MenuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // Close program
        private void PictureBox_Close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr de vouloir fermer le programme?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        private void PictureBox_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // Add user in Active Directory
        private void Btn_AddUser_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser();
            adduser.samaccountname = comboBox_username.Text;
            adduser.login = logon.Text;
            adduser.password = password.Text;
            adduser.firstname = fname.Text;
            adduser.lastname = lname.Text;
            adduser.fullname = fullname.Text;
            adduser.description = description.Text;
            adduser.NewUser();
            /*
            // Confirmer que la partie utilisateur n'est pas vide
            if (comboBox_username.Text == "----Select/Add Username----" && password.Text == "Password" && logon.Text == "Login" && fname.Text == "Firstname" && 
                lname.Text == "Lastname" && fullname.Text == "FullName")
            {
                errorProvider1.SetError(comboBox_username, "Cannot be empty"); errorProvider1.SetError(password, "Cannot be empty");
                errorProvider1.SetError(logon, "Cannot be empty"); errorProvider1.SetError(fname, "Cannot be empty");
                errorProvider1.SetError(lname, "Cannot be empty"); errorProvider1.SetError(fullname, "Cannot be empty");
            }
            else
            {
                errorProvider1.SetError(comboBox_username, ""); errorProvider1.SetError(password, ""); errorProvider1.SetError(logon, "");
                errorProvider1.SetError(fname, ""); errorProvider1.SetError(lname, ""); errorProvider1.SetError(fullname, "");
            }
            // Connexion à l'annuaire
            try
            {
                string ldap = toolStripTextBox_Ldap.Text; string cn = toolStripTextBox_cn.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
                DirectoryEntry dirEntry = new DirectoryEntry(ldap, adusername, adpassword);
                DirectorySearcher searcher = new DirectorySearcher(cn);
                // Création de string et ajouter des données
                string samaccountname = comboBox_username.Text; string login = logon.Text; string lastname = lname.Text;
                string firstname = fname.Text; string displayname = fullname.Text; string Description = description.Text;
                string Pass = password.Text;
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
                DirectoryEntry user = dirEntry.Children.Add("CN=" + displayname, "user");
                user.Properties["SAMAccountName"].Add(samaccountname); user.Properties["userPrincipalName"].Add(login);
                user.Properties["sn"].Add(lastname); user.Properties["givenName"].Add(firstname);
                user.Properties["displayName"].Add(displayname); user.Properties["description"].Add(Description);
                if (comboBox_username.Text == "----Select/Add Username----")
                {
                    MessageBox.Show("Username n'est pas un pseudo valide", "Error", MessageBoxButtons.OK);
                    return;
                }
                // On envoie les modifications au serveur
                user.CommitChanges();

                // On va maintenant lui définir son password. L'utilisateur doit avoir été créé
                // et sauvé avant de pouvoir faire cette étape
                user.Invoke("SetPassword", new object[] { Pass });
                // On va maintenant activer le compte : ADS_UF_NORMAL_ACCOUNT
                user.Properties["userAccountControl"].Value = 0x0200;
                // On envoie les modifications au serveur
                user.CommitChanges();

                // On réinitialise toutes les textboxs
                comboBox_username.Text = "----Select/Add Username----"; password.Text = "Password"; logon.Text = "login"; fname.Text = "Firstname";
                lname.Text = "Lastname"; fullname.Text = "FullName"; description.Text = "Description";
                {
                    comboBox_username.ForeColor = Color.Silver; password.ForeColor = Color.Silver; logon.ForeColor = Color.Silver; fname.ForeColor = Color.Silver; lname.ForeColor = Color.Silver; fullname.ForeColor = Color.Silver; description.ForeColor = Color.Silver;
                }
                MessageBox.Show("L'utilisateur a été crée avec succés!",
                                    "Done", MessageBoxButtons.OK);
            }
            catch
            {
            }
            comboBox_username.Text = "----Select/Add Username----";
            comboBox_username.ForeColor = Color.Silver;
            // Refresh user list
            try
            {
                comboBox_username.Items.Clear();
                string ldap = toolStripTextBox_Ldap.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
                DirectoryEntry User = new DirectoryEntry(ldap, adusername, adpassword);
                DirectorySearcher searcher = new DirectorySearcher(User);
                {
                    searcher.Filter = ("objectClass=user");
                    String donneeDomaine = "";

                    foreach (SearchResult result in searcher.FindAll())
                    {
                        DirectoryEntry DirEntry = result.GetDirectoryEntry();
                        donneeDomaine = (donneeDomaine + DirEntry.Properties["SAMAccountName"].Value + "\r\n");

                    }
                    foreach (string line in donneeDomaine.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                    {
                        comboBox_username.Items.Add(line);
                    }
                }
            }
            catch
            {
            }
            */
        }
        private void Btn_EditUser_Click(object sender, EventArgs e)
        {
            EditUser edituser = new EditUser();
            edituser.samaccountname = comboBox_username.Text;
            edituser.login = logon.Text;
            edituser.password = password.Text;
            edituser.firstname = fname.Text;
            edituser.lastname = lname.Text;
            edituser.fullname = fullname.Text;
            edituser.description = description.Text;
            edituser.UpdateUser();
            /*
            // Confirmation que les textboxs ne sont pas vide
            if (comboBox_username.Text == "----Select/Add Username----" && password.Text == "Password" && logon.Text == "Login" && fname.Text == "Firstname" &&
                lname.Text == "Lastname" && fullname.Text == "FullName")
            {
                errorProvider1.SetError(comboBox_username, "Cannot be empty"); errorProvider1.SetError(password, "");
                errorProvider1.SetError(logon, "Cannot be empty"); errorProvider1.SetError(fname, "Cannot be empty");
                errorProvider1.SetError(lname, "Cannot be empty"); errorProvider1.SetError(fullname, "Cannot be empty");
            }
            else
            {
                errorProvider1.SetError(comboBox_username, ""); errorProvider1.SetError(password, ""); errorProvider1.SetError(logon, "");
                errorProvider1.SetError(fname, ""); errorProvider1.SetError(lname, ""); errorProvider1.SetError(fullname, "");
            }
            // Connexion à L'AD
            try
            {
                string ldap = toolStripTextBox_Ldap.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
                DirectoryEntry dirEntry = new DirectoryEntry(ldap, adusername, adpassword);
                DirectorySearcher searcher = new DirectorySearcher(dirEntry);
                if (comboBox_username.Text == "----Select/Add Username----")
                {
                    MessageBox.Show("null is not a valid search! Please select a valid username", "No entry", MessageBoxButtons.OK);
                    return;
                }
                string searchusername = comboBox_username.Text;
                searcher.Filter = ("sAMAccountName=" + searchusername);

                SearchResult result = searcher.FindOne();
                if (result != null)
                {
                    // create new object from search result    
                    DirectoryEntry entryToUpdate = result.GetDirectoryEntry();
                    string samaccountname = comboBox_username.Text; string login = logon.Text; string lastname = lname.Text;
                    string firstname = fname.Text; string displayname = fullname.Text; string Description = description.Text;

                    entryToUpdate.Properties["SAMAccountName"].Value = (samaccountname);
                    entryToUpdate.Properties["userPrincipalName"].Value = (login);
                    entryToUpdate.Properties["sn"].Value = (lastname);
                    entryToUpdate.Properties["givenName"].Value = (firstname);
                    entryToUpdate.Properties["displayName"].Value = (displayname);
                    entryToUpdate.Properties["description"].Value = (Description);

                    entryToUpdate.CommitChanges();
                    // On réinitialise toutes les textboxs
                    comboBox_username.Text = "----Select/Add Username----"; password.Text = "Password"; logon.Text = "login"; fname.Text = "Firstname";
                    lname.Text = "Lastname"; fullname.Text = "FullName"; description.Text = "Description";
                    {
                        comboBox_username.ForeColor = Color.Silver; password.ForeColor = Color.Silver; logon.ForeColor = Color.Silver; fname.ForeColor = Color.Silver; lname.ForeColor = Color.Silver; fullname.ForeColor = Color.Silver; description.ForeColor = Color.Silver;
                    }
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
            comboBox_username.Text = "----Select/Add Username----";
            comboBox_username.ForeColor = Color.Silver;
            // Refresh user list
            try
            {
                comboBox_username.Items.Clear();
                string ldap = toolStripTextBox_Ldap.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
                DirectoryEntry User = new DirectoryEntry(ldap, adusername, adpassword);
                DirectorySearcher searcher = new DirectorySearcher(User);
                {
                    searcher.Filter = ("objectClass=user");
                    String donneeDomaine = "";

                    foreach (SearchResult result in searcher.FindAll())
                    {
                        DirectoryEntry DirEntry = result.GetDirectoryEntry();
                        donneeDomaine = (donneeDomaine + DirEntry.Properties["SAMAccountName"].Value + "\r\n");

                    }
                    foreach (string line in donneeDomaine.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                    {
                        comboBox_username.Items.Add(line);
                    }
                }
            }
            catch
            {
            }
            */
        }
        private void Btn_RemoveUser_Click(object sender, EventArgs e)
        {
            RemoveUser removeuser = new RemoveUser();
            removeuser.samaccountname = comboBox_username.Text;
            removeuser.DelUser();
            /*
            // Confirmation que les textboxs ne sont pas vide
            if (comboBox_username.Text == "----Select/Add Username----" && password.Text == "Password" && logon.Text == "Login" && fname.Text == "Firstname" &&
                lname.Text == "Lastname" && fullname.Text == "FullName")
            {
                errorProvider1.SetError(comboBox_username, ""); errorProvider1.SetError(password, ""); errorProvider1.SetError(logon, "");
                errorProvider1.SetError(fname, ""); errorProvider1.SetError(lname, ""); errorProvider1.SetError(fullname, "");
            }
            else
            {
                errorProvider1.SetError(comboBox_username, ""); errorProvider1.SetError(password, ""); errorProvider1.SetError(logon, "");
                errorProvider1.SetError(fname, ""); errorProvider1.SetError(lname, ""); errorProvider1.SetError(fullname, "");
            }
            try
            {
                string ldap = toolStripTextBox_Ldap.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
                DirectoryEntry dirEntry = new DirectoryEntry(ldap, adusername, adpassword);
                // set up domain context
                PrincipalContext ctx = new PrincipalContext(ContextType.Domain);
                // find the user you want to delete
                UserPrincipal user = UserPrincipal.FindByIdentity(ctx, comboBox_username.Text);
                if (comboBox_username.Text == "----Select/Add Username----")
                {
                    MessageBox.Show("null is not a valid search! Please select a valid username", "No entry", MessageBoxButtons.OK);
                    return;
                }
                if (user != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Souhaitez-vous supprimer définitivement cet utilisateur?", "Validation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        user.Delete();
                        // On réinitialise toutes les textboxs
                        comboBox_username.Text = "----Select/Add Username----"; password.Text = "Password"; logon.Text = "login"; fname.Text = "Firstname";
                        lname.Text = "Lastname"; fullname.Text = "FullName"; description.Text = "Description";
                        {
                            comboBox_username.ForeColor = Color.Silver; password.ForeColor = Color.Silver; logon.ForeColor = Color.Silver; fname.ForeColor = Color.Silver; lname.ForeColor = Color.Silver; fullname.ForeColor = Color.Silver; description.ForeColor = Color.Silver;
                        }
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
            comboBox_username.Text = "----Select/Add Username----";
            comboBox_username.ForeColor = Color.Silver;
            // Refresh user list
            try
            {
                comboBox_username.Items.Clear();
                string ldap = toolStripTextBox_Ldap.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
                DirectoryEntry User = new DirectoryEntry(ldap, adusername, adpassword);
                DirectorySearcher searcher = new DirectorySearcher(User);
                {
                    searcher.Filter = ("objectClass=user");
                    String donneeDomaine = "";

                    foreach (SearchResult result in searcher.FindAll())
                    {
                        DirectoryEntry DirEntry = result.GetDirectoryEntry();
                        donneeDomaine = (donneeDomaine + DirEntry.Properties["SAMAccountName"].Value + "\r\n");

                    }
                    foreach (string line in donneeDomaine.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                    {
                        comboBox_username.Items.Add(line);
                    }
                }
            }
            catch
            {
            }
            */
        }
        private void Fullname_Enter(object sender, EventArgs e)
        {
            if (fname.Text == "Firstname" && lname.Text == "Lastname")
            {
                fullname.Text = "";
                fullname.ForeColor = Color.Black;
            }
            else
            {
                fullname.Text = fname.Text + " " + lname.Text;
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
        private void ComboBox_username_Enter(object sender, EventArgs e)
        {
            if (comboBox_username.Text == "----Select/Add Username----")
            {
                comboBox_username.Text = "";

                comboBox_username.ForeColor = Color.Black;
            }
        }

        private void ComboBox_username_Leave(object sender, EventArgs e)
        {
            if (comboBox_username.Text == "")
            {
                comboBox_username.Text = "----Select/Add Username----";

                comboBox_username.ForeColor = Color.Silver;
            }
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr de vouloir fermer le programme?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        private void MainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage frm = new MainPage();
            frm.Show();

            this.Hide();
        }

        private void ADGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();

            this.Hide();
        }
        private void ADPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADpath aDpath = new ADpath();
            aDpath.Show();

            this.Hide();
        }
        private void PictureBox_back_Click(object sender, EventArgs e)
        {
            MainPage page = new MainPage();
            page.Show();

            this.Hide();
        }
        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox_username.Text = "----Select/Add Username----";
            comboBox_username.ForeColor = Color.Silver;
            // Refresh user list
            try
            {
                comboBox_username.Items.Clear();
                string ldap = toolStripTextBox_Ldap.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
                DirectoryEntry User = new DirectoryEntry(ldap, adusername, adpassword);
                DirectorySearcher searcher = new DirectorySearcher(User);
                {
                    searcher.Filter = ("objectClass=user");
                    String donneeDomaine = "";

                    foreach (SearchResult result in searcher.FindAll())
                    {
                        DirectoryEntry DirEntry = result.GetDirectoryEntry();
                        donneeDomaine = (donneeDomaine + DirEntry.Properties["SAMAccountName"].Value + "\r\n");

                    }
                    foreach (string line in donneeDomaine.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                    {
                        comboBox_username.Items.Add(line);
                    }
                }
            }
            catch
            {
            }
        }

        private void ComboBox_username_SelectedIndexChanged(object sender, EventArgs e)
        { 
            comboBox_username.Text = comboBox_username.SelectedItem.ToString();
            comboBox_username.ForeColor = Color.Black;
            if (comboBox_username.Text == "")
            {
                logon.Text = "Login"; fname.Text = "Firstname"; lname.Text = "Lastname"; fullname.Text = "FullName"; description.Text = "Description";
                logon.ForeColor = Color.Silver; fname.ForeColor = Color.Silver; lname.ForeColor = Color.Silver; fullname.ForeColor = Color.Silver; description.ForeColor = Color.Silver;
                return;
            }
            // Auto fill when a user is selected
            try
            {
                DirectoryEntry Ldap = new DirectoryEntry("LDAP://Forest.Gump", "Administrateur", "Serveur2019");
                DirectorySearcher searcher = new DirectorySearcher(Ldap);
                string searchusername = comboBox_username.Text;
                if (comboBox_username.Text == searchusername)
                {
                    searcher.Filter = ("sAMAccountName=" + searchusername);
                    String donneeUser = ""; String donneeName = ""; String donneeFname = ""; String donneeFull = ""; String donneeLogin = ""; String donneeDescription = "";
                    SearchResult result = searcher.FindOne();
                    if (result != null)
                    {
                        DirectoryEntry DirEntry = result.GetDirectoryEntry();
                        donneeUser = (donneeUser + DirEntry.Properties["SAMAccountname"].Value); donneeName = (donneeName + DirEntry.Properties["sn"].Value);
                        donneeFname = (donneeFname + DirEntry.Properties["givenName"].Value); donneeFull = (donneeFull + DirEntry.Properties["displayname"].Value);
                        donneeLogin = (donneeLogin + DirEntry.Properties["userPrincipalName"].Value); donneeDescription = (donneeDescription + DirEntry.Properties["description"].Value);
                    }
                    comboBox_username.ForeColor = Color.Black; lname.ForeColor = Color.Black; fname.ForeColor = Color.Black; fullname.ForeColor = Color.Black; logon.ForeColor = Color.Black; description.ForeColor = Color.Black;
                    comboBox_username.Text = (donneeUser); lname.Text = (donneeName); fname.Text = (donneeFname); fullname.Text = (donneeFull); logon.Text = (donneeLogin); description.Text = (donneeDescription);
                }
            }
            catch
            {
            }
        }

        private void LoadADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt";
            ofd.ShowDialog();

            // If the user doesn't select a file, cancels, or exists the dialogue box 
            // nothing is done.
            if (ofd.FileName == null || ofd.FileName.Equals("")) { }

            // Else if the user has selected a file, the file's text is converted when necessary, and used to change the value of the applications controls.
            else
            {
                // Get the contense of the txt file as a string array.
                string[] list = File.ReadAllLines(ofd.FileName);

                // Reads the text stored in the txt file and puts it as the value for the boxes.
                toolStripTextBox_Ldap.Text = list[0];
                toolStripTextBox_cn.Text = list[1];
                toolStripTextBox_username.Text = list[2];
                toolStripTextBox_password.Text = list[3];
                //
                toolStripTextBox_Ldap.ForeColor = Color.Black; toolStripTextBox_cn.ForeColor = Color.Black; toolStripTextBox_username.ForeColor = Color.Black; toolStripTextBox_password.ForeColor = Color.Black;
                string ldap = toolStripTextBox_Ldap.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
                try
                {
                    DirectoryEntry User = new DirectoryEntry(ldap, adusername, adpassword);
                    DirectorySearcher searcher = new DirectorySearcher(User);
                    toolStripTextBox_username.Text = "Connecté en :" + " " + adusername;
                    {
                        searcher.Filter = ("objectClass=user");
                        String donneeDomaine = "";

                        foreach (SearchResult result in searcher.FindAll())
                        {
                            DirectoryEntry DirEntry = result.GetDirectoryEntry();
                            donneeDomaine = (donneeDomaine + DirEntry.Properties["SAMAccountName"].Value + "\r\n");

                        }
                        foreach (string line in donneeDomaine.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                        {
                            comboBox_username.Items.Add(line);
                        }
                    }
                }
                catch
                {
                }
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

