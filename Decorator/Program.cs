using CharacterDecorator;
using CoffeeDecorator;

class Program
{
    static void Main(String[] args)
    {
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine(coffee.GetDescription()); // Output: Simple Coffee
        coffee = new SugarDecorator(coffee);
        Console.WriteLine(coffee.GetDescription()); // Output: Simple Coffee with Sugar
        coffee = new MilkDecorator(coffee);
        Console.WriteLine(coffee.GetDescription()); // Output: Simple Coffee with Sugar with Milk

        ICharacter mario = new Mario();
        Console.WriteLine(mario.GetAbilities()); // Output: Mario
        mario = new GunPower(mario);
        Console.WriteLine(mario.GetAbilities()); // Output: Mario with Gun power
        mario = new HeightPower(mario);
        Console.WriteLine(mario.GetAbilities()); // Output: Mario with Gun power with Height power
    }
}
