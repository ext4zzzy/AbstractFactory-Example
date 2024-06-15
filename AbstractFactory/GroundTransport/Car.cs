using AbstractFactory.Factories.Interfaces;

namespace AbstractFactory.GroundTransport;

public class Car : ITransport
{
    public int MaxSpeed => 90;

    public void GetMaxSpeed()
    {
        Console.WriteLine($"Max speed of car: {MaxSpeed}");
    }
}
