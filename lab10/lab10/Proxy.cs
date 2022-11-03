namespace lab10;

public interface IClient
{
 void getData(int userChoice);
}

public class RealClient : IClient
{

 public RealClient()
 {
 }

 public void getData(int userChoice)

 {
    if (userChoice == 0)
    {
        LinearVectors linearVectors = new vector2Factory().createVectorProduct();
        linearVectors.getData();
        linearVectors.printArr();
        linearVectors.Calcul2();

    }
    else if ( userChoice==1)
    {
        LinearVectors linearVectors = new vector3Factory().createVectorProduct();
        linearVectors.getData();
        linearVectors.printArr();
        linearVectors.Calcul2();

    }
    }
}

public class ProxyClient : IClient
{
 RealClient client = new RealClient();
 public ProxyClient()
 {
 Console.WriteLine("ProxyClient: Initialized");
 }

 public void getData(int userChoice)
 {
    if (userChoice == 0 || userChoice == 1)
    {
        client.getData(userChoice);
    }
    else
    {
        Console.WriteLine("Please write down your option, no other exceptions.");
    }
    
 }
}

