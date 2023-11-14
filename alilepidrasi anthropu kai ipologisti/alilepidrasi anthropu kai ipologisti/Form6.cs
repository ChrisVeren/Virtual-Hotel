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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.BackgroundImage = imageList1.Images[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = imageList1.Images[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Text== "TV off")
            {
                button3.Text = "TV on";
            }
            else
            {
                button3.Text = "TV off";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
             MessageBox.Show("We will call you sortly.","Guest Help Center");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();
            f7.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string selected = listBox1.SelectedItem.ToString();
            listBox2.Items.Add(selected);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string selected = listBox2.SelectedItem.ToString();
            listBox2.Items.Remove(selected);
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("You dont have any items in your checkout.","Error!");
            }
            else 
            {
                Form11 f11 = new Form11();
                this.Hide();
                f11.ShowDialog();
                this.Close();
            }
        }

        private void Form6_Load(object sender, EventArgs e)
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
