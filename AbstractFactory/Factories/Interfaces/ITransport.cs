namespace AbstractFactory.Factories.Interfaces;

public interface ITransport 
{
    int MaxSpeed { get;  }

    void GetMaxSpeed();
}