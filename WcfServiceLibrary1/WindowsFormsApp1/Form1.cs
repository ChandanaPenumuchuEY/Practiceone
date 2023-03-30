using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client x = new ServiceReference1.Service1Client();
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            label1.Text = x.addition(a, b).ToString();
            label2.Text = x.subtraction(a, b).ToString();
            label3.Text = x.multiplication(a, b).ToString();
            label4.Text = x.division(a, b).ToString();
        }
    }
}
