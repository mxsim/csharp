using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int z = int.Parse(textBox3.Text);

            int r = 6;
            double su;

            int xo = 1;
            int yo = 2;
            int zo = 2;

            //int dx = Math.Abs(x - xo);
            //int dy = Math.Abs(y - yo);
            //int dz = Math.Abs(z - zo);

            su = Math.Sqrt(Math.Pow(xo - x, 2) + Math.Pow(yo - y, 2) + Math.Pow(zo - z, 2));
            if (su<=r) label6.Text = "yes";
            else label6.Text = "No";
            

            Sphere mysphere = new Sphere(x,y,z);


            Sphere mysphere2 = new Sphere();
            mysphere2.x = x;
            mysphere2.y = y;
            mysphere2.z = z;



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
