namespace InterfacePowShell

{
    
    partial class Form1
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
            this.butAffiche = new System.Windows.Forms.Button();
            this.textBoxAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAD = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butAffiche
            // 
            this.butAffiche.BackColor = System.Drawing.Color.DimGray;
            this.butAffiche.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAffiche.ForeColor = System.Drawing.SystemColors.Control;
            this.butAffiche.Location = new System.Drawing.Point(603, 28);
            this.butAffiche.Name = "butAffiche";
            this.butAffiche.Size = new System.Drawing.Size(150, 50);
            this.butAffiche.TabIndex = 0;
            this.butAffiche.Text = "Run Select";
            this.butAffiche.UseVisualStyleBackColor = false;
            this.butAffiche.Click += new System.EventHandler(this.BtnAD_Click);
            // 
            // textBoxAD
            // 
            this.textBoxAD.Location = new System.Drawing.Point(12, 101);
            this.textBoxAD.Multiline = true;
            this.textBoxAD.Name = "textBoxAD";
            this.textBoxAD.ReadOnly = true;
            this.textBoxAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAD.Size = new System.Drawing.Size(760, 298);
            this.textBoxAD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "ACTIVE DIRECTORY";
            // 
            // comboBoxAD
            // 
            this.comboBoxAD.AutoCompleteCustomSource.AddRange(new string[] {
            "Liste utilisateurs"});
            this.comboBoxAD.FormattingEnabled = true;
            this.comboBoxAD.Items.AddRange(new object[] {
            "Groups List",
            "PC Name",
            "Users List"});
            this.comboBoxAD.Location = new System.Drawing.Point(16, 57);
            this.comboBoxAD.Name = "comboBoxAD";
            this.comboBoxAD.Size = new System.Drawing.Size(326, 21);
            this.comboBoxAD.Sorted = true;
            this.comboBoxAD.TabIndex = 10;
            this.comboBoxAD.Text = "--- Choose ---";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(388, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "PowerShell Access";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUserToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newUserToolStripMenuItem.Text = "New User";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.NewUserToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxAD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAD);
            this.Controls.Add(this.butAffiche);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(400, 400);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accès Active Directory";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAffiche;
        private System.Windows.Forms.TextBox textBoxAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
    }
}

