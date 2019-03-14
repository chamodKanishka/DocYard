using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDemo
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            label17.Text = Class1.user;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
           
            this.Close();

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Login Successful");
                Class1.user = "admin";
                label17.Text = Class1.user;
            }
            else
                MessageBox.Show("Login Failed");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
