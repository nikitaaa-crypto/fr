using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                double one = double.Parse(textBox1.Text);
                double two = double.Parse(textBox2.Text);
                double sum = one * two;
                label1.Text = sum.ToString();
            }
            catch (FormatException)
            {
                label1.Text = "Ошибка: Введите числа.";
            }
            catch (Exception ex)
            {
                label1.Text = "Ошибка:" + ex.Message;
            }
        }
    }
}
