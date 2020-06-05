namespace InterfacePowShell
{
    partial class PreAlpha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreAlpha));
            this.panel_move = new System.Windows.Forms.Panel();
            this.label_countdown = new System.Windows.Forms.Label();
            this.label_aduser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_countdown = new System.Windows.Forms.Timer(this.components);
            this.panel_move.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_move
            // 
            this.panel_move.BackColor = System.Drawing.Color.Goldenrod;
            this.panel_move.Controls.Add(this.label_countdown);
            this.panel_move.Controls.Add(this.label_aduser);
            this.panel_move.Location = new System.Drawing.Point(-7, -1);
            this.panel_move.Name = "panel_move";
            this.panel_move.Size = new System.Drawing.Size(986, 100);
            this.panel_move.TabIndex = 66;
            // 
            // label_countdown
            // 
            this.label_countdown.AutoSize = true;
            this.label_countdown.BackColor = System.Drawing.Color.Transparent;
            this.label_countdown.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_countdown.ForeColor = System.Drawing.Color.Black;
            this.label_countdown.Location = new System.Drawing.Point(746, 33);
            this.label_countdown.Name = "label_countdown";
            this.label_countdown.Size = new System.Drawing.Size(0, 39);
            this.label_countdown.TabIndex = 68;
            // 
            // label_aduser
            // 
            this.label_aduser.AutoSize = true;
            this.label_aduser.BackColor = System.Drawing.Color.Goldenrod;
            this.label_aduser.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_aduser.ForeColor = System.Drawing.Color.Black;
            this.label_aduser.Location = new System.Drawing.Point(289, 17);
            this.label_aduser.Name = "label_aduser";
            this.label_aduser.Size = new System.Drawing.Size(409, 59);
            this.label_aduser.TabIndex = 67;
            this.label_aduser.Text = "Pre-Alpha Build 1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfacePowShell.Properties.Resources.prealpha;
            this.pictureBox1.Location = new System.Drawing.Point(43, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(888, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 11000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer_countdown
            // 
            this.timer_countdown.Enabled = true;
            this.timer_countdown.Interval = 1000;
            this.timer_countdown.Tick += new System.EventHandler(this.Timer_countdown_Tick);
            // 
            // PreAlpha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(974, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_move);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PreAlpha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreAlpha";
            this.panel_move.ResumeLayout(false);
            this.panel_move.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_move;
        private System.Windows.Forms.Label label_aduser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_countdown;
        private System.Windows.Forms.Timer timer_countdown;
    }
}