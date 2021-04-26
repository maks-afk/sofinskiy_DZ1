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
    public partial class form_menedger : Form
    {
        public form_menedger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form_login();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new form_newZakaz();
            form.ShowDialog();
            
        }

        private void form_menedger_Load(object sender, EventArgs e)
        {

        }
    }
}
