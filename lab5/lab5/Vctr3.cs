namespace lab4;

public class Vector3: Vector2
{    
    public Vector3()
    {
        arr = new int[3,3];
    }

    public override void getData()
    {
        Console.WriteLine("Getting Values: ");

        int rowLength = arr.GetLength(0);
        int colLength = arr.GetLength(1);


        Console.WriteLine("Print A vector x: ");      
        arr[0,0] = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Print A vector y: ");      
        arr[0,1] = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Print A vector z: ");      
        arr[0,2] = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Print B vector x: ");      
        arr[1,0] = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Print B vector y: ");      
        arr[1,1] = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Print B vector z: ");      
        arr[1,2] = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Print C vector x: ");      
        arr[2,0] = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Print C vector y: ");      
        arr[2,1] = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Print C vector z: ");      
        arr[2,2] = Convert.ToInt16(Console.ReadLine());


    }
    //print

    public override void Calcul2()
    {
        int equation = (arr[0,0]*arr[1,1]*arr[2,2])+
                       (arr[0,1]*arr[1,2]*arr[2,0])+
                       (arr[0,2]*arr[1,0]*arr[2,1])-
                       (arr[0,2]*arr[1,1]*arr[2,0])-
                       (arr[0,0]*arr[1,2]*arr[2,1])-
                       (arr[0,1]*arr[1,0]*arr[2,2]);

        Console.WriteLine("detA = ("+arr[0,0]+" * "+arr[1,1]+" * "+arr[2,2]+") + ("
                                    +arr[0,1]+" * "+arr[1,2]+" * "+arr[2,0]+") + ("
                                    +arr[0,2]+" * "+arr[1,0]+" * "+arr[2,1]+") + ("
                                    +arr[0,2]+" * "+arr[1,1]+" * "+arr[2,0]+") - ("
                                    +arr[0,0]+" * "+arr[1,2]+" * "+arr[2,1]+") - ("
                                    +arr[0,1]+" * "+arr[1,0]+" * "+arr[2,2]+") =  " + equation+"\n");

        
        if (equation==0)
        {
            Console.Write("Linearly dependent!");
        }
        else
        {
            Console.Write("Linearly independent!");
        }


    }

    //check
}