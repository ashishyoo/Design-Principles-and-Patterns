// Product
public class House
{
    public string Walls { get; set; }
    public string Roof { get; set; }
    public string Garage { get; set; }
    public string Garden { get; set; }

    public override string ToString()
    {
        return $"House with Walls: {Walls}, Roof: {Roof}, Garage: {Garage}, Garden: {Garden}";
    }
}

// Builder Interface
public interface IHouseBuilder
{
    void BuildWalls();
    void BuildRoof();
    void BuildGarage();
    void BuildGarden();
    House GetHouse();
}

// Concrete Builder
public class ConcreteHouseBuilder : IHouseBuilder
{
    private House _house = new House();

    public void BuildWalls()
    {
        _house.Walls = "Brick Walls";
    }

    public void BuildRoof()
    {
        _house.Roof = "Tiled Roof";
    }

    public void BuildGarage()
    {
        _house.Garage = "Two-Car Garage";
    }

    public void BuildGarden()
    {
        _house.Garden = "Flower Garden";
    }

    public House GetHouse()
    {
        return _house;
    }
}

// Director
public class HouseDirector
{
    private readonly IHouseBuilder _builder;

    public HouseDirector(IHouseBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructBasicHouse()
    {
        _builder.BuildWalls();
        _builder.BuildRoof();
    }

    public void ConstructFullHouse()
    {
        _builder.BuildWalls();
        _builder.BuildRoof();
        _builder.BuildGarage();
        _builder.BuildGarden();
    }
}

class Program
{
    static void Main()
    {
        IHouseBuilder builder = new ConcreteHouseBuilder();
        HouseDirector director = new HouseDirector(builder);

        director.ConstructBasicHouse();
        House basicHouse = builder.GetHouse();
        Console.WriteLine("Basic House: " + basicHouse);

        director.ConstructFullHouse();
        House fullHouse = builder.GetHouse();
        Console.WriteLine("Full House: " + fullHouse);
    }
}