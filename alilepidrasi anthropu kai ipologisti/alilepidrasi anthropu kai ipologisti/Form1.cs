using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alilepidrasi_anthropu_kai_ipologisti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible= true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text== "1234")
            {
                MessageBox.Show("Login successful.","Log-In");
                Form3 f3 = new Form3();
                this.Hide();
                f3.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Password incorrect, try again!", "Log-In");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Visible==false)
            {
                richTextBox1.Visible = true;
            }
            else
            {
                richTextBox1.Visible = false;

            }
        }
    }
}
