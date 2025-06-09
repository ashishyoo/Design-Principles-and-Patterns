public interface IWorkable
{
    void Work();
}

public interface IFeedable
{
    void Eat();
}

public class HumanWorker : IWorkable, IFeedable
{
    public void Work()
    {
        Console.WriteLine("Human is working.");
    }

    public void Eat()
    {
        Console.WriteLine("Human is eating.");
    }
}

public class RobotWorker : IWorkable
{
    public void Work()
    {
        Console.WriteLine("Robot is working.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IWorkable human = new HumanWorker();
        IFeedable feedableHuman = (IFeedable)human;

        human.Work();           // Output: Human is working.
        feedableHuman.Eat();    // Output: Human is eating.

        IWorkable robot = new RobotWorker();
        robot.Work();           // Output: Robot is working.
    }
}