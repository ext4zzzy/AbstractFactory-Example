namespace AbstractFactory.Transport.Interfaces;

public interface ITransport 
{
    int MaxSpeed { get;  }

    void GetMaxSpeed();
}