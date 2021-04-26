using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeWork1
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            maskedTextBox_password.UseSystemPasswordChar = true;
        }

        private void checkBox_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_password.Checked)
            {
                maskedTextBox_password.UseSystemPasswordChar = false;
            }
            else
            {
                maskedTextBox_password.UseSystemPasswordChar = true;
            }
        }
        private void SetDefault()
        {
            textBox_login.Text = String.Empty;
            maskedTextBox_password.Text = String.Empty;
            maskedTextBox_password.UseSystemPasswordChar = true;
            checkBox_password.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "login1" && maskedTextBox_password.Text == "tuptup") 
            {
                Form form = new form_menedger();
                form.Owner = this;
                form.Show();
                this.Hide();
            }
            
            else
            {
                textBox_login.Text = "";
                maskedTextBox_password.Text = "";
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
