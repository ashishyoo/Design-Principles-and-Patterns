public interface IChannel
{
    public void Subscribe(ISubscriber subscriber);
    public void Unsubscribe(ISubscriber subscriber);
    public void NotifySubscriber();
}

public interface ISubscriber
{
    public void Update();
    public string GetName();
}

public class Channel : IChannel
{
    private string title;
    private string channel;
    List<ISubscriber> subscribers = new List<ISubscriber>();

    public Channel(string name)
    {
        this.channel = name;
    }

    public void Subscribe(ISubscriber subscriber)
    {
        Console.WriteLine($"{subscriber.GetName()} subscribed {this.channel}.");
        subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        Console.WriteLine($"{subscriber.GetName()} unsubscribed {this.channel}.");
        subscribers.Remove(subscriber);
    }

    public void NotifySubscriber()
    {
        foreach (var subscriber in subscribers)
        {
            subscriber.Update();
        }
    }

    public void UploadVideo(string title)
    {
        this.title = title;
        Console.WriteLine($"{channel}: {title} uploaded..");
        NotifySubscriber();
    }

    public string GetVideo()
    {
        return $"{title} uploaded recently.";
    }

    public string GetName()
    {
        return this.channel;
    }
}

public class Subcriber : ISubscriber
{
    string name;
    Channel channel;

    public Subcriber(string name, Channel channel)
    {
        this.name = name;
        this.channel = channel;
    }

    public string GetName()
    {
        return this.name;
    }

    public void Update()
    {
        Console.WriteLine($"{this.name}, {channel.GetName()} uploaded {channel.GetVideo()}.");
    }
}

class Program
{
    static void Main(String[] args)
    {
        Channel channel = new Channel("NatGeo");
        Subcriber sub1 = new Subcriber("Ashish", channel);
        Subcriber sub2 = new Subcriber("Yeju", channel);

        channel.Subscribe(sub1); // Output: Ashish subscribed NatGeo.
        channel.Subscribe(sub2); // Output: Yeju subscribed NatGeo.
        channel.UploadVideo("Butterflies of town");
        /*
            Output: NatGeo: Butterflies of town uploaded..
            Output: Ashish, NatGeo uploaded Butterflies of town uploaded recently..
            Output: Yeju, NatGeo uploaded Butterflies of town uploaded recently..
        */

        channel.Unsubscribe(sub1); // Output: Ashish unsubscribed NatGeo.
        channel.UploadVideo("Laps of Mountain");
        /*
            Output: NatGeo: Laps of Mountain uploaded..
            Output: Yeju, NatGeo uploaded Laps of Mountain uploaded recently..
        */
    }
}
