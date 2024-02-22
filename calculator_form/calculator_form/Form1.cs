using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // botton 1 - 10 ↓

        private void button1_Click(object sender, EventArgs e)
        {
            if (label3.Text != "+" && label3.Text != "-" && label3.Text != "/" && label3.Text != "x")
            {
                label2.Text += 1;
            }
            if (label3.Text == "+" || label3.Text == "-" || label3.Text == "/" || label3.Text == "x")
            {  
                label1.Text += 1;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label3.Text != "+" && label3.Text != "-" && label3.Text != "/" && label3.Text != "x")
            {
                label2.Text +=2;
            }
            if (label3.Text == "+" || label3.Text == "-" || label3.Text == "/" || label3.Text == "x")
            {
                label1.Text += 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label3.Text != "+" && label3.Text != "-" && label3.Text != "/" && label3.Text != "x")
            {
                label2.Text += 3;
            }
            if (label3.Text == "+" || label3.Text == "-" || label3.Text == "/" || label3.Text == "x")
            {
                label1.Text += 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label3.Text != "+" && label3.Text != "-" && label3.Text != "/" && label3.Text != "x")
            {
                label2.Text += 4;
            }
            if (label3.Text == "+" || label3.Text == "-" || label3.Text == "/" || label3.Text == "x")
            {
                label1.Text += 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label3.Text != "+" && label3.Text != "-" && label3.Text != "/" && label3.Text != "x")
            {
                label2.Text += 5;
            }
            if (label3.Text == "+" || label3.Text == "-" || label3.Text == "/" || label3.Text == "x")
            {
                label1.Text += 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label3.Text != "+" && label3.Text != "-" && label3.Text != "/" && label3.Text != "x")
            {
                label2.Text += 6;
            }
            if (label3.Text == "+" || label3.Text == "-" || label3.Text == "/" || label3.Text == "x")
            {
                label1.Text += 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label3.Text != "+" && label3.Text != "-" && label3.Text != "/" && label3.Text != "x")
            {
                label2.Text += 7;
            }
            if (label3.Text == "+" || label3.Text == "-" || label3.Text == "/" || label3.Text == "x")
            {
                label1.Text += 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label3.Text != "+" && label3.Text != "-" && label3.Text != "/" && label3.Text != "x")
            {
                label2.Text += 8;
            }
            if (label3.Text == "+" || label3.Text == "-" || label3.Text == "/" || label3.Text == "x")
            {
                label1.Text += 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label3.Text != "+" && label3.Text != "-" && label3.Text != "/" && label3.Text != "x")
            {
                label2.Text += 9;
            }
            if (label3.Text == "+" || label3.Text == "-" || label3.Text == "/" || label3.Text == "x")
            {
                label1.Text += 9;
            }  
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label3.Text != "+" && label3.Text != "-" && label3.Text != "/" && label3.Text != "x")
            {
                label2.Text += 0;
            }
            if (label3.Text == "+" || label3.Text == "-" || label3.Text == "/" || label3.Text == "x")
            {
                label1.Text += 0;
            }
        }

        // botton 1 - 10 ↑

        // for math ↓
        private void button12_Click(object sender, EventArgs e)
        {
            if (label3.Text == "+")
            {
                float p = float.Parse(label1.Text) + float.Parse(label2.Text);
                textBox2.Text = p.ToString();
                label4.Text = p.ToString();
            }

            if (label3.Text == "-")
            {
                float m = float.Parse(label1.Text) - float.Parse(label2.Text);
                textBox2.Text = m.ToString();
                label4.Text = m.ToString();
            }

            if (label3.Text == "x")
            {
                float mp = float.Parse(label1.Text) * float.Parse(label2.Text);
                textBox2.Text = mp.ToString();
                label4.Text = mp.ToString();
            }

            if (label3.Text == "/")
            {
                float d = float.Parse(label1.Text) / float.Parse(label2.Text);
                textBox2.Text = d.ToString();
                label4.Text = d.ToString();
            }
        }


        // for math ↓

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Text = "+";
            label3.Text = button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Text = "-";
            label3.Text = button14.Text; 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Text = "x";
            label3.Text = button15.Text; 
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Text = "/";
            label3.Text = button16.Text; 
        }


        // for clear Console ↓
        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            
        }
        private void button19_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        // for clear Console  ↑

        // for bg color ↓
        private void button11_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 26, 26);
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
           this.BackColor = Color.FromArgb(255, 232, 232);
           
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (label3.Text != "+" && label3.Text != "-" && label3.Text != "/" && label3.Text != "x")
            {
                label2.Text += ".";
            }
            if (label3.Text == "+" || label3.Text == "-" || label3.Text == "/" || label3.Text == "x")
            {
                label1.Text += ".";

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (label3.Text != "+" && label3.Text != "-" && label3.Text != "/" && label3.Text != "x")
            {
                label2.Text = label2.Text.Remove(label2.Text.Length -1);
            }
            if (label3.Text == "+" || label3.Text == "-" || label3.Text == "/" || label3.Text == "x")
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
            }
        }

        

    }
}
