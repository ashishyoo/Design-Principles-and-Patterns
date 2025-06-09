public abstract class Shape
{
    public abstract int Area();
}

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public override int Area() => Width * Height;
}

public class Square : Shape
{
    public int Side { get; set; }
    public override int Area() => Side * Side;
}

class Program
{
    static void Main()
    {
        Shape rect = new Rectangle { Width = 4, Height = 5 };
        Shape sq = new Square { Side = 3 };
        Console.WriteLine($"Rectangle Area: {rect.Area()}"); // Output: Rectangle Area: 20
        Console.WriteLine($"Square Area: {sq.Area()}"); // Output: Square Area: 9
    }
}