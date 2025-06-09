// Product 1
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

// Product 2
interface Bread
{
    void Prepare();
}

class BasicBread : Bread
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Basic Bread..");
    }
}

class StandardBread : Bread
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Standard Bread..");
    }
}

class PremiumBread : Bread
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Premium Bread..");
    }
}

class BasicSoftBread : Bread
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Basic Soft Bread..");
    }
}

class StandardSoftBread : Bread
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Standard Soft Bread..");
    }
}

class PremiumSoftBread : Bread
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Premium Soft Bread..");
    }
}

interface MealFactory
{
    Coffee CreateCoffee(string type);
    Bread CreateBread(string type);
}

class LocalCafe : MealFactory
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

    public Bread CreateBread(string type)
    {
        switch (type.ToLower())
        {
            case "basic":
                return new BasicBread();
            case "standard":
                return new StandardBread();
            case "premium":
                return new PremiumBread();
            default:
                Console.WriteLine("Invalid bread type");
                return null;

        }
    }
}
class StarCafe : MealFactory
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

    public Bread CreateBread(string type)
    {
        switch (type.ToLower())
        {
            case "basic":
                return new BasicSoftBread();
            case "standard":
                return new StandardSoftBread();
            case "premium":
                return new PremiumSoftBread();
            default:
                Console.WriteLine("Invalid bread type");
                return null;
        }
    }
}

class Program
{
    static void Main(String[] args)
    {
        string type = "standard";
        MealFactory mealFactory = new LocalCafe();
        var coffee = mealFactory.CreateCoffee(type);
        var bread = mealFactory.CreateBread(type);
        coffee.Prepare(); // Output: Preparing Standard Coffee..
        bread.Prepare(); // Output: Preparing Standard Bread..
    }
}