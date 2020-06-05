namespace InterfacePowShell
{
    partial class ADpath
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADpath));
            this.label_aduser = new System.Windows.Forms.Label();
            this.panel_move = new System.Windows.Forms.Panel();
            this.pictureBox_back = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_Save = new System.Windows.Forms.PictureBox();
            this.pictureBox_Load = new System.Windows.Forms.PictureBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.LDAPcn = new System.Windows.Forms.TextBox();
            this.LDAPpath = new System.Windows.Forms.TextBox();
            this.pictureBox_Minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_move.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // label_aduser
            // 
            this.label_aduser.AutoSize = true;
            this.label_aduser.BackColor = System.Drawing.Color.DarkMagenta;
            this.label_aduser.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_aduser.ForeColor = System.Drawing.Color.Black;
            this.label_aduser.Location = new System.Drawing.Point(394, 19);
            this.label_aduser.Name = "label_aduser";
            this.label_aduser.Size = new System.Drawing.Size(187, 59);
            this.label_aduser.TabIndex = 67;
            this.label_aduser.Text = "AD Path";
            this.label_aduser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_aduser_MouseDown);
            // 
            // panel_move
            // 
            this.panel_move.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel_move.Controls.Add(this.pictureBox_back);
            this.panel_move.Location = new System.Drawing.Point(-6, -1);
            this.panel_move.Name = "panel_move";
            this.panel_move.Size = new System.Drawing.Size(986, 100);
            this.panel_move.TabIndex = 69;
            this.panel_move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_move_MouseDown);
            // 
            // pictureBox_back
            // 
            this.pictureBox_back.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_back.Image = global::InterfacePowShell.Properties.Resources.icons8_retour_96;
            this.pictureBox_back.Location = new System.Drawing.Point(18, 10);
            this.pictureBox_back.Name = "pictureBox_back";
            this.pictureBox_back.Size = new System.Drawing.Size(129, 87);
            this.pictureBox_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_back.TabIndex = 72;
            this.pictureBox_back.TabStop = false;
            this.pictureBox_back.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox_Save);
            this.panel1.Controls.Add(this.pictureBox_Load);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.LDAPcn);
            this.panel1.Controls.Add(this.LDAPpath);
            this.panel1.Location = new System.Drawing.Point(122, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 330);
            this.panel1.TabIndex = 71;
            // 
            // pictureBox_Save
            // 
            this.pictureBox_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Save.Image = global::InterfacePowShell.Properties.Resources.icons8_sauvegarder_32;
            this.pictureBox_Save.Location = new System.Drawing.Point(610, 277);
            this.pictureBox_Save.Name = "pictureBox_Save";
            this.pictureBox_Save.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Save.TabIndex = 72;
            this.pictureBox_Save.TabStop = false;
            this.pictureBox_Save.Click += new System.EventHandler(this.PictureBox_Save_Click);
            // 
            // pictureBox_Load
            // 
            this.pictureBox_Load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Load.Image = global::InterfacePowShell.Properties.Resources.icons8_ouvrir_le_document_32;
            this.pictureBox_Load.Location = new System.Drawing.Point(672, 277);
            this.pictureBox_Load.Name = "pictureBox_Load";
            this.pictureBox_Load.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Load.TabIndex = 73;
            this.pictureBox_Load.TabStop = false;
            this.pictureBox_Load.Click += new System.EventHandler(this.PictureBox_Load_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Silver;
            this.Password.Location = new System.Drawing.Point(393, 202);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(280, 47);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.White;
            this.Username.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Silver;
            this.Username.Location = new System.Drawing.Point(57, 202);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(280, 47);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            this.Username.Enter += new System.EventHandler(this.Username_Enter);
            this.Username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // LDAPcn
            // 
            this.LDAPcn.BackColor = System.Drawing.Color.White;
            this.LDAPcn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDAPcn.ForeColor = System.Drawing.Color.Silver;
            this.LDAPcn.Location = new System.Drawing.Point(393, 82);
            this.LDAPcn.Name = "LDAPcn";
            this.LDAPcn.Size = new System.Drawing.Size(280, 47);
            this.LDAPcn.TabIndex = 1;
            this.LDAPcn.Text = "LDAP://CN=";
            this.LDAPcn.Enter += new System.EventHandler(this.LDAPcn_Enter);
            this.LDAPcn.Leave += new System.EventHandler(this.LDAPcn_Leave);
            // 
            // LDAPpath
            // 
            this.LDAPpath.BackColor = System.Drawing.Color.White;
            this.LDAPpath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDAPpath.ForeColor = System.Drawing.Color.Silver;
            this.LDAPpath.Location = new System.Drawing.Point(57, 82);
            this.LDAPpath.Name = "LDAPpath";
            this.LDAPpath.Size = new System.Drawing.Size(280, 47);
            this.LDAPpath.TabIndex = 0;
            this.LDAPpath.Text = "LDAP://path";
            this.LDAPpath.Enter += new System.EventHandler(this.LDAPpath_Enter);
            this.LDAPpath.Leave += new System.EventHandler(this.LDAPpath_Leave);
            // 
            // pictureBox_Minimize
            // 
            this.pictureBox_Minimize.BackColor = System.Drawing.Color.DarkMagenta;
            this.pictureBox_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Minimize.Image = global::InterfacePowShell.Properties.Resources.icons8_moins_24;
            this.pictureBox_Minimize.InitialImage = global::InterfacePowShell.Properties.Resources.icons8_moins_24;
            this.pictureBox_Minimize.Location = new System.Drawing.Point(879, 19);
            this.pictureBox_Minimize.Name = "pictureBox_Minimize";
            this.pictureBox_Minimize.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Minimize.TabIndex = 70;
            this.pictureBox_Minimize.TabStop = false;
            this.pictureBox_Minimize.Click += new System.EventHandler(this.PictureBox_Minimize_Click);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.BackColor = System.Drawing.Color.DarkMagenta;
            this.pictureBox_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Close.Image = global::InterfacePowShell.Properties.Resources.icons8_multiplier_50;
            this.pictureBox_Close.InitialImage = global::InterfacePowShell.Properties.Resources.icons8_multiplier_50;
            this.pictureBox_Close.Location = new System.Drawing.Point(922, 19);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Close.TabIndex = 68;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.PictureBox_Close_Click);
            // 
            // ADpath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(974, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_Minimize);
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.label_aduser);
            this.Controls.Add(this.panel_move);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ADpath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADpath";
            this.panel_move.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Minimize;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.Label label_aduser;
        private System.Windows.Forms.Panel panel_move;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox LDAPcn;
        private System.Windows.Forms.TextBox LDAPpath;
        private System.Windows.Forms.PictureBox pictureBox_Save;
        private System.Windows.Forms.PictureBox pictureBox_Load;
        private System.Windows.Forms.PictureBox pictureBox_back;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}