using AbstractFactory.Transport.Interfaces;

namespace AbstractFactory.Transport.Ground;

public class Car : IGroundTransport
{
    public int MaxSpeed => 90;

    public void GetMaxSpeed()
    {
        Console.WriteLine($"Max speed of car: {MaxSpeed}");
    }
}
