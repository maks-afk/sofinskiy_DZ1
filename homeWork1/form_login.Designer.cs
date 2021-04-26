namespace homeWork1
{
    partial class Form_login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label_loginoincription = new System.Windows.Forms.Label();
            this.label_passwordincription = new System.Windows.Forms.Label();
            this.maskedTextBox_password = new System.Windows.Forms.MaskedTextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.checkBox_password = new System.Windows.Forms.CheckBox();
            this.label_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(116, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "войти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_loginoincription
            // 
            this.label_loginoincription.AutoSize = true;
            this.label_loginoincription.Location = new System.Drawing.Point(53, 54);
            this.label_loginoincription.Name = "label_loginoincription";
            this.label_loginoincription.Size = new System.Drawing.Size(32, 13);
            this.label_loginoincription.TabIndex = 1;
            this.label_loginoincription.Text = "login:";
            // 
            // label_passwordincription
            // 
            this.label_passwordincription.AutoSize = true;
            this.label_passwordincription.Location = new System.Drawing.Point(53, 80);
            this.label_passwordincription.Name = "label_passwordincription";
            this.label_passwordincription.Size = new System.Drawing.Size(46, 13);
            this.label_passwordincription.TabIndex = 2;
            this.label_passwordincription.Text = "пароль:";
            // 
            // maskedTextBox_password
            // 
            this.maskedTextBox_password.Location = new System.Drawing.Point(116, 77);
            this.maskedTextBox_password.Name = "maskedTextBox_password";
            this.maskedTextBox_password.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_password.TabIndex = 3;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(116, 51);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 4;
            // 
            // checkBox_password
            // 
            this.checkBox_password.AutoSize = true;
            this.checkBox_password.Location = new System.Drawing.Point(116, 103);
            this.checkBox_password.Name = "checkBox_password";
            this.checkBox_password.Size = new System.Drawing.Size(15, 14);
            this.checkBox_password.TabIndex = 5;
            this.checkBox_password.UseVisualStyleBackColor = true;
            this.checkBox_password.CheckedChanged += new System.EventHandler(this.checkBox_password_CheckedChanged);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(17, 104);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(93, 13);
            this.label_password.TabIndex = 6;
            this.label_password.Text = "показать пароль";
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 208);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.checkBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.maskedTextBox_password);
            this.Controls.Add(this.label_passwordincription);
            this.Controls.Add(this.label_loginoincription);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.Form_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_loginoincription;
        private System.Windows.Forms.Label label_passwordincription;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.CheckBox checkBox_password;
        private System.Windows.Forms.Label label_password;
    }
}

