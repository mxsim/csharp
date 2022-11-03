namespace lab6;

public class Vector2 : Vector
{
    public int[,] arr;
    public int row;
    public int column;
    
    public Vector2()
    {
        row = 2;
        column = 2;
        arr = new int[row,column];
    }

    public override void getData()
    {
        Console.WriteLine("Getting Values: \n");

        int rowLength = arr.GetLength(0);
        int colLength = arr.GetLength(1);


                    Console.WriteLine("Print A vector x: ");      
                    arr[0,0] = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Print A vector y: ");      
                    arr[0,1] = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("Print B vector x: ");      
                    arr[1,0] = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Print B vector y: ");      
                    arr[1,1] = Convert.ToInt16(Console.ReadLine());
    }


    public override void printArr()
    {
        int rowLength = arr.GetLength(0);
        int colLength = arr.GetLength(1);

        Console.WriteLine("Printing Matrix: \n");

        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                Console.Write("{0} ", arr[i, j]);
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }
    }
    
    public override void Calcul2()
    {
        int equation =  (arr[0,0]*arr[1,1])-
                        (arr[1,0]*arr[0,1]);
        

        Console.WriteLine("detA = ("+arr[0,0]+" * "+arr[1,1]+") - ("
                                    +arr[1,0]+" * "+arr[0,1]+") =  " + equation + "\n");

        if (equation==0)
        {
            Console.Write("Linearly dependent! \n");
        }
        else
        {
            Console.Write("Linearly independent! \n");
        }

    }

    ~Vector2()
    {
        arr = null;
    }

}