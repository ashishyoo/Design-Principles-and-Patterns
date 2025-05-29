public interface IMessageService
{
    void SendMessage(string to, string message);
}

public class EmailService : IMessageService
{
    public void SendMessage(string to, string message)
    {
        Console.WriteLine($"Email sent to {to}: {message}");
    }
}

public class SmsService : IMessageService
{
    public void SendMessage(string to, string message)
    {
        Console.WriteLine($"SMS sent to {to}: {message}");
    }
}

public class NotificationSender
{
    private IMessageService _messageService;

    public NotificationSender(IMessageService messageService)
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
        // Inject EmailService
        IMessageService email = new EmailService();
        NotificationSender emailSender = new NotificationSender(email);
        emailSender.Notify("alice@example.com", "Welcome!"); // Output: Email sent to alice@example.com: Welcome!

        Console.WriteLine();

        // Inject SmsService
        IMessageService sms = new SmsService();
        NotificationSender smsSender = new NotificationSender(sms);
        smsSender.Notify("9845339814", "Your code is 1438"); // Output: SMS sent to 9845339814: Your code is 1438
    }
}