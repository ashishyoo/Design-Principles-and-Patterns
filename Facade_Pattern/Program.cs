// Subsystem components
public class DvdPlayer
{
    public void TurnOn()
    {
        Console.WriteLine("DVD Player is ON");
    }
    public void Play(string movie)
    {
        Console.WriteLine($"Playing movie: {movie}");
    }
    public void TurnOff()
    {
        Console.WriteLine("DVD Player is OFF");
    }
}

public class Projector
{
    public void TurnOn()
    {
        Console.WriteLine("Projector is ON");
    }
    public void SetInput(string input)
    {
        Console.WriteLine($"Projector input set to {input}");
    }
    public void TurnOff()
    {
        Console.WriteLine("Projector is OFF");
    }
}

public class SoundSystem
{
    public void TurnOn()
    {
        Console.WriteLine("Sound System is ON");
    }
    public void SetVolume(int level)
    {
        Console.WriteLine($"Sound System volume set to {level}");
    }
    public void TurnOff()
    {
        Console.WriteLine("Sound System is OFF");
    }
}

// Facade class
public class HomeTheaterFacade
{
    private readonly DvdPlayer _dvdPlayer;
    private readonly Projector _projector;
    private readonly SoundSystem _soundSystem;

    public HomeTheaterFacade(DvdPlayer dvdPlayer, Projector projector, SoundSystem soundSystem)
    {
        _dvdPlayer = dvdPlayer;
        _projector = projector;
        _soundSystem = soundSystem;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Setting up home theater to watch a movie...");
        _dvdPlayer.TurnOn();
        _projector.TurnOn();
        _projector.SetInput("DVD");
        _soundSystem.TurnOn();
        _soundSystem.SetVolume(10);
        _dvdPlayer.Play(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting down home theater...");
        _dvdPlayer.TurnOff();
        _projector.TurnOff();
        _soundSystem.TurnOff();
    }
}

class Program
{
    static void Main()
    {
        var dvdPlayer = new DvdPlayer();
        var projector = new Projector();
        var soundSystem = new SoundSystem();

        var homeTheater = new HomeTheaterFacade(dvdPlayer, projector, soundSystem);

        homeTheater.WatchMovie("Inception");
        /*
            Output: Setting up home theater to watch a movie...
            Output: DVD Player is ON
            Output: Projector is ON
            Output: Projector input set to DVD
            Output: Sound System is ON
            Output: Sound System volume set to 10
            Output: Playing movie: Inception
        */

        Console.WriteLine();

        homeTheater.EndMovie();
        /*
            Output: Shutting down home theater...
            Output: DVD Player is OFF
            Output: Projector is OFF
            Output: Sound System is OFF
        */
    }
}