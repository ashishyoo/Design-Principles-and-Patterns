using CharacterDecorator;
using CoffeeDecorator;

class Program
{
    static void Main(String[] args)
    {
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine(coffee.GetDescription());
        coffee = new SugarDecorator(coffee);
        Console.WriteLine(coffee.GetDescription());
        coffee = new MilkDecorator(coffee);
        Console.WriteLine(coffee.GetDescription());

        ICharacter mario = new Mario();
        Console.WriteLine(mario.GetAbilities());
        mario = new GunPower(mario);
        Console.WriteLine(mario.GetAbilities());
        mario = new HeightPower(mario);
        Console.WriteLine(mario.GetAbilities());
    }
}
