namespace FinalProject
{
    partial class LoginForm
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
            this.username_enter = new System.Windows.Forms.TextBox();
            this.Username_label = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.password_enter = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.message_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_enter
            // 
            this.username_enter.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.username_enter.Font = new System.Drawing.Font("Levenim MT", 12F);
            this.username_enter.Location = new System.Drawing.Point(382, 105);
            this.username_enter.Name = "username_enter";
            this.username_enter.Size = new System.Drawing.Size(224, 41);
            this.username_enter.TabIndex = 0;
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_label.Location = new System.Drawing.Point(239, 114);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(137, 32);
            this.Username_label.TabIndex = 1;
            this.Username_label.Text = "Username:";
            this.Username_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(250, 174);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(126, 32);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PasswordLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // password_enter
            // 
            this.password_enter.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.password_enter.Font = new System.Drawing.Font("Levenim MT", 12F);
            this.password_enter.Location = new System.Drawing.Point(382, 165);
            this.password_enter.Name = "password_enter";
            this.password_enter.Size = new System.Drawing.Size(224, 41);
            this.password_enter.TabIndex = 3;
            this.password_enter.UseSystemPasswordChar = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Levenim MT", 12F);
            this.BtnLogin.Location = new System.Drawing.Point(320, 246);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(180, 41);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // message_label
            // 
            this.message_label.AutoSize = true;
            this.message_label.ForeColor = System.Drawing.Color.Red;
            this.message_label.Location = new System.Drawing.Point(401, 314);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(0, 20);
            this.message_label.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.message_label);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.password_enter);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.username_enter);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_enter;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox password_enter;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label message_label;
    }
}

