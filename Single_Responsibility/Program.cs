public class MessagePrinter
{
    public void Print(string message)
    {
        Console.WriteLine($"Printer: {message}");
    }
}

public class Logger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logger: {message}");
    }
}

class Program
{
    static void Main()
    {
        var printer = new MessagePrinter();
        var logger = new Logger();
        string msg = "Hello!";
        printer.Print(msg); // Output: Printer: Hello!
        logger.Log(msg); // Output: Logger: Hello!
    }
}