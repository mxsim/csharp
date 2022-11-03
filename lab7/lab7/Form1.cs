using System;
using System.Drawing;

namespace lab7;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {}
    private void button1_Click(object sender, EventArgs e)
        {
            
            Graphics grph = pictureBox1.CreateGraphics();

            Brush sBrush = (Brush)Brushes.Red;

            Pen pen = new Pen(Color.Black, 3);

            int nArr = (int)((12-7.2)/0.5) + 1;

            PointF[] myPoints = new PointF[nArr];
            //Rectangle mybrushPoints = new Rectangle[nArr];
            

            int i=0; float z;

            for (float x = 7.2F; x <= 12; x = x + 0.5F)
            {

                z = (float)((float)(2*Math.Pow(Math.Sin(x+2),2))/(Math.Pow(x,2)+1));
                myPoints[i] = new PointF(x *100, z * 100 + 100);

                i++;

                Rectangle rectangle = new Rectangle(Convert.ToInt16(x*100-2),Convert.ToInt16(z*100 +100-2), 6,6);

                grph.FillRectangle(sBrush, rectangle);
            }
            grph.DrawLines(pen, myPoints);
            


        }
}
