using Patterns.AbstractFactory;

class Program
{
    static async Task Main(string[] args)
    {
        //AbstractFactory();

        Console.ReadLine();
    }
    static void AbstractFactory()
    {
        Client client = new Client();

        IAbstractFactory FactoryA = client.CreateFactory("A");
        Console.WriteLine(FactoryA.CreateProductA().Name);
        Console.WriteLine(FactoryA.CreateProductB().Name);

        IAbstractFactory FactoryB = client.CreateFactory("B");
        Console.WriteLine(FactoryB.CreateProductA().Name);
        Console.WriteLine(FactoryB.CreateProductB().Name);

        try
        {
            IAbstractFactory FactoryError = client.CreateFactory("Error");
            Console.WriteLine(FactoryError.CreateProductA().Name);
            Console.WriteLine(FactoryError.CreateProductB().Name);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

}

