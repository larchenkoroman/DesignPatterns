using Flyweight;

FlyweightFactory flyweightFactory = new();
Client client = new(flyweightFactory);
client.Operation("Hello");
client.Operation("Hi");
client.Operation("World");

Console.WriteLine(flyweightFactory.Length.ToString());