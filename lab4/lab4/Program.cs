namespace lab4
{
    class Program {         
        static void Main()
        {
            Console.WriteLine("\n//=== What would you like to choose? \n Vector 2 - 0; \n Vector 3 - 1;");
            int userChoice = int.Parse(Console.ReadLine());

            Vector2 classDecl = new Vector2();

            if (userChoice == 0)
            {
                classDecl = new Vector2();
                
                classDecl.getData();
                classDecl.printArr();
                classDecl.Calcul2();

            }
            else if ( userChoice==1)
            {
                Vector3 classDecl2 = new Vector3();
                classDecl2.getData3();
                classDecl2.printArr();
                classDecl2.Calcul3();
            }

            Console.WriteLine("\n Done, Would you like to do it again? \n Yes - 0 \n No - 1");
            int exitChoice = int.Parse(Console.ReadLine());
            
            if (exitChoice==0) Main();
            else if (exitChoice==1) Console.WriteLine("Exit.");
            else Console.WriteLine("Error!!!");

        }
    }
}