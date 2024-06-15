using AbstractFactory.Transport.Interfaces;

namespace AbstractFactory.Transport.Air;

public class Aircraft : IAirTransport
{
    public int MaxSpeed => 800;

    public void GetMaxSpeed()
    {
        Console.WriteLine($"Max speed of aircraft: {MaxSpeed}");
    }
}