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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            label3.Text = "Moving Forward";

            if (label7.Text == "Open")
            {
                label7.Text = "Closed";
                label8.Text = "Up";

                label7.ForeColor = Color.Red;
                label8.ForeColor = Color.Red;
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            label3.Text = "Not Moving";

        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            label3.Text = "Turning Left";

            if (label7.Text == "Open")
            {
                label7.Text = "Closed";
                label8.Text = "Up";

                label7.ForeColor = Color.Red;
                label8.ForeColor = Color.Red;
            }

        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            label3.Text = "Not Moving";

        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            label3.Text = "Turning Right";

            if (label7.Text == "Open")
            {
                label7.Text = "Closed";
                label8.Text = "Up";

                label7.ForeColor = Color.Red;
                label8.ForeColor = Color.Red;
            }

        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            label3.Text = "Not Moving";

        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            label3.Text = "Moving Backwards";

            if (label7.Text == "Open")
            {
                label7.Text = "Closed";
                label8.Text = "Up";

                label7.ForeColor = Color.Red;
                label8.ForeColor = Color.Red;
            }

        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            label3.Text = "Not Moving";

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label7.Text = "Open";
            label8.Text = "Down";

            label7.ForeColor= Color.Green;
            label8.ForeColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label7.Text = "Closed";
            label8.Text = "Up";

            label7.ForeColor = Color.Red;
            label8.ForeColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label9.Text == "Off") 
            { 
                label9.Text = "On";
                label9.ForeColor = Color.Green;
            }
            else
            {
                label9.Text = "Off";
                label9.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label7.Text == "Open")
            {
                label7.Text= "Closed";
                label8.Text= "Up";

                label7.ForeColor = Color.Red;
                label8.ForeColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {  
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            pictureBox1.Visible= true;
            panel1.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[1];
            pictureBox1.Visible = true;
            panel1.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            this.Hide();
            f8.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
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
