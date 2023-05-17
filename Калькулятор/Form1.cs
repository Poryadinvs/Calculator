using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        float a, b;
        int count;
        int c;
        bool sim = true;
        private void button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 9;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 6;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Calculate();
            lable1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lable1.Text = ""; 
            TextBox1.Text = "";

            c++;

            EasterEgg(c);
        }
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 7; 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = float.Parse(TextBox1.Text);
            TextBox1.Clear();
            count = 1;
            lable1.Text = a.ToString() + "+";
            sim = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = float.Parse(TextBox1.Text);
            TextBox1.Clear();
            count = 2;
            lable1.Text = a.ToString() + "-";
            sim = true;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = float.Parse(TextBox1.Text);
            TextBox1.Clear();
            count = 3;
            lable1.Text = a.ToString() + "*";
            sim = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = float.Parse(TextBox1.Text);
            TextBox1.Clear();
            count = 4;
            lable1.Text = a.ToString() + "/";
            sim = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(sim==true)
            {
                TextBox1.Text = "-" + TextBox1.Text;
                sim = false;
            }
            else if (sim == false)
            {
                TextBox1.Text = TextBox1.Text.Replace("-", "");
                sim = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + ",";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(TextBox1.Text);
                    TextBox1.Text = b.ToString();
                    break;

                case 2:
                    b = a - float.Parse(TextBox1.Text);
                    TextBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(TextBox1.Text);
                    TextBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(TextBox1.Text);
                    TextBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }
        }

        private void EasterEgg(int cc)
        {
            if(cc == 25)
            {
                Easter ee = new Easter();
                ee.Show();
            }
        }
    }
}
