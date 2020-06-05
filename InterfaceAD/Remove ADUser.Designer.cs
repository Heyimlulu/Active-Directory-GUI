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
            this.textBoxAD = new System.Windows.Forms.TextBox();
            this.buttonAD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxAD
            // 
            this.textBoxAD.BackColor = System.Drawing.Color.White;
            this.textBoxAD.Location = new System.Drawing.Point(34, 56);
            this.textBoxAD.Multiline = true;
            this.textBoxAD.Name = "textBoxAD";
            this.textBoxAD.ReadOnly = true;
            this.textBoxAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAD.Size = new System.Drawing.Size(495, 568);
            this.textBoxAD.TabIndex = 0;
            // 
            // buttonAD
            // 
            this.buttonAD.BackColor = System.Drawing.Color.White;
            this.buttonAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAD.Location = new System.Drawing.Point(560, 56);
            this.buttonAD.Name = "buttonAD";
            this.buttonAD.Size = new System.Drawing.Size(380, 60);
            this.buttonAD.TabIndex = 1;
            this.buttonAD.Text = "List Users";
            this.buttonAD.UseVisualStyleBackColor = false;
            this.buttonAD.Click += new System.EventHandler(this.ButtonAD_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(560, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(381, 120);
            this.button1.TabIndex = 2;
            this.button1.Text = "Remove User";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxDel
            // 
            this.textBoxDel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDel.Location = new System.Drawing.Point(560, 402);
            this.textBoxDel.Name = "textBoxDel";
            this.textBoxDel.Size = new System.Drawing.Size(381, 47);
            this.textBoxDel.TabIndex = 3;
            this.textBoxDel.TextChanged += new System.EventHandler(this.TextBoxDel_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 629);
            this.Controls.Add(this.textBoxDel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAD);
            this.Controls.Add(this.textBoxAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove ADUser";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAD;
        private System.Windows.Forms.Button buttonAD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDel;
    }
}