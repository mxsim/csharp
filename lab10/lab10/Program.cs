namespace lab10

{
    class Program {         
        static void Main()
        {
            Console.WriteLine("\n//=== What would you like to choose? \n Vector 2 - 0; \n Vector 3 - 1;");
            
            int userChoice = int.Parse(Console.ReadLine());
            
            ProxyClient proxy = new ProxyClient();
            proxy.getData(userChoice);

            Console.WriteLine("\n Restart? \n Yes - 0 \n No - 1");
            int exitChoice = int.Parse(Console.ReadLine());
            
            if (exitChoice==0) Main();
            else if (exitChoice==1) Console.WriteLine("Exit.");
            else Console.WriteLine("Error!!!");

        }
    }
}