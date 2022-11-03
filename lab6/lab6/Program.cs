namespace lab6
{
    class Program {         
        static void Main()
        {
            Console.WriteLine("\n//=== What would you like to choose? \n Vector 2 - 0; \n Vector 3 - 1;");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 0)
            {
                Vector classDec = new Vector2();
                
                classDec.getData();
                classDec.printArr();
                classDec.Calcul2();
            }
            else if ( userChoice==1)
            {
                Vector classDecl = new Vector3();

                classDecl.getData();
                classDecl.printArr();
                classDecl.Calcul2();
            }

            Console.WriteLine("\n Done, Would you like to do it again? \n Yes - 0 \n No - 1");
            int exitChoice = int.Parse(Console.ReadLine());
            
            if (exitChoice==0) Main();
            else if (exitChoice==1) Console.WriteLine("Exit.");
            else Console.WriteLine("Error!!!");

        }
    }
}