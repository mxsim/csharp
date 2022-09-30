using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Коли користувач натиснув на кнопку відбуваються дії внутрі функції
        private void button1_Click(object sender, EventArgs e)
        {   
            // Змінні
            double d1 = 0;  
            Double sqrt;
            double rez = 0;

            // конвертує введене значення користувача у боксі textBox1 у еквівалентне рядкове представлення
            d1 = double.Parse(textBox1.Text.ToString());

            // Змінна для корення
            sqrt = Math.Pow(d1, 2);

            // Зміннює текст label4 на значення sqrt у форматі string
            label4.Text = "c^2 = " + sqrt.ToString();

            // Формула рівнобедреного прямокутника 
            rez = sqrt/4;

            // Виводить відповідь формули у label1
            label1.Text = "Площа рівнобедреного трикутника (S= c ^ 2 / 4)): S = " + sqrt.ToString()+" / 4"+" = "+rez.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
