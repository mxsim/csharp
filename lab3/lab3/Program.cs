/*
        //Лабораторна 3//
    Створити масив об’єктів класу „куля”. Куля задається радіусом та координатами центру.
    Визначити номери тих куль, в які попадає введена користувачем точка.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




namespace lab3
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Variables
            int n = 0;
            double     sr = 0, pX = 0, pY = 0, pZ = 0,
                       sX = 0, sY = 0, sZ = 0,
                       pvX, pvY, pvZ,
                       svX, svY, svZ;

            string pointName = "",
                   sphereName = "";


            // Class declaration
            SpherenPoint[] v = new SpherenPoint[100];
            SpherenPoint[] point = new SpherenPoint[1];
            
            // Creates sphere objects by n count
            Console.WriteLine("Enter sphere counts: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                v[i] = new SpherenPoint(i,pointName, sphereName, pX, pY, pZ, sX, sY, sZ, sr);
            }

            point[0] = new SpherenPoint(1, pointName, sphereName, pX, pY, pZ, sX, sY, sZ, sr);

            
         for (int i = 0; i < 1; i++)
         {
             Console.WriteLine("Enter name of Point ");
             pointName = Convert.ToString(Console.ReadLine());

             Console.WriteLine("Enter x of Point ");
             pvX = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter y of Point");
             pvY = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter z of Point ");
             pvZ = Convert.ToDouble(Console.ReadLine());

                point[0].poiName = pointName;
                point[0].pX = pvX;
                point[0].pY = pvY;
                point[0].pZ = pvZ;

            }
            point[0].printPoint();

         for (int i = 0; i < n; i++)
         {
             Console.WriteLine("Enter name of Sphere ");
             sphereName = Convert.ToString(Console.ReadLine());

             Console.WriteLine("Enter x of Sphere ");
             svX = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter y of Sphere ");
             svY = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter z of Sphere ");
             svZ = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter r of Sphere ");
             sr = Convert.ToDouble(Console.ReadLine());

             v[i].inputSphereCoordinates(n,sphereName, svX, svY, svZ, sr);
                v[i].printSphere(sphereName, svX, svY, svZ, sr);
         }

            Console.WriteLine("_____________");
         for (int i = 0; i < n; i++)
            {
                    int k = i + 1;
                if (v[i].GetLeng()==true)

                {
                    v[i].printSphere2();
                    Console.WriteLine(k + " belong. ");

                }

            }

            Console.WriteLine("Hello World!");
                Console.ReadLine();
        }       
    }
}
