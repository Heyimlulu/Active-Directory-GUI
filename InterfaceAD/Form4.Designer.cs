namespace InterfacePowShell
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel_base = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox_User = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_securite = new System.Windows.Forms.CheckBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_RemoveUsertoGroup = new System.Windows.Forms.Button();
            this.checkBox_distribution = new System.Windows.Forms.CheckBox();
            this.txtbox_description = new System.Windows.Forms.TextBox();
            this.Btn_AddGroup = new System.Windows.Forms.Button();
            this.comboBox_GroupAD = new System.Windows.Forms.ComboBox();
            this.btn_AddUsertoGroup = new System.Windows.Forms.Button();
            this.label_aduser = new System.Windows.Forms.Label();
            this.panel_move = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox_Ldap = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_cn = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_username = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_password = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDpathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox_Minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.pictureBox_back = new System.Windows.Forms.PictureBox();
            this.panel_base.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_base
            // 
            this.panel_base.BackColor = System.Drawing.Color.White;
            this.panel_base.Controls.Add(this.label2);
            this.panel_base.Controls.Add(this.panel3);
            this.panel_base.Controls.Add(this.panel2);
            this.panel_base.Controls.Add(this.listBox_User);
            this.panel_base.Controls.Add(this.panel1);
            this.panel_base.Controls.Add(this.label1);
            this.panel_base.Controls.Add(this.checkBox_securite);
            this.panel_base.Controls.Add(this.btn_edit);
            this.panel_base.Controls.Add(this.btn_remove);
            this.panel_base.Controls.Add(this.btn_RemoveUsertoGroup);
            this.panel_base.Controls.Add(this.checkBox_distribution);
            this.panel_base.Controls.Add(this.txtbox_description);
            this.panel_base.Controls.Add(this.Btn_AddGroup);
            this.panel_base.Controls.Add(this.comboBox_GroupAD);
            this.panel_base.Controls.Add(this.btn_AddUsertoGroup);
            this.panel_base.Location = new System.Drawing.Point(122, 156);
            this.panel_base.Name = "panel_base";
            this.panel_base.Size = new System.Drawing.Size(730, 877);
            this.panel_base.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 53);
            this.label2.TabIndex = 102;
            this.label2.Text = "Add user to Group ...";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel3.Location = new System.Drawing.Point(64, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 4);
            this.panel3.TabIndex = 101;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Location = new System.Drawing.Point(64, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 4);
            this.panel2.TabIndex = 100;
            // 
            // listBox_User
            // 
            this.listBox_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_User.FormattingEnabled = true;
            this.listBox_User.ItemHeight = 25;
            this.listBox_User.Location = new System.Drawing.Point(55, 468);
            this.listBox_User.Name = "listBox_User";
            this.listBox_User.Size = new System.Drawing.Size(620, 227);
            this.listBox_User.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(55, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 4);
            this.panel1.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 53);
            this.label1.TabIndex = 97;
            this.label1.Text = "Create a group ...";
            // 
            // checkBox_securite
            // 
            this.checkBox_securite.AutoSize = true;
            this.checkBox_securite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_securite.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_securite.Location = new System.Drawing.Point(486, 148);
            this.checkBox_securite.Name = "checkBox_securite";
            this.checkBox_securite.Size = new System.Drawing.Size(151, 43);
            this.checkBox_securite.TabIndex = 3;
            this.checkBox_securite.Text = "Sécurité";
            this.checkBox_securite.UseVisualStyleBackColor = true;
            this.checkBox_securite.CheckedChanged += new System.EventHandler(this.CheckBox_securite_CheckedChanged);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(290, 297);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(150, 50);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(452, 297);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(6);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(150, 50);
            this.btn_remove.TabIndex = 7;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.Btn_remove_Click);
            // 
            // btn_RemoveUsertoGroup
            // 
            this.btn_RemoveUsertoGroup.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_RemoveUsertoGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveUsertoGroup.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveUsertoGroup.ForeColor = System.Drawing.Color.White;
            this.btn_RemoveUsertoGroup.Location = new System.Drawing.Point(371, 723);
            this.btn_RemoveUsertoGroup.Margin = new System.Windows.Forms.Padding(6);
            this.btn_RemoveUsertoGroup.Name = "btn_RemoveUsertoGroup";
            this.btn_RemoveUsertoGroup.Size = new System.Drawing.Size(250, 100);
            this.btn_RemoveUsertoGroup.TabIndex = 10;
            this.btn_RemoveUsertoGroup.Text = "Remove User to Group";
            this.btn_RemoveUsertoGroup.UseVisualStyleBackColor = false;
            this.btn_RemoveUsertoGroup.Click += new System.EventHandler(this.Btn_RemoveUsertoGroup_Click);
            // 
            // checkBox_distribution
            // 
            this.checkBox_distribution.AutoSize = true;
            this.checkBox_distribution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_distribution.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_distribution.Location = new System.Drawing.Point(486, 205);
            this.checkBox_distribution.Name = "checkBox_distribution";
            this.checkBox_distribution.Size = new System.Drawing.Size(202, 43);
            this.checkBox_distribution.TabIndex = 4;
            this.checkBox_distribution.Text = "Distribution";
            this.checkBox_distribution.UseVisualStyleBackColor = true;
            this.checkBox_distribution.CheckedChanged += new System.EventHandler(this.CheckBox_distribution_CheckedChanged);
            // 
            // txtbox_description
            // 
            this.txtbox_description.BackColor = System.Drawing.Color.White;
            this.txtbox_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_description.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_description.ForeColor = System.Drawing.Color.Silver;
            this.txtbox_description.Location = new System.Drawing.Point(64, 206);
            this.txtbox_description.Name = "txtbox_description";
            this.txtbox_description.Size = new System.Drawing.Size(360, 40);
            this.txtbox_description.TabIndex = 2;
            this.txtbox_description.Text = "Description (optional)";
            this.txtbox_description.Enter += new System.EventHandler(this.Txtbox_description_Enter);
            this.txtbox_description.Leave += new System.EventHandler(this.Txtbox_description_Leave);
            // 
            // Btn_AddGroup
            // 
            this.Btn_AddGroup.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Btn_AddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddGroup.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddGroup.ForeColor = System.Drawing.Color.White;
            this.Btn_AddGroup.Location = new System.Drawing.Point(128, 297);
            this.Btn_AddGroup.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_AddGroup.Name = "Btn_AddGroup";
            this.Btn_AddGroup.Size = new System.Drawing.Size(150, 50);
            this.Btn_AddGroup.TabIndex = 5;
            this.Btn_AddGroup.Text = "Add";
            this.Btn_AddGroup.UseVisualStyleBackColor = false;
            this.Btn_AddGroup.Click += new System.EventHandler(this.Btn_AddGroup_Click);
            // 
            // comboBox_GroupAD
            // 
            this.comboBox_GroupAD.BackColor = System.Drawing.Color.White;
            this.comboBox_GroupAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_GroupAD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_GroupAD.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_GroupAD.FormattingEnabled = true;
            this.comboBox_GroupAD.Location = new System.Drawing.Point(64, 123);
            this.comboBox_GroupAD.Name = "comboBox_GroupAD";
            this.comboBox_GroupAD.Size = new System.Drawing.Size(360, 47);
            this.comboBox_GroupAD.TabIndex = 1;
            this.comboBox_GroupAD.Text = "----Select/Add Group----";
            this.comboBox_GroupAD.SelectedIndexChanged += new System.EventHandler(this.ComboBox_GroupAD_SelectedIndexChanged);
            this.comboBox_GroupAD.Enter += new System.EventHandler(this.ComboBox_GroupAD_Enter);
            this.comboBox_GroupAD.Leave += new System.EventHandler(this.ComboBox_GroupAD_Leave);
            // 
            // btn_AddUsertoGroup
            // 
            this.btn_AddUsertoGroup.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_AddUsertoGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddUsertoGroup.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddUsertoGroup.ForeColor = System.Drawing.Color.White;
            this.btn_AddUsertoGroup.Location = new System.Drawing.Point(109, 723);
            this.btn_AddUsertoGroup.Margin = new System.Windows.Forms.Padding(6);
            this.btn_AddUsertoGroup.Name = "btn_AddUsertoGroup";
            this.btn_AddUsertoGroup.Size = new System.Drawing.Size(250, 100);
            this.btn_AddUsertoGroup.TabIndex = 9;
            this.btn_AddUsertoGroup.Text = "Add User to Group";
            this.btn_AddUsertoGroup.UseVisualStyleBackColor = false;
            this.btn_AddUsertoGroup.Click += new System.EventHandler(this.Btn_AddUsertoGroup_Click);
            // 
            // label_aduser
            // 
            this.label_aduser.AutoSize = true;
            this.label_aduser.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label_aduser.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_aduser.ForeColor = System.Drawing.Color.Black;
            this.label_aduser.Location = new System.Drawing.Point(373, 19);
            this.label_aduser.Name = "label_aduser";
            this.label_aduser.Size = new System.Drawing.Size(228, 59);
            this.label_aduser.TabIndex = 63;
            this.label_aduser.Text = "ADGroups";
            this.label_aduser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_aduser_MouseDown);
            // 
            // panel_move
            // 
            this.panel_move.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel_move.Location = new System.Drawing.Point(-7, 3);
            this.panel_move.Name = "panel_move";
            this.panel_move.Size = new System.Drawing.Size(986, 100);
            this.panel_move.TabIndex = 65;
            this.panel_move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_move_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editToolStripMenuItem,
            this.goToToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 48);
            this.menuStrip1.TabIndex = 68;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuStrip1_MouseDown);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fichierToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(75, 40);
            this.fichierToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(241, 44);
            this.loadToolStripMenuItem.Text = "Load AD";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
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
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.DarkTurquoise;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripTextBox_Ldap,
            this.toolStripTextBox_cn,
            this.toolStripTextBox_username,
            this.toolStripTextBox_password,
            this.toolStripSeparator3});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(78, 40);
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
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(416, 6);
            // 
            // toolStripTextBox_Ldap
            // 
            this.toolStripTextBox_Ldap.BackColor = System.Drawing.Color.White;
            this.toolStripTextBox_Ldap.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox_Ldap.ForeColor = System.Drawing.Color.Silver;
            this.toolStripTextBox_Ldap.MaxLength = 20;
            this.toolStripTextBox_Ldap.Name = "toolStripTextBox_Ldap";
            this.toolStripTextBox_Ldap.ReadOnly = true;
            this.toolStripTextBox_Ldap.Size = new System.Drawing.Size(200, 37);
            this.toolStripTextBox_Ldap.Text = "LDAP://path";
            // 
            // toolStripTextBox_cn
            // 
            this.toolStripTextBox_cn.BackColor = System.Drawing.Color.White;
            this.toolStripTextBox_cn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox_cn.ForeColor = System.Drawing.Color.Silver;
            this.toolStripTextBox_cn.MaxLength = 20;
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
            this.toolStripTextBox_username.MaxLength = 20;
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
            this.toolStripTextBox_password.MaxLength = 20;
            this.toolStripTextBox_password.Name = "toolStripTextBox_password";
            this.toolStripTextBox_password.ReadOnly = true;
            this.toolStripTextBox_password.Size = new System.Drawing.Size(300, 37);
            this.toolStripTextBox_password.Text = "ADPassword";
            this.toolStripTextBox_password.Visible = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(416, 6);
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainPageToolStripMenuItem,
            this.aDUsersToolStripMenuItem,
            this.aDpathToolStripMenuItem});
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(124, 40);
            this.goToToolStripMenuItem.Text = "Go to ...";
            // 
            // mainPageToolStripMenuItem
            // 
            this.mainPageToolStripMenuItem.Name = "mainPageToolStripMenuItem";
            this.mainPageToolStripMenuItem.Size = new System.Drawing.Size(266, 44);
            this.mainPageToolStripMenuItem.Text = "Main Page";
            this.mainPageToolStripMenuItem.Click += new System.EventHandler(this.MainPageToolStripMenuItem_Click);
            // 
            // aDUsersToolStripMenuItem
            // 
            this.aDUsersToolStripMenuItem.Name = "aDUsersToolStripMenuItem";
            this.aDUsersToolStripMenuItem.Size = new System.Drawing.Size(266, 44);
            this.aDUsersToolStripMenuItem.Text = "ADUsers";
            this.aDUsersToolStripMenuItem.Click += new System.EventHandler(this.ADUsersToolStripMenuItem_Click);
            // 
            // aDpathToolStripMenuItem
            // 
            this.aDpathToolStripMenuItem.Name = "aDpathToolStripMenuItem";
            this.aDpathToolStripMenuItem.Size = new System.Drawing.Size(266, 44);
            this.aDpathToolStripMenuItem.Text = "ADpath";
            this.aDpathToolStripMenuItem.Click += new System.EventHandler(this.ADpathToolStripMenuItem_Click);
            // 
            // pictureBox_Minimize
            // 
            this.pictureBox_Minimize.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureBox_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Minimize.Image = global::InterfacePowShell.Properties.Resources.icons8_moins_24;
            this.pictureBox_Minimize.InitialImage = global::InterfacePowShell.Properties.Resources.icons8_moins_24;
            this.pictureBox_Minimize.Location = new System.Drawing.Point(878, 23);
            this.pictureBox_Minimize.Name = "pictureBox_Minimize";
            this.pictureBox_Minimize.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Minimize.TabIndex = 66;
            this.pictureBox_Minimize.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox_Minimize, "Réduire");
            this.pictureBox_Minimize.Click += new System.EventHandler(this.PictureBox_Minimize_Click);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pictureBox_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Close.Image = global::InterfacePowShell.Properties.Resources.icons8_multiplier_50;
            this.pictureBox_Close.InitialImage = global::InterfacePowShell.Properties.Resources.icons8_multiplier_50;
            this.pictureBox_Close.Location = new System.Drawing.Point(921, 23);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Close.TabIndex = 64;
            this.pictureBox_Close.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox_Close, "Quitter");
            this.pictureBox_Close.Click += new System.EventHandler(this.PictureBox_Close_Click);
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
            this.pictureBox_back.TabIndex = 73;
            this.pictureBox_back.TabStop = false;
            this.pictureBox_back.Click += new System.EventHandler(this.PictureBox_back_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 1015);
            this.Controls.Add(this.pictureBox_back);
            this.Controls.Add(this.pictureBox_Minimize);
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.label_aduser);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_move);
            this.Controls.Add(this.panel_base);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.panel_base.ResumeLayout(false);
            this.panel_base.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_base;
        private System.Windows.Forms.PictureBox pictureBox_Minimize;
        private System.Windows.Forms.Label label_aduser;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.Panel panel_move;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBox_GroupAD;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_securite;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_RemoveUsertoGroup;
        private System.Windows.Forms.Button Btn_AddGroup;
        private System.Windows.Forms.CheckBox checkBox_distribution;
        private System.Windows.Forms.Button btn_AddUsertoGroup;
        private System.Windows.Forms.TextBox txtbox_description;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox_User;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDpathToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Ldap;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_cn;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_username;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_password;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox_back;
    }
}