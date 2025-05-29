public interface IShape
{
    void Draw();
}

public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

public class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Square");
    }
}

class Program
{
    static void Main()
    {
        IShape[] shapes = { new Circle(), new Square() };
        foreach (var shape in shapes)
        {
            shape.Draw();
            /*
                Output: Drawing Circle
                Output: Drawing Square
            */
        }
    }
}