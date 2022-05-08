using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _09._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string way = @"C:\Users\nebo5\OneDrive\Рабочий стол\VS\Windows Forms\09.03\2303.txt";
        StreamReader sr = new StreamReader(way);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //для третьего задания!
        //int a, b;

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add("Привет мир!");
            //первое задание
            //label1.Text = "Привет мир!";

            //второе задание
            //label1.Text = textBox1.Text;

            //третье задание
            //a = Convert.ToInt32(textBox1.Text);
            //b = Convert.ToInt32(textBox2.Text);
            //label1.Text = Convert.ToString(a + b);

            //четвертое задание
            //label1.Text = Convert.ToString(ans1) + Convert.ToString(ans2); //чтобы вывелся текст, а не номера вариантов
            //label1.Text = ans1 + ans2;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        //int ans1, ans2;
        //string ans1, ans2;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            //ans1 = 1;
            //ans1 = "radioButton1";
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            //ans1 = 2;
            //ans1 = "radioButton2";
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            //ans1 = "radioButton3";
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            //ans2 = "radioButton4";
        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            //ans2 = "radioButton5";
        }

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            //ans2 = "radioButton6";
        }
    }
}
