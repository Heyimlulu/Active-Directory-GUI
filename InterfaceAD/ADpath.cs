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
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Drawing.Drawing2D;

namespace InterfacePowShell
{
    public partial class ADpath : Form
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
        public ADpath()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        private void LDAPpath_Enter(object sender, EventArgs e)
        {
            if (LDAPpath.Text == "LDAP://path")
            {
                LDAPpath.Text = "";
                LDAPpath.ForeColor = Color.Black;
            }
        }

        private void LDAPpath_Leave(object sender, EventArgs e)
        {
            if (LDAPpath.Text == "")
            {
                LDAPpath.Text = "LDAP://path";
                LDAPpath.ForeColor = Color.Silver;
            }
        }

        private void LDAPcn_Enter(object sender, EventArgs e)
        {
            if (LDAPcn.Text == "LDAP://CN=")
            {
                LDAPcn.Text = "";
                LDAPcn.ForeColor = Color.Black;
            }
        }

        private void LDAPcn_Leave(object sender, EventArgs e)
        {
            if (LDAPcn.Text == "")
            {
                LDAPcn.Text = "LDAP://CN=";
                LDAPcn.ForeColor = Color.Silver;
            }
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if (Username.Text == "Username")
            {
                Username.Text = "";
                Username.ForeColor = Color.Black;
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                Username.Text = "Username";
                Username.ForeColor = Color.Silver;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.Text = "";
                Password.ForeColor = Color.Black;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Password";
                Password.ForeColor = Color.Silver;
            }
        }

        private void PictureBox_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt";
            sfd.ShowDialog();
            string name = sfd.Title;
            string filePath = sfd.FileName;

            StreamWriter sw = new StreamWriter(filePath);
            // Write the text you want to the file.
            sw.WriteLine(LDAPpath.Text);
            sw.WriteLine(LDAPcn.Text);
            sw.WriteLine(Username.Text);
            sw.WriteLine(Password.Text);
            // You could do MyComboBox.SelectedItem if you evaluate what index the item 
            // belongs at when reading back the file for the load function.

            sw.Close();

        }

        private void PictureBox_Load_Click(object sender, EventArgs e)
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
                LDAPpath.Text = list[0];
                LDAPcn.Text = list[1];
                Username.Text = list[2];
                Password.Text = list[3];
                //
                LDAPpath.ForeColor = Color.Black; LDAPcn.ForeColor = Color.Black; Username.ForeColor = Color.Black; Password.ForeColor = Color.Black;
            }
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MainPage page = new MainPage();
            page.Show();

            this.Hide();
        }
    }
}
