using AbstractFactory.Factories.Interfaces;

namespace AbstractFactory.Factories.GroundTransport;

public class Truck : ITransport
{
    public int MaxSpeed => 60;

    public void GetMaxSpeed()
    {
        Console.WriteLine($"Max speed of truck: {MaxSpeed}");
    }
}