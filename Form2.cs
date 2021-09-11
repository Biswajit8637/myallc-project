using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3rdproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            char z = char.Parse(textBox3.Text);
            switch (z) { 
                case '+':
                    textBox4.Text = (x + y).ToString();
                    break;
                case '-':
                    textBox4.Text = (x - y).ToString();
                    break;
                case '*':
                    textBox4.Text = (x * y).ToString();
                    break;
                case '/':
                    textBox4.Text = (x / y).ToString();
                    break;
                case '%':
                    textBox4.Text = (x % y).ToString();
                    break;
                default:
                    textBox4.Text = "invalid AO";
                    break;

            }

        }
    }
}
