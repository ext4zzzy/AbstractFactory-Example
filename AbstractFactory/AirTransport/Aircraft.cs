using AbstractFactory.Factories.Interfaces;

namespace AbstractFactory.AirTransport;

public class Aircraft : ITransport
{
    public int MaxSpeed => 800;

    public void GetMaxSpeed()
    {
        Console.WriteLine($"Max speed of aircraft: {MaxSpeed}");
    }
}