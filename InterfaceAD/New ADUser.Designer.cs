namespace InterfacePowShell
{
    partial class Form3
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
            this.password = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.fullname = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.PrincipalContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fname = new System.Windows.Forms.TextBox();
            this.logon = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Silver;
            this.password.Location = new System.Drawing.Point(398, 204);
            this.password.Margin = new System.Windows.Forms.Padding(6);
            this.password.MaxLength = 30;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(246, 47);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.Enter += new System.EventHandler(this.Password_Enter);
            this.password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // lname
            // 
            this.lname.BackColor = System.Drawing.Color.White;
            this.lname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.ForeColor = System.Drawing.Color.Silver;
            this.lname.Location = new System.Drawing.Point(398, 342);
            this.lname.Margin = new System.Windows.Forms.Padding(6);
            this.lname.MaxLength = 30;
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(246, 47);
            this.lname.TabIndex = 5;
            this.lname.Text = "Lastname";
            this.lname.Enter += new System.EventHandler(this.Lname_Enter);
            this.lname.Leave += new System.EventHandler(this.Lname_Leave);
            // 
            // fullname
            // 
            this.fullname.BackColor = System.Drawing.Color.White;
            this.fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.ForeColor = System.Drawing.Color.Silver;
            this.fullname.Location = new System.Drawing.Point(140, 411);
            this.fullname.Margin = new System.Windows.Forms.Padding(6);
            this.fullname.MaxLength = 50;
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(504, 47);
            this.fullname.TabIndex = 6;
            this.fullname.Text = "FullName";
            this.fullname.Enter += new System.EventHandler(this.Fullname_Enter);
            this.fullname.Leave += new System.EventHandler(this.Fullname_Leave);
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.White;
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Silver;
            this.description.Location = new System.Drawing.Point(140, 501);
            this.description.Margin = new System.Windows.Forms.Padding(6);
            this.description.MaxLength = 100;
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(504, 200);
            this.description.TabIndex = 7;
            this.description.Text = "Description";
            this.description.Enter += new System.EventHandler(this.Description_Enter);
            this.description.Leave += new System.EventHandler(this.Description_Leave);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.BackColor = System.Drawing.Color.Silver;
            this.btn_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddUser.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddUser.ForeColor = System.Drawing.Color.White;
            this.btn_AddUser.Location = new System.Drawing.Point(131, 775);
            this.btn_AddUser.Margin = new System.Windows.Forms.Padding(6);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(504, 100);
            this.btn_AddUser.TabIndex = 16;
            this.btn_AddUser.Text = "Add User";
            this.btn_AddUser.UseVisualStyleBackColor = false;
            this.btn_AddUser.Click += new System.EventHandler(this.Btn_AddUser_Click);
            // 
            // PrincipalContext
            // 
            this.PrincipalContext.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.PrincipalContext.Name = "PrincipalContext";
            this.PrincipalContext.Size = new System.Drawing.Size(61, 4);
            // 
            // fname
            // 
            this.fname.BackColor = System.Drawing.Color.White;
            this.fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.ForeColor = System.Drawing.Color.Silver;
            this.fname.Location = new System.Drawing.Point(140, 342);
            this.fname.Margin = new System.Windows.Forms.Padding(6);
            this.fname.MaxLength = 30;
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(246, 47);
            this.fname.TabIndex = 4;
            this.fname.Text = "Firstname";
            this.fname.Enter += new System.EventHandler(this.Fname_Enter);
            this.fname.Leave += new System.EventHandler(this.Fname_Leave);
            // 
            // logon
            // 
            this.logon.BackColor = System.Drawing.Color.White;
            this.logon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logon.ForeColor = System.Drawing.Color.Silver;
            this.logon.Location = new System.Drawing.Point(140, 274);
            this.logon.Margin = new System.Windows.Forms.Padding(6);
            this.logon.MaxLength = 30;
            this.logon.Name = "logon";
            this.logon.Size = new System.Drawing.Size(504, 47);
            this.logon.TabIndex = 3;
            this.logon.Text = "Login";
            this.logon.Enter += new System.EventHandler(this.Logon_Enter);
            this.logon.Leave += new System.EventHandler(this.Logon_Leave);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.White;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Silver;
            this.username.Location = new System.Drawing.Point(140, 204);
            this.username.Margin = new System.Windows.Forms.Padding(6);
            this.username.MaxLength = 30;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(246, 47);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            this.username.Enter += new System.EventHandler(this.Username_Enter);
            this.username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 929);
            this.Controls.Add(this.logon);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.btn_AddUser);
            this.Controls.Add(this.description);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New ADUser Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.ContextMenuStrip PrincipalContext;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox logon;
        private System.Windows.Forms.TextBox username;
    }
}