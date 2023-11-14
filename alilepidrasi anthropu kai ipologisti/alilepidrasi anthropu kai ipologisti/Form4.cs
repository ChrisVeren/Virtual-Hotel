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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected = listBox1.SelectedItem.ToString();
            listBox2.Items.Add(selected);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selected = listBox2.SelectedItem.ToString();
            listBox2.Items.Remove(selected);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("You dont have any items in your checkout.", "Error!");
            }
            else
            {
                Form5 f5 = new Form5();
                this.Hide();
                f5.ShowDialog();
                this.Close();
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
