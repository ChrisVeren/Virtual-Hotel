using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace alilepidrasi_anthropu_kai_ipologisti
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = imageList1.Images[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = imageList1.Images[0];

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            if (temp <=30 && temp >=20)
            { 
                label2.Text = temp.ToString();
            }
            else 
            {
                MessageBox.Show("Pool Temperature has to between 20 and 30 degrees celsius.","Warning!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.ShowDialog();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

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
            if (label6.Text == "Active") 
            {
                label6.Text = "Deactivated";
                label8.Text = "Deactivated";

            }
            else
            {
                label6.Text = "Active";
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
