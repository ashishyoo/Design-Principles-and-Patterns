interface Coffee
{
    void Prepare();
}

class BasicCoffee : Coffee
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Basic Coffee..");
    }
}

class StandardCoffee : Coffee
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Standard Coffee..");
    }
}

class PremiumCoffee : Coffee
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Premium Coffee..");
    }
}

class CoffeeFactory
{
    public Coffee CreateCoffee(string type)
    {
        switch (type.ToLower())
        {
            case "basic":
                return new BasicCoffee();
            case "standard":
                return new StandardCoffee();
            case "premium":
                return new PremiumCoffee();
            default:
                Console.WriteLine("Invalid coffee type");
                return null;

        }
    }
}

class Program
{
    static void Main(String[] args)
    {
        string type = "basic";
        CoffeeFactory coffeeFactory = new CoffeeFactory();
        var coffee = coffeeFactory.CreateCoffee(type);
        coffee.Prepare(); // Output: Preparing Basic Coffee..
    }
}