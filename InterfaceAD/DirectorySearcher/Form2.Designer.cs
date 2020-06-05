namespace InterfacePowShell
{
    partial class Form2
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
            this.comboBoxAD = new System.Windows.Forms.ComboBox();
            this.textBoxAD = new System.Windows.Forms.TextBox();
            this.butAffiche = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAD
            // 
            this.comboBoxAD.AutoCompleteCustomSource.AddRange(new string[] {
            "Liste utilisateurs"});
            this.comboBoxAD.FormattingEnabled = true;
            this.comboBoxAD.Items.AddRange(new object[] {
            "ADUser List Path",
            "DNS List",
            "Firewall List",
            "HardDisk List",
            "Services List"});
            this.comboBoxAD.Location = new System.Drawing.Point(16, 59);
            this.comboBoxAD.Name = "comboBoxAD";
            this.comboBoxAD.Size = new System.Drawing.Size(284, 21);
            this.comboBoxAD.Sorted = true;
            this.comboBoxAD.TabIndex = 14;
            this.comboBoxAD.Text = "--- Choose ---";
            // 
            // textBoxAD
            // 
            this.textBoxAD.Location = new System.Drawing.Point(12, 101);
            this.textBoxAD.Multiline = true;
            this.textBoxAD.Name = "textBoxAD";
            this.textBoxAD.ReadOnly = true;
            this.textBoxAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAD.Size = new System.Drawing.Size(760, 298);
            this.textBoxAD.TabIndex = 12;
            // 
            // butAffiche
            // 
            this.butAffiche.BackColor = System.Drawing.Color.DimGray;
            this.butAffiche.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAffiche.ForeColor = System.Drawing.SystemColors.Control;
            this.butAffiche.Location = new System.Drawing.Point(592, 30);
            this.butAffiche.Name = "butAffiche";
            this.butAffiche.Size = new System.Drawing.Size(150, 50);
            this.butAffiche.TabIndex = 11;
            this.butAffiche.Text = "Run Select";
            this.butAffiche.UseVisualStyleBackColor = false;
            this.butAffiche.Click += new System.EventHandler(this.ButAffiche_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "POWERSHELL COMMAND";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(365, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 16;
            this.button1.Text = "Active Directory Access";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAD);
            this.Controls.Add(this.textBoxAD);
            this.Controls.Add(this.butAffiche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PowerShell Command";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAD;
        private System.Windows.Forms.TextBox textBoxAD;
        private System.Windows.Forms.Button butAffiche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}