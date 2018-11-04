namespace C_Sharp_Assignment
{
    partial class Login
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginpic = new System.Windows.Forms.PictureBox();
            this.exitpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitpic)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.ForeColor = System.Drawing.SystemColors.InfoText;
            this.username.Location = new System.Drawing.Point(448, 177);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(145, 20);
            this.username.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(448, 250);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(145, 20);
            this.password.TabIndex = 2;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("! PEPSI !", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(288, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("! PEPSI !", 18F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(288, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // loginpic
            // 
            this.loginpic.BackColor = System.Drawing.Color.Transparent;
            this.loginpic.BackgroundImage = global::C_Sharp_Assignment.Properties.Resources.login;
            this.loginpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginpic.Location = new System.Drawing.Point(293, 316);
            this.loginpic.Name = "loginpic";
            this.loginpic.Size = new System.Drawing.Size(100, 50);
            this.loginpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginpic.TabIndex = 6;
            this.loginpic.TabStop = false;
            this.loginpic.Click += new System.EventHandler(this.loginpic_Click);
            this.loginpic.MouseLeave += new System.EventHandler(this.loginpic_MouseLeave);
            this.loginpic.MouseHover += new System.EventHandler(this.loginpic_MouseHover);
            // 
            // exitpic
            // 
            this.exitpic.BackColor = System.Drawing.Color.Transparent;
            this.exitpic.BackgroundImage = global::C_Sharp_Assignment.Properties.Resources.exit;
            this.exitpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitpic.Location = new System.Drawing.Point(493, 316);
            this.exitpic.Name = "exitpic";
            this.exitpic.Size = new System.Drawing.Size(100, 50);
            this.exitpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitpic.TabIndex = 7;
            this.exitpic.TabStop = false;
            this.exitpic.Click += new System.EventHandler(this.exitpic_Click);
            this.exitpic.MouseLeave += new System.EventHandler(this.exitpic_MouseLeave);
            this.exitpic.MouseHover += new System.EventHandler(this.exitpic_MouseHover);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C_Sharp_Assignment.Properties.Resources.midnight;
            this.ClientSize = new System.Drawing.Size(832, 487);
            this.ControlBox = false;
            this.Controls.Add(this.exitpic);
            this.Controls.Add(this.loginpic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox loginpic;
        private System.Windows.Forms.PictureBox exitpic;
    }
}