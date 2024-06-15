using AbstractFactory.Transport.Interfaces;

namespace AbstractFactory.Transport.Air;

public class Helicopter : IAirTransport
{
    public int MaxSpeed => 200;

    public void GetMaxSpeed()
    {
        Console.WriteLine($"Max speed of helicopter: {MaxSpeed}");
    }
}