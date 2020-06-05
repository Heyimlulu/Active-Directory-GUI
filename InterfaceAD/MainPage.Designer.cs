namespace InterfacePowShell
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.label_aduser = new System.Windows.Forms.Label();
            this.panel_move = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àproposdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_AddUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ADpath = new System.Windows.Forms.Button();
            this.pictureBox_Minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // label_aduser
            // 
            this.label_aduser.AutoSize = true;
            this.label_aduser.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label_aduser.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_aduser.ForeColor = System.Drawing.Color.Black;
            this.label_aduser.Location = new System.Drawing.Point(264, 21);
            this.label_aduser.Name = "label_aduser";
            this.label_aduser.Size = new System.Drawing.Size(345, 59);
            this.label_aduser.TabIndex = 67;
            this.label_aduser.Text = "Active Directory";
            this.label_aduser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_aduser_MouseDown);
            // 
            // panel_move
            // 
            this.panel_move.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel_move.Location = new System.Drawing.Point(-12, 1);
            this.panel_move.Name = "panel_move";
            this.panel_move.Size = new System.Drawing.Size(896, 100);
            this.panel_move.TabIndex = 69;
            this.panel_move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_move_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 41);
            this.menuStrip1.TabIndex = 71;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.BackColor = System.Drawing.Color.MediumAquamarine;
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.àproposdeToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(80, 37);
            this.aideToolStripMenuItem.Text = "Info";
            // 
            // àproposdeToolStripMenuItem
            // 
            this.àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
            this.àproposdeToolStripMenuItem.Size = new System.Drawing.Size(217, 44);
            this.àproposdeToolStripMenuItem.Text = "Credit";
            this.àproposdeToolStripMenuItem.Click += new System.EventHandler(this.ÀproposdeToolStripMenuItem_Click);
            // 
            // Btn_AddUser
            // 
            this.Btn_AddUser.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Btn_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddUser.ForeColor = System.Drawing.Color.White;
            this.Btn_AddUser.Location = new System.Drawing.Point(116, 159);
            this.Btn_AddUser.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_AddUser.Name = "Btn_AddUser";
            this.Btn_AddUser.Size = new System.Drawing.Size(314, 140);
            this.Btn_AddUser.TabIndex = 72;
            this.Btn_AddUser.Text = "Add User in AD";
            this.Btn_AddUser.UseVisualStyleBackColor = false;
            this.Btn_AddUser.Click += new System.EventHandler(this.Btn_AddUser_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(442, 159);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 140);
            this.button1.TabIndex = 73;
            this.button1.Text = "Add Group in AD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_ADpath
            // 
            this.btn_ADpath.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_ADpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ADpath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ADpath.ForeColor = System.Drawing.Color.White;
            this.btn_ADpath.Location = new System.Drawing.Point(116, 311);
            this.btn_ADpath.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ADpath.Name = "btn_ADpath";
            this.btn_ADpath.Size = new System.Drawing.Size(640, 140);
            this.btn_ADpath.TabIndex = 74;
            this.btn_ADpath.Text = "ADpath";
            this.btn_ADpath.UseVisualStyleBackColor = false;
            this.btn_ADpath.Click += new System.EventHandler(this.Btn_ADpath_Click);
            // 
            // pictureBox_Minimize
            // 
            this.pictureBox_Minimize.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pictureBox_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Minimize.Image = global::InterfacePowShell.Properties.Resources.icons8_moins_24;
            this.pictureBox_Minimize.InitialImage = global::InterfacePowShell.Properties.Resources.icons8_moins_24;
            this.pictureBox_Minimize.Location = new System.Drawing.Point(777, 23);
            this.pictureBox_Minimize.Name = "pictureBox_Minimize";
            this.pictureBox_Minimize.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Minimize.TabIndex = 70;
            this.pictureBox_Minimize.TabStop = false;
            this.pictureBox_Minimize.Click += new System.EventHandler(this.PictureBox_Minimize_Click);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pictureBox_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Close.Image = global::InterfacePowShell.Properties.Resources.icons8_multiplier_50;
            this.pictureBox_Close.InitialImage = global::InterfacePowShell.Properties.Resources.icons8_multiplier_50;
            this.pictureBox_Close.Location = new System.Drawing.Point(820, 23);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Close.TabIndex = 68;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.PictureBox_Close_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(872, 500);
            this.Controls.Add(this.btn_ADpath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_AddUser);
            this.Controls.Add(this.pictureBox_Minimize);
            this.Controls.Add(this.label_aduser);
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_move);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_Minimize;
        private System.Windows.Forms.Label label_aduser;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.Panel panel_move;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem àproposdeToolStripMenuItem;
        private System.Windows.Forms.Button Btn_AddUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ADpath;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}