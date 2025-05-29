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

class BasicSoftCoffee : Coffee
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Basic Soft Coffee..");
    }
}

class StandardSoftCoffee : Coffee
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Standard Soft Coffee..");
    }
}

class PremiumSoftCoffee : Coffee
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Premium Soft Coffee..");
    }
}

interface CoffeeFactory
{
    Coffee CreateCoffee(string type);
}

class LocalCafe : CoffeeFactory
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
class StarCafe : CoffeeFactory
{
    public Coffee CreateCoffee(string type)
    {
        switch (type.ToLower())
        {
            case "basic":
                return new BasicSoftCoffee();
            case "standard":
                return new StandardSoftCoffee();
            case "premium":
                return new PremiumSoftCoffee();
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
        string type = "standard";
        CoffeeFactory coffeeFactory = new LocalCafe();
        var coffee = coffeeFactory.CreateCoffee(type);
        coffee.Prepare(); // Output: Preparing Standard Coffee..
    }
}