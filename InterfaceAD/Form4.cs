using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Management.Automation;
using System.DirectoryServices.AccountManagement;

namespace InterfacePowShell
{
    public partial class Form4 : Form
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
        public Form4()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            comboBox_GroupAD.Text = "----Select/Add Group----";
            comboBox_GroupAD.ForeColor = Color.Silver;
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
        private void CheckBox_securite_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_securite.Checked == true)
            {
                checkBox_distribution.Enabled = false;
            }
            else
            {
                checkBox_distribution.Enabled = true;
            }
        }
        private void CheckBox_distribution_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_distribution.Checked == true)
            {
                checkBox_securite.Enabled = false;
            }
            else
            {
                checkBox_securite.Enabled = true;
            }
        }
        private void Btn_AddGroup_Click(object sender, EventArgs e)
        {
            AddGroup addgroup = new AddGroup();
            addgroup.name = comboBox_GroupAD.Text;
            addgroup.description = txtbox_description.Text;
            // To do 
            // Security and Distribution
            //
            addgroup.NewGroup();
            /*
            try
            {
                string name = comboBox_GroupAD.Text; string description = txtbox_description.Text;
                string ldap = toolStripTextBox_Ldap.Text; string cn = toolStripTextBox_cn.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
                DirectoryEntry dirEntry = new DirectoryEntry(ldap, adusername, adpassword);
                dirEntry.Path = cn;
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
                if (comboBox_GroupAD.Text == "----Select/Add Group----")
                {
                    MessageBox.Show("Invalid group name!", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (checkBox_securite.Checked == false && checkBox_distribution.Checked == false)
                {
                    MessageBox.Show("Please select a group category!", "No entry", MessageBoxButtons.OK);
                    return;
                }
                // set properties
                group.Properties["sAmAccountName"].Add(name); group.Properties["Description"].Add(description);
                if (checkBox_distribution.Checked == true)
                {
                    group.Properties["groupType"].Value = ActiveDs.ADS_GROUP_TYPE_ENUM.ADS_GROUP_TYPE_GLOBAL_GROUP;
                }
                if (checkBox_securite.Checked == true)
                {
                    group.Properties["groupType"].Value = ActiveDs.ADS_GROUP_TYPE_ENUM.ADS_GROUP_TYPE_GLOBAL_GROUP | ActiveDs.ADS_GROUP_TYPE_ENUM.ADS_GROUP_TYPE_SECURITY_ENABLED;
                }
                // save group
                group.CommitChanges();
                comboBox_GroupAD.Text = "----Select/Add Group----"; comboBox_GroupAD.ForeColor = Color.Silver; txtbox_description.Text = "Description (optional)"; txtbox_description.ForeColor = Color.Silver;
                checkBox_distribution.Checked = false; checkBox_securite.Checked = false;
                MessageBox.Show("Le groupe a été crée avec succés!", "Done", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Chemin d'accès au serveur invalide ou non existant!", "No entry", MessageBoxButtons.OK);
                return;
            }
            try
            {
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
                        listBox_User.Items.Add(line);
                    }
                }
            }
            catch
            {
            }
            try
            {
                comboBox_GroupAD.Items.Clear();
                string ldap = toolStripTextBox_Ldap.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
                DirectoryEntry Group = new DirectoryEntry(ldap, adusername, adpassword);
                DirectorySearcher searcher = new DirectorySearcher(Group);
                {
                    searcher.Filter = ("objectClass=group");
                    String donneeDomaine = "";

                    foreach (SearchResult result in searcher.FindAll())
                    {
                        DirectoryEntry DirEntry = result.GetDirectoryEntry();
                        donneeDomaine = (donneeDomaine + DirEntry.Properties["SAMAccountName"].Value + "\r\n");

                    }
                    foreach (string line in donneeDomaine.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                    {
                        comboBox_GroupAD.Items.Add(line);
                    }
                }
            }
            catch
            {
            }
            */
        }

        private void Btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                string Group = comboBox_GroupAD.GetItemText(comboBox_GroupAD.SelectedItem);
                string ldap = toolStripTextBox_Ldap.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
                DirectoryEntry dirEntry = new DirectoryEntry(ldap, adusername, adpassword);
                // set up domain context
                PrincipalContext ctx = new PrincipalContext(ContextType.Domain);
                // find the user you want to delete
                GroupPrincipal group = GroupPrincipal.FindByIdentity(ctx, Group);
                if (comboBox_GroupAD.Text == "----Select/Add Group----")
                {
                    MessageBox.Show("Le groupe n'existe pas!", "Error", MessageBoxButtons.OK);
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Souhaitez-vous supprimer définitivement ce groupe?", "Validation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    comboBox_GroupAD.Text = "----Select/Add Group----"; comboBox_GroupAD.ForeColor = Color.Silver;
                    MessageBox.Show("Le groupe a été supprimé avec succés", "Done", MessageBoxButtons.OK);
                    group.Delete();
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
            catch
            {
                MessageBox.Show("Chemin d'accès au serveur invalide ou non existant!", "No entry", MessageBoxButtons.OK);
                return;
            }
            try
            {
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
                        listBox_User.Items.Add(line);
                    }
                }
            }
            catch
            {
            }
            try
            {
                comboBox_GroupAD.Items.Clear();
                string ldap = toolStripTextBox_Ldap.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
                DirectoryEntry Group = new DirectoryEntry(ldap, adusername, adpassword);
                DirectorySearcher searcher = new DirectorySearcher(Group);
                {
                    searcher.Filter = ("objectClass=group");
                    String donneeDomaine = "";

                    foreach (SearchResult result in searcher.FindAll())
                    {
                        DirectoryEntry DirEntry = result.GetDirectoryEntry();
                        donneeDomaine = (donneeDomaine + DirEntry.Properties["SAMAccountName"].Value + "\r\n");

                    }
                    foreach (string line in donneeDomaine.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                    {
                        comboBox_GroupAD.Items.Add(line);
                    }
                }
            }
            catch
            {
            }
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            EditGroup editgroup = new EditGroup();
            editgroup.name = comboBox_GroupAD.Text;
            editgroup.description = txtbox_description.Text;
            editgroup.UpdateGroup();
            /*
            // Connexion à L'AD
            try
            {
                string ldap = toolStripTextBox_Ldap.Text; string cn = toolStripTextBox_cn.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
                DirectoryEntry dirEntry = new DirectoryEntry(ldap, adusername, adpassword);
                DirectorySearcher searcher = new DirectorySearcher(cn);
                string Group = comboBox_GroupAD.GetItemText(comboBox_GroupAD.SelectedItem); string group = comboBox_GroupAD.Text; string description = txtbox_description.Text;
                searcher.Filter = ("sAMAccountName=" + Group);

                SearchResult result = searcher.FindOne();
                if (result != null)
                {
                    // create new object from search result    
                    DirectoryEntry entryToUpdate = result.GetDirectoryEntry();
                    if (comboBox_GroupAD.Text == "----Select/Add Group----")
                    {
                        MessageBox.Show("Le groupe n'existe pas!", "Error", MessageBoxButtons.OK);
                        return;
                    }
                    if (checkBox_securite.Checked == false && checkBox_distribution.Checked == false)
                    {
                        MessageBox.Show("Please select a group category!", "No entry", MessageBoxButtons.OK);
                        return;
                    }
                    entryToUpdate.Properties["SAMAccountName"].Value = (group);
                    entryToUpdate.Properties["Description"].Value = (description);
                    if (checkBox_distribution.Checked == true)
                    {
                        entryToUpdate.Properties["groupType"].Value = ActiveDs.ADS_GROUP_TYPE_ENUM.ADS_GROUP_TYPE_GLOBAL_GROUP;
                    }
                    if (checkBox_securite.Checked == true)
                    {
                        entryToUpdate.Properties["groupType"].Value = ActiveDs.ADS_GROUP_TYPE_ENUM.ADS_GROUP_TYPE_GLOBAL_GROUP | ActiveDs.ADS_GROUP_TYPE_ENUM.ADS_GROUP_TYPE_SECURITY_ENABLED;
                    }
                    entryToUpdate.CommitChanges();
                    comboBox_GroupAD.Text = "----Select/Add Group----"; comboBox_GroupAD.ForeColor = Color.Silver; txtbox_description.Text = "Description (optional)"; txtbox_description.ForeColor = Color.Silver;
                    checkBox_distribution.Checked = false; checkBox_securite.Checked = false;
                    MessageBox.Show("Le groupe a été mis a jour!", "Done", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Chemin d'accès au serveur invalide ou non existant!", "No entry", MessageBoxButtons.OK);
                return;
            }
            try
            {
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
                        listBox_User.Items.Add(line);
                    }
                }
            }
            catch
            {
            }
            try
            {
                comboBox_GroupAD.Items.Clear();
                string ldap = toolStripTextBox_Ldap.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
                DirectoryEntry Group = new DirectoryEntry(ldap, adusername, adpassword);
                DirectorySearcher searcher = new DirectorySearcher(Group);
                {
                    searcher.Filter = ("objectClass=group");
                    String donneeDomaine = "";

                    foreach (SearchResult result in searcher.FindAll())
                    {
                        DirectoryEntry DirEntry = result.GetDirectoryEntry();
                        donneeDomaine = (donneeDomaine + DirEntry.Properties["SAMAccountName"].Value + "\r\n");

                    }
                    foreach (string line in donneeDomaine.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                    {
                        comboBox_GroupAD.Items.Add(line);
                    }
                }
            }
            catch
            {
            }
            */
        }
        private void Btn_AddUsertoGroup_Click(object sender, EventArgs e)
        {
            try
            {
                string ldap = toolStripTextBox_Ldap.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
                string Group = comboBox_GroupAD.GetItemText(comboBox_GroupAD.SelectedItem); string username = listBox_User.GetItemText(listBox_User.SelectedItem);
                DirectoryEntry AddUsertoGroup = new DirectoryEntry(ldap, adusername, adpassword);
                using (PrincipalContext pc = new PrincipalContext(ContextType.Domain))
                {
                    if (comboBox_GroupAD.Text == "----Select Group----" && listBox_User.Text == "")
                    {
                        MessageBox.Show("Please select a valid group name", "No Entry", MessageBoxButtons.OK);
                        return;
                    }
                    GroupPrincipal group = GroupPrincipal.FindByIdentity(pc, Group);
                    group.Members.Add(pc, IdentityType.UserPrincipalName, username);
                    comboBox_GroupAD.Text = "---Select Group----"; comboBox_GroupAD.ForeColor = Color.Silver;
                    group.Save();
                }
                MessageBox.Show("L'utilisateur a été ajouté au groupe avec succés!", "DONE", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Chemin d'accès au serveur invalide ou non existant!", "No entry", MessageBoxButtons.OK);
                return;
            }
            try
            {
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
                        listBox_User.Items.Add(line);
                    }
                }
            }
            catch
            {
            }
            try
            {
                comboBox_GroupAD.Items.Clear();
                string ldap = toolStripTextBox_Ldap.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
                DirectoryEntry Group = new DirectoryEntry(ldap, adusername, adpassword);
                DirectorySearcher searcher = new DirectorySearcher(Group);
                {
                    searcher.Filter = ("objectClass=group");
                    String donneeDomaine = "";

                    foreach (SearchResult result in searcher.FindAll())
                    {
                        DirectoryEntry DirEntry = result.GetDirectoryEntry();
                        donneeDomaine = (donneeDomaine + DirEntry.Properties["SAMAccountName"].Value + "\r\n");

                    }
                    foreach (string line in donneeDomaine.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                    {
                        comboBox_GroupAD.Items.Add(line);
                    }
                }
            }
            catch
            {
            }
        }
        private void Btn_RemoveUsertoGroup_Click(object sender, EventArgs e)
        {
            try
            {
                string ldap = toolStripTextBox_Ldap.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
                string Group = comboBox_GroupAD.GetItemText(comboBox_GroupAD.SelectedItem); string username = listBox_User.GetItemText(listBox_User.SelectedItem);
                DirectoryEntry AddUsertoGroup = new DirectoryEntry(ldap, adusername, adpassword);
                using (PrincipalContext pc = new PrincipalContext(ContextType.Domain))
                {
                    if (comboBox_GroupAD.Text == "----Select Group----" && listBox_User.Text == "")
                    {
                        MessageBox.Show("Please select a valid group name", "No Entry", MessageBoxButtons.OK);
                        return;
                    }
                    DialogResult dialogResult = MessageBox.Show("Souhaitez-vous supprimer définitivement ce groupe?", "Validation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        comboBox_GroupAD.Text = "---Select Group----"; comboBox_GroupAD.ForeColor = Color.Silver;
                        GroupPrincipal group = GroupPrincipal.FindByIdentity(pc, Group);
                        group.Members.Remove(pc, IdentityType.UserPrincipalName, username);
                        group.Save();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }
                }
                MessageBox.Show("L'utilisateur a été supprimé du groupe avec succés!", "DONE", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Chemin d'accès au serveur invalide ou non existant!", "No entry", MessageBoxButtons.OK);
                return;
            }
            try
            {
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
                        listBox_User.Items.Add(line);
                    }
                }
            }
            catch
            {
            }
            try
            {
                comboBox_GroupAD.Items.Clear();
                string ldap = toolStripTextBox_Ldap.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
                DirectoryEntry Group = new DirectoryEntry(ldap, adusername, adpassword);
                DirectorySearcher searcher = new DirectorySearcher(Group);
                {
                    searcher.Filter = ("objectClass=group");
                    String donneeDomaine = "";

                    foreach (SearchResult result in searcher.FindAll())
                    {
                        DirectoryEntry DirEntry = result.GetDirectoryEntry();
                        donneeDomaine = (donneeDomaine + DirEntry.Properties["SAMAccountName"].Value + "\r\n");

                    }
                    foreach (string line in donneeDomaine.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                    {
                        comboBox_GroupAD.Items.Add(line);
                    }
                }
            }
            catch
            {
            }
        }

        private void Txtbox_description_Enter(object sender, EventArgs e)
        {
            if (txtbox_description.Text == "Description (optional)")
            {
                txtbox_description.Text = "";
                txtbox_description.ForeColor = Color.Black;
            }
        }

        private void Txtbox_description_Leave(object sender, EventArgs e)
        {
            if (txtbox_description.Text == "")
            {
                txtbox_description.Text = "Description (optional)";
                txtbox_description.ForeColor = Color.Silver;
            }
        }

        private void ComboBox_GroupAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_GroupAD.Text = comboBox_GroupAD.SelectedItem.ToString();
            comboBox_GroupAD.ForeColor = Color.Black;
        }
        private void ComboBox_GroupAD_Enter(object sender, EventArgs e)
        {
            if (comboBox_GroupAD.Text == "----Select Group----")
            {
                comboBox_GroupAD.Text = "";
                comboBox_GroupAD.ForeColor = Color.Silver;
            }
        }

        private void ComboBox_GroupAD_Leave(object sender, EventArgs e)
        {
            if (comboBox_GroupAD.Text == "")
            {
                comboBox_GroupAD.Text = "----Select Group----";
                comboBox_GroupAD.ForeColor = Color.Silver;
            }
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox_GroupAD.Text = "----Select Group----";
            comboBox_GroupAD.ForeColor = Color.Silver;
            string ldap = toolStripTextBox_Ldap.Text; string adusername = toolStripTextBox_username.Text; string adpassword = toolStripTextBox_password.Text;
            try
            {
                listBox_User.Items.Clear();
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
                        listBox_User.Items.Add(line);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Chemin d'accès au serveur invalide ou non existant!", "No entry", MessageBoxButtons.OK);
                return;
            }
            try
            {
                comboBox_GroupAD.Items.Clear();
                DirectoryEntry Group = new DirectoryEntry(ldap, adusername, adpassword);
                DirectorySearcher searcher = new DirectorySearcher(Group);
                {
                    searcher.Filter = ("objectClass=group");
                    String donneeDomaine = "";

                    foreach (SearchResult result in searcher.FindAll())
                    {
                        DirectoryEntry DirEntry = result.GetDirectoryEntry();
                        donneeDomaine = (donneeDomaine + DirEntry.Properties["SAMAccountName"].Value + "\r\n");

                    }
                    foreach (string line in donneeDomaine.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                    {
                        comboBox_GroupAD.Items.Add(line);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Chemin d'accès au serveur invalide ou non existant!", "No entry", MessageBoxButtons.OK);
                return;
            }
        }

        private void MainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage frm = new MainPage();
            frm.Show();

            this.Hide();
        }

        private void ADUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewADUser ad = new NewADUser();
            ad.Show();

            this.Hide();
        }

        private void ADpathToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
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
                            listBox_User.Items.Add(line);
                        }
                    }
                }
                catch
                {
                }
                try
                {
                    comboBox_GroupAD.Items.Clear();
                    DirectoryEntry Group = new DirectoryEntry(ldap, adusername, adpassword);
                    DirectorySearcher searcher = new DirectorySearcher(Group);
                    {
                        searcher.Filter = ("objectClass=group");
                        String donneeDomaine = "";

                        foreach (SearchResult result in searcher.FindAll())
                        {
                            DirectoryEntry DirEntry = result.GetDirectoryEntry();
                            donneeDomaine = (donneeDomaine + DirEntry.Properties["SAMAccountName"].Value + "\r\n");

                        }
                        foreach (string line in donneeDomaine.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                        {
                            comboBox_GroupAD.Items.Add(line);
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
