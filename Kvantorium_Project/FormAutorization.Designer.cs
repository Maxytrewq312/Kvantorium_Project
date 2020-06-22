namespace Kvantorium_Project
{
    partial class FormAutorization
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
            this.labelVvod = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonVoity = new System.Windows.Forms.Button();
            this.buttonRegistr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVvod
            // 
            this.labelVvod.AutoSize = true;
            this.labelVvod.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVvod.Location = new System.Drawing.Point(161, 25);
            this.labelVvod.Name = "labelVvod";
            this.labelVvod.Size = new System.Drawing.Size(304, 22);
            this.labelVvod.TabIndex = 0;
            this.labelVvod.Text = "Введите данные для авторизации";
            this.labelVvod.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(28, 110);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(50, 19);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(19, 156);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(59, 19);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(115, 103);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(486, 26);
            this.textBoxLogin.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(115, 149);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(486, 26);
            this.textBoxPassword.TabIndex = 4;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Location = new System.Drawing.Point(12, 306);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(163, 47);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Выйти из программы";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonVoity
            // 
            this.buttonVoity.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonVoity.FlatAppearance.BorderSize = 0;
            this.buttonVoity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoity.Location = new System.Drawing.Point(69, 218);
            this.buttonVoity.Name = "buttonVoity";
            this.buttonVoity.Size = new System.Drawing.Size(229, 48);
            this.buttonVoity.TabIndex = 6;
            this.buttonVoity.Text = "Войти";
            this.buttonVoity.UseVisualStyleBackColor = false;
            this.buttonVoity.Click += new System.EventHandler(this.buttonVoity_Click);
            // 
            // buttonRegistr
            // 
            this.buttonRegistr.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonRegistr.FlatAppearance.BorderSize = 0;
            this.buttonRegistr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistr.Location = new System.Drawing.Point(326, 218);
            this.buttonRegistr.Name = "buttonRegistr";
            this.buttonRegistr.Size = new System.Drawing.Size(229, 48);
            this.buttonRegistr.TabIndex = 7;
            this.buttonRegistr.Text = "Нет аккаунта? \r\nРегистрация";
            this.buttonRegistr.UseVisualStyleBackColor = false;
            this.buttonRegistr.Click += new System.EventHandler(this.buttonRegistr_Click);
            // 
            // FormAutorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 365);
            this.Controls.Add(this.buttonRegistr);
            this.Controls.Add(this.buttonVoity);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelVvod);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAutorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAutorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVvod;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonVoity;
        private System.Windows.Forms.Button buttonRegistr;
    }
}