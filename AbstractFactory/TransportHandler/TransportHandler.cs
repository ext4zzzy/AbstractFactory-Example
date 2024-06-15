using AbstractFactory.Enums;
using AbstractFactory.Factories.Interfaces;

namespace AbstractFactory.TransportHandler;

public class TransportHandler : ITransportHandler
{
    public void HandleGround(IGroundFactory groundFactory)
    {
        Console.WriteLine("Get type of ground transport (1 - car, 2 - truck)");

        var inputString = Console.ReadLine();

        if (!Enum.TryParse(typeof(GroundTransportType), inputString, out object? typeOfGround)) return;
        GroundTransportType? air = (GroundTransportType)typeOfGround;
            
        switch (air)
        {
            case GroundTransportType.Car:
                ITransport car = groundFactory.CreateCar();
                car.GetMaxSpeed();
                break;
                
            case GroundTransportType.Truck:
                ITransport truck = groundFactory.CreateTruck();
                truck.GetMaxSpeed();
                break;
                
            default:
                Console.WriteLine("Incorrect key!");
                return;
        }
    }
    
    public void HandleAir(IAirFactory airFactory)
    {
        Console.WriteLine("Get type of air transport (1 - aircraft, 2 - helicopter)");

        var inputString = Console.ReadLine();

        if (!Enum.TryParse(typeof(AirTransportType), inputString, out object? typeOfAircraft)) return;
        AirTransportType? air = (AirTransportType)typeOfAircraft;

        switch (air)
        {
            case AirTransportType.Aircraft:
                ITransport aircraft = airFactory.CreateAircraft();
                aircraft.GetMaxSpeed();
                break;
                
            case AirTransportType.Helicopter:
                ITransport helicopter = airFactory.CreateHelicopter();
                helicopter.GetMaxSpeed();
                break;
                
            default:
                Console.WriteLine("Incorrect key!");
                return;
        }
    }
}