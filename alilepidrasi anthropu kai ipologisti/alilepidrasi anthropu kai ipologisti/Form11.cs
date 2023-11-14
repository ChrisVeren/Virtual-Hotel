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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.ShowDialog();
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mm = 0;
            int yy = 0;
            if (textBox2.Text == "MM" || textBox3.Text == "YY")
            {
                MessageBox.Show("Something went wrong with the validation proccess of your card details. Please ensure that your card details are correct.");
            }
            else 
            {
                 mm = int.Parse(textBox2.Text);
                 yy = int.Parse(textBox3.Text);

                if (textBox1.Text.Length == 16 && mm >= 1 && mm <= 12 && yy >= 23 && textBox5.Text.Length == 3)
                {
                    MessageBox.Show("Your Payment was succesful you can press 'ok' to collect your order. Thank you for your Purchase!!! ");
                    Form6 f6 = new Form6();
                    this.Hide();
                    f6.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong with the validation proccess of your card details. Please ensure that your card details are correct.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order was successful you can press 'ok' and complete payment when you receive your order. Thank you for your Purchase!!!");
            Form6 f6 = new Form6();
            this.Hide();
            f6.ShowDialog();
            this.Close();
        }
    }
}
