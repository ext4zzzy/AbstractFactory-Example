using AbstractFactory.Factories.Interfaces;

namespace AbstractFactory.AirTransport;

public class Helicopter : ITransport
{
    public int MaxSpeed => 200;

    public void GetMaxSpeed()
    {
        Console.WriteLine($"Max speed of helicopter: {MaxSpeed}");
    }
}