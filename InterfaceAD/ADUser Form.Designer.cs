namespace InterfacePowShell
{
    partial class NewADUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewADUser));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label_aduser = new System.Windows.Forms.Label();
            this.panel_move = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.description = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.Btn_RemoveUser = new System.Windows.Forms.Button();
            this.fullname = new System.Windows.Forms.TextBox();
            this.Btn_EditUser = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.logon = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.Btn_AddUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_base = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_username = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox_Minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox_Ldap = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_cn = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_username = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_password = new System.Windows.Forms.ToolStripTextBox();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel_base.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // label_aduser
            // 
            this.label_aduser.AutoSize = true;
            this.label_aduser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label_aduser.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_aduser.ForeColor = System.Drawing.Color.Black;
            this.label_aduser.Location = new System.Drawing.Point(400, 19);
            this.label_aduser.Name = "label_aduser";
            this.label_aduser.Size = new System.Drawing.Size(175, 59);
            this.label_aduser.TabIndex = 0;
            this.label_aduser.Text = "ADUser";
            this.label_aduser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_aduser_MouseDown);
            // 
            // panel_move
            // 
            this.panel_move.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_move.Location = new System.Drawing.Point(-7, 3);
            this.panel_move.Name = "panel_move";
            this.panel_move.Size = new System.Drawing.Size(986, 100);
            this.panel_move.TabIndex = 23;
            this.panel_move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_move_MouseDown);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel18.Location = new System.Drawing.Point(128, 221);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(475, 5);
            this.panel18.TabIndex = 46;
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.White;
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Silver;
            this.description.Location = new System.Drawing.Point(73, 606);
            this.description.Margin = new System.Windows.Forms.Padding(6);
            this.description.MaxLength = 60;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(587, 40);
            this.description.TabIndex = 15;
            this.description.Text = "Description (optional)";
            this.description.Enter += new System.EventHandler(this.Description_Enter);
            this.description.Leave += new System.EventHandler(this.Description_Leave);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Silver;
            this.password.Location = new System.Drawing.Point(371, 267);
            this.password.Margin = new System.Windows.Forms.Padding(6);
            this.password.MaxLength = 30;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(304, 40);
            this.password.TabIndex = 11;
            this.password.Text = "Password";
            this.password.Enter += new System.EventHandler(this.Password_Enter);
            this.password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel16.Location = new System.Drawing.Point(75, 321);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(284, 5);
            this.panel16.TabIndex = 50;
            // 
            // Btn_RemoveUser
            // 
            this.Btn_RemoveUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_RemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RemoveUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RemoveUser.ForeColor = System.Drawing.Color.White;
            this.Btn_RemoveUser.Location = new System.Drawing.Point(72, 722);
            this.Btn_RemoveUser.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_RemoveUser.Name = "Btn_RemoveUser";
            this.Btn_RemoveUser.Size = new System.Drawing.Size(154, 98);
            this.Btn_RemoveUser.TabIndex = 16;
            this.Btn_RemoveUser.Text = "Remove";
            this.Btn_RemoveUser.UseVisualStyleBackColor = false;
            this.Btn_RemoveUser.Click += new System.EventHandler(this.Btn_RemoveUser_Click);
            // 
            // fullname
            // 
            this.fullname.BackColor = System.Drawing.Color.White;
            this.fullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fullname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.ForeColor = System.Drawing.Color.Silver;
            this.fullname.Location = new System.Drawing.Point(73, 501);
            this.fullname.Margin = new System.Windows.Forms.Padding(6);
            this.fullname.MaxLength = 50;
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(587, 40);
            this.fullname.TabIndex = 14;
            this.fullname.Text = "FullName";
            this.fullname.Enter += new System.EventHandler(this.Fullname_Enter);
            this.fullname.Leave += new System.EventHandler(this.Fullname_Leave);
            // 
            // Btn_EditUser
            // 
            this.Btn_EditUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_EditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EditUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditUser.ForeColor = System.Drawing.Color.White;
            this.Btn_EditUser.Location = new System.Drawing.Point(505, 722);
            this.Btn_EditUser.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_EditUser.Name = "Btn_EditUser";
            this.Btn_EditUser.Size = new System.Drawing.Size(154, 98);
            this.Btn_EditUser.TabIndex = 18;
            this.Btn_EditUser.Text = "Edit";
            this.Btn_EditUser.UseVisualStyleBackColor = false;
            this.Btn_EditUser.Click += new System.EventHandler(this.Btn_EditUser_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel6.Location = new System.Drawing.Point(376, 321);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(299, 5);
            this.panel6.TabIndex = 42;
            // 
            // logon
            // 
            this.logon.BackColor = System.Drawing.Color.White;
            this.logon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logon.ForeColor = System.Drawing.Color.Silver;
            this.logon.Location = new System.Drawing.Point(75, 267);
            this.logon.Margin = new System.Windows.Forms.Padding(6);
            this.logon.MaxLength = 30;
            this.logon.Name = "logon";
            this.logon.Size = new System.Drawing.Size(284, 40);
            this.logon.TabIndex = 10;
            this.logon.Text = "Login";
            this.logon.Enter += new System.EventHandler(this.Logon_Enter);
            this.logon.Leave += new System.EventHandler(this.Logon_Leave);
            // 
            // lname
            // 
            this.lname.BackColor = System.Drawing.Color.White;
            this.lname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.ForeColor = System.Drawing.Color.Silver;
            this.lname.Location = new System.Drawing.Point(371, 400);
            this.lname.Margin = new System.Windows.Forms.Padding(6);
            this.lname.MaxLength = 30;
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(286, 40);
            this.lname.TabIndex = 13;
            this.lname.Text = "Lastname";
            this.lname.Enter += new System.EventHandler(this.Lname_Enter);
            this.lname.Leave += new System.EventHandler(this.Lname_Leave);
            // 
            // fname
            // 
            this.fname.BackColor = System.Drawing.Color.White;
            this.fname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.ForeColor = System.Drawing.Color.Silver;
            this.fname.Location = new System.Drawing.Point(70, 400);
            this.fname.Margin = new System.Windows.Forms.Padding(6);
            this.fname.MaxLength = 30;
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(289, 40);
            this.fname.TabIndex = 12;
            this.fname.Text = "Firstname";
            this.fname.Enter += new System.EventHandler(this.Fname_Enter);
            this.fname.Leave += new System.EventHandler(this.Fname_Leave);
            // 
            // Btn_AddUser
            // 
            this.Btn_AddUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddUser.ForeColor = System.Drawing.Color.White;
            this.Btn_AddUser.Location = new System.Drawing.Point(238, 722);
            this.Btn_AddUser.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_AddUser.Name = "Btn_AddUser";
            this.Btn_AddUser.Size = new System.Drawing.Size(255, 98);
            this.Btn_AddUser.TabIndex = 17;
            this.Btn_AddUser.Text = "Add User";
            this.Btn_AddUser.UseVisualStyleBackColor = false;
            this.Btn_AddUser.Click += new System.EventHandler(this.Btn_AddUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(371, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 5);
            this.panel1.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Location = new System.Drawing.Point(70, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 5);
            this.panel2.TabIndex = 51;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Location = new System.Drawing.Point(70, 553);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(587, 5);
            this.panel3.TabIndex = 43;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Location = new System.Drawing.Point(73, 658);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(587, 5);
            this.panel4.TabIndex = 43;
            // 
            // panel_base
            // 
            this.panel_base.BackColor = System.Drawing.Color.White;
            this.panel_base.Controls.Add(this.label1);
            this.panel_base.Controls.Add(this.comboBox_username);
            this.panel_base.Controls.Add(this.Btn_AddUser);
            this.panel_base.Controls.Add(this.panel4);
            this.panel_base.Controls.Add(this.fname);
            this.panel_base.Controls.Add(this.panel3);
            this.panel_base.Controls.Add(this.lname);
            this.panel_base.Controls.Add(this.panel2);
            this.panel_base.Controls.Add(this.logon);
            this.panel_base.Controls.Add(this.panel1);
            this.panel_base.Controls.Add(this.panel6);
            this.panel_base.Controls.Add(this.panel18);
            this.panel_base.Controls.Add(this.Btn_EditUser);
            this.panel_base.Controls.Add(this.fullname);
            this.panel_base.Controls.Add(this.description);
            this.panel_base.Controls.Add(this.Btn_RemoveUser);
            this.panel_base.Controls.Add(this.password);
            this.panel_base.Controls.Add(this.panel16);
            this.panel_base.Location = new System.Drawing.Point(122, 156);
            this.panel_base.Name = "panel_base";
            this.panel_base.Size = new System.Drawing.Size(730, 864);
            this.panel_base.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(219, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 59);
            this.label1.TabIndex = 98;
            this.label1.Text = "Add a User ...";
            // 
            // comboBox_username
            // 
            this.comboBox_username.BackColor = System.Drawing.Color.White;
            this.comboBox_username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_username.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_username.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_username.FormattingEnabled = true;
            this.comboBox_username.Location = new System.Drawing.Point(128, 163);
            this.comboBox_username.Name = "comboBox_username";
            this.comboBox_username.Size = new System.Drawing.Size(475, 47);
            this.comboBox_username.TabIndex = 52;
            this.comboBox_username.Text = "----Select/Add Username----";
            this.comboBox_username.SelectedIndexChanged += new System.EventHandler(this.ComboBox_username_SelectedIndexChanged);
            this.comboBox_username.Enter += new System.EventHandler(this.ComboBox_username_Enter);
            this.comboBox_username.Leave += new System.EventHandler(this.ComboBox_username_Leave);
            // 
            // pictureBox_Minimize
            // 
            this.pictureBox_Minimize.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Minimize.Image = global::InterfacePowShell.Properties.Resources.icons8_moins_24;
            this.pictureBox_Minimize.InitialImage = global::InterfacePowShell.Properties.Resources.icons8_moins_24;
            this.pictureBox_Minimize.Location = new System.Drawing.Point(878, 23);
            this.pictureBox_Minimize.Name = "pictureBox_Minimize";
            this.pictureBox_Minimize.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Minimize.TabIndex = 24;
            this.pictureBox_Minimize.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox_Minimize, "Réduire");
            this.pictureBox_Minimize.Click += new System.EventHandler(this.PictureBox_Minimize_Click);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Close.Image = global::InterfacePowShell.Properties.Resources.icons8_multiplier_50;
            this.pictureBox_Close.InitialImage = global::InterfacePowShell.Properties.Resources.icons8_multiplier_50;
            this.pictureBox_Close.Location = new System.Drawing.Point(921, 23);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Close.TabIndex = 22;
            this.pictureBox_Close.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox_Close, "Quitter");
            this.pictureBox_Close.Click += new System.EventHandler(this.PictureBox_Close_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editToolStripMenuItem,
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 41);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuStrip1_MouseDown);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadADToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fichierToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(75, 37);
            this.fichierToolStripMenuItem.Text = "File";
            // 
            // loadADToolStripMenuItem
            // 
            this.loadADToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.loadADToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.loadADToolStripMenuItem.Name = "loadADToolStripMenuItem";
            this.loadADToolStripMenuItem.Size = new System.Drawing.Size(241, 44);
            this.loadADToolStripMenuItem.Text = "Load AD";
            this.loadADToolStripMenuItem.Click += new System.EventHandler(this.LoadADToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(238, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(241, 44);
            this.exitToolStripMenuItem.Text = "Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripTextBox_Ldap,
            this.toolStripTextBox_cn,
            this.toolStripTextBox_username,
            this.toolStripTextBox_password});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(78, 37);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.refreshToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(419, 44);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(416, 6);
            // 
            // toolStripTextBox_Ldap
            // 
            this.toolStripTextBox_Ldap.BackColor = System.Drawing.Color.White;
            this.toolStripTextBox_Ldap.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox_Ldap.ForeColor = System.Drawing.Color.Silver;
            this.toolStripTextBox_Ldap.Name = "toolStripTextBox_Ldap";
            this.toolStripTextBox_Ldap.ReadOnly = true;
            this.toolStripTextBox_Ldap.Size = new System.Drawing.Size(300, 37);
            this.toolStripTextBox_Ldap.Text = "LDAP://path";
            // 
            // toolStripTextBox_cn
            // 
            this.toolStripTextBox_cn.BackColor = System.Drawing.Color.White;
            this.toolStripTextBox_cn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox_cn.ForeColor = System.Drawing.Color.Silver;
            this.toolStripTextBox_cn.Name = "toolStripTextBox_cn";
            this.toolStripTextBox_cn.ReadOnly = true;
            this.toolStripTextBox_cn.Size = new System.Drawing.Size(300, 37);
            this.toolStripTextBox_cn.Text = "LDAP://CN=";
            // 
            // toolStripTextBox_username
            // 
            this.toolStripTextBox_username.BackColor = System.Drawing.Color.White;
            this.toolStripTextBox_username.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox_username.ForeColor = System.Drawing.Color.Silver;
            this.toolStripTextBox_username.Name = "toolStripTextBox_username";
            this.toolStripTextBox_username.ReadOnly = true;
            this.toolStripTextBox_username.Size = new System.Drawing.Size(300, 37);
            this.toolStripTextBox_username.Text = "Connecté en :";
            // 
            // toolStripTextBox_password
            // 
            this.toolStripTextBox_password.BackColor = System.Drawing.Color.White;
            this.toolStripTextBox_password.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox_password.ForeColor = System.Drawing.Color.Silver;
            this.toolStripTextBox_password.Name = "toolStripTextBox_password";
            this.toolStripTextBox_password.ReadOnly = true;
            this.toolStripTextBox_password.Size = new System.Drawing.Size(300, 37);
            this.toolStripTextBox_password.Text = "Password";
            this.toolStripTextBox_password.Visible = false;
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainPageToolStripMenuItem,
            this.aDGroupsToolStripMenuItem,
            this.aDPathToolStripMenuItem});
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(124, 37);
            this.openToolStripMenuItem.Text = "Go to ...";
            // 
            // mainPageToolStripMenuItem
            // 
            this.mainPageToolStripMenuItem.Name = "mainPageToolStripMenuItem";
            this.mainPageToolStripMenuItem.Size = new System.Drawing.Size(266, 44);
            this.mainPageToolStripMenuItem.Text = "Main Page";
            this.mainPageToolStripMenuItem.Click += new System.EventHandler(this.MainPageToolStripMenuItem_Click);
            // 
            // aDGroupsToolStripMenuItem
            // 
            this.aDGroupsToolStripMenuItem.Name = "aDGroupsToolStripMenuItem";
            this.aDGroupsToolStripMenuItem.Size = new System.Drawing.Size(266, 44);
            this.aDGroupsToolStripMenuItem.Text = "ADGroups";
            this.aDGroupsToolStripMenuItem.Click += new System.EventHandler(this.ADGroupsToolStripMenuItem_Click);
            // 
            // aDPathToolStripMenuItem
            // 
            this.aDPathToolStripMenuItem.Name = "aDPathToolStripMenuItem";
            this.aDPathToolStripMenuItem.Size = new System.Drawing.Size(266, 44);
            this.aDPathToolStripMenuItem.Text = "ADPath";
            this.aDPathToolStripMenuItem.Click += new System.EventHandler(this.ADPathToolStripMenuItem_Click);
            // 
            // pictureBox_back
            // 
            this.pictureBox_back.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_back.Image = global::InterfacePowShell.Properties.Resources.icons8_retour_96;
            this.pictureBox_back.Location = new System.Drawing.Point(0, 921);
            this.pictureBox_back.Name = "pictureBox_back";
            this.pictureBox_back.Size = new System.Drawing.Size(116, 82);
            this.pictureBox_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_back.TabIndex = 74;
            this.pictureBox_back.TabStop = false;
            this.pictureBox_back.Click += new System.EventHandler(this.PictureBox_back_Click);
            // 
            // NewADUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 1015);
            this.Controls.Add(this.pictureBox_back);
            this.Controls.Add(this.pictureBox_Minimize);
            this.Controls.Add(this.label_aduser);
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.panel_base);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_move);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "NewADUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADUser";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel_base.ResumeLayout(false);
            this.panel_base.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel_move;
        private System.Windows.Forms.PictureBox pictureBox_Minimize;
        private System.Windows.Forms.Label label_aduser;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button Btn_RemoveUser;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.Button Btn_EditUser;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox logon;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Button Btn_AddUser;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_base;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox_username;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDPathToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox_back;
        private System.Windows.Forms.ToolStripMenuItem loadADToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Ldap;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_cn;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_username;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_password;
    }
}