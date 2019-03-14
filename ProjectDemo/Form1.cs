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
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
            label17.Text = Class1.user;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (Class1.user.Equals("Not Logged In"))
            {
                MessageBox.Show("Please Log In");
            }
            else
            {
                label17.Text = Class1.user;
                Form2 f1 = new Form2();
                f1.Show();
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Form3 rcdLog = new Form3();
            rcdLog.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Click(object sender, EventArgs e)
        {
            Form4 login = new Form4();
            login.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label17.Text = Class1.user;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Form5 search = new Form5();
            search.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
