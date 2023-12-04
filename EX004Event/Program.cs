
Publisher publisher = new("publisher");
Subscriber subscriber1 = new("subscriber1");
Subscriber subscriber2 = new("subscriber2");

publisher.WriteToWall("Заметка 1");
publisher.Follow(subscriber1);
publisher.WriteToWall("Заметка 2");

abstract class User
{
    public string Name {get;}
    public User(string name)
    {
        Name = name;
    }
}
class Publisher : User
{
    private List<Subscriber> list;
    public Publisher(string name) : base(name) 
    {
        this.list = new();
     }

    
    internal void WriteToWall(string message)
    {
        Console.WriteLine(message);

        foreach (var item in this.list)
        {
            item.Notify(this, message);
        }
    }
    public void Follow(Subscriber subscriber)
    {
        this.list.Add(subscriber);
    }

}

class Subscriber : User
{
    public Subscriber(string name) : base(name) { }

    public void Notify(Publisher publisher, string message)
    {
        Console.WriteLine($"Стена: ");
    }
}