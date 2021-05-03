using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = textBox1.Text;
            pass = textBox2.Text;
            if (user == "Admin"&& pass == "Admin")
            {
                MessageBox.Show("You are logged in\nClick OK");
                this.Hide();
                Form3 f2 = new Form3();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }
    }
}
