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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = imageList1.Images[0];

        }
      
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(textBox1.Text);
            if (temp <= 30 && temp >= 20)
            {
                label3.Text = temp.ToString();
            }
            else
            {
                MessageBox.Show("Pool Temperature has to between 20 and 30 degrees celsius.", "Warning!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            if (label6.Text == "Active")
            {
                label6.Text = "Deactivated";
                label8.Text = "Deactivated";

            }
            else
            {
                label6.Text = "Active";
                label10.Text = Convert.ToString(random.Next(0, 30));
            }

            if (label9.Visible == true)
            {
                label9.Visible = false;
                label10.Visible = false;

            }
            else
            {
                label9.Visible = true;
                label10.Visible = true;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label6.Text == "Active" && label8.Text == "Deactivated")
            {
                label8.Text = "Active";
            }
            else if (label6.Text == "Deactivated" && label8.Text == "Deactivated")
            {
                MessageBox.Show("You have to Activate the Pool Sensor First!!", "Error!");
            }
            else
            {
                label8.Text = "Deactivated";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.BackgroundImage = imageList1.Images[1];

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible == false)
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
