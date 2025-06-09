public class Engine
{
    public void Start()
    {
        Console.WriteLine("Engine started.");
    }

    public void Stop()
    {
        Console.WriteLine("Engine stopped.");
    }
}

public class Radio
{
    public void PlayMusic()
    {
        Console.WriteLine("Playing music...");
    }
}

public class Car
{
    private Engine _engine;
    private Radio _radio;

    public Car()
    {
        _engine = new Engine();
        _radio = new Radio();
    }

    public void StartCar()
    {
        _engine.Start();
        _radio.PlayMusic();
        Console.WriteLine("Car is running.");
    }

    public void StopCar()
    {
        _engine.Stop();
        Console.WriteLine("Car has stopped.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.StartCar();
        /*
            Output: Engine started.
            Output: Playing music...
            Output: Car is running.
        */

        Console.WriteLine();

        car.StopCar();
        /*
            Output: Engine stopped.
            Output: Car has stopped.
        */
    }
}
