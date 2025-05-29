public class Notifier
{
    public void SendWelcomeMessage(string userType, string email)
    {
        Console.WriteLine($"[{userType}] Welcome email sent to: {email}");
    }

    public void SendLog(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}

public class UserRegistration
{
    private readonly Notifier _notifier = new Notifier();

    public void Register(string email)
    {
        Console.WriteLine("Registering user...");
        _notifier.SendWelcomeMessage("User", email);
        _notifier.SendLog("User registered successfully.");
    }
}

public class AdminRegistration
{
    private readonly Notifier _notifier = new Notifier();

    public void Register(string email)
    {
        Console.WriteLine("Registering admin...");
        _notifier.SendWelcomeMessage("Admin", email);
        _notifier.SendLog("Admin registered successfully.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var user = new UserRegistration();
        user.Register("user@example.com");
        /*
            Registering user...
            [User] Welcome email sent to: user@example.com
            Log: User registered successfully.
        */

        Console.WriteLine();

        var admin = new AdminRegistration();
        admin.Register("admin@example.com");
        /*
            Registering admin...
            [Admin] Welcome email sent to: admin@example.com
            Log: Admin registered successfully.
        */
    }
}
