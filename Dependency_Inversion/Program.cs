public interface IMessageService
{
    void SendMessage(string to, string message);
}

public class EmailService : IMessageService
{
    public void SendMessage(string to, string message)
    {
        Console.WriteLine($"[Email] To: {to} - Message: {message}");
    }
}

public class SmsService : IMessageService
{
    public void SendMessage(string to, string message)
    {
        Console.WriteLine($"[SMS] To: {to} - Message: {message}");
    }
}

public class Notification
{
    private readonly IMessageService _messageService;

    // Dependency injection
    public Notification(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void Notify(string to, string message)
    {
        _messageService.SendMessage(to, message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMessageService emailService = new EmailService();
        Notification emailNotification = new Notification(emailService);
        emailNotification.Notify("alice@example.com", "Welcome to the platform!"); // Output: [Email] To: alice@example.com - Message: Welcome to the platform!

        Console.WriteLine();

        IMessageService smsService = new SmsService();
        Notification smsNotification = new Notification(smsService);
        smsNotification.Notify("+9779812345678", "Your OTP is 7890"); // Output: [SMS] To: +9779812345678 - Message: Your OTP is 7890
    }
}