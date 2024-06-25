using AbstractFactory.Transport.Interfaces;

namespace AbstractFactory.Transport.Ground;

public class Truck : IGroundTransport
{
    public int MaxSpeed => 60;

    public void GetMaxSpeed()
    {
        Console.WriteLine($"Max speed of truck: {MaxSpeed}");
    }
}