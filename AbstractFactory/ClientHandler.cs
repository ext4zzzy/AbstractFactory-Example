

using AbstractFactory.Transport.Enums;
using AbstractFactory.Transport.Factories.AirFactory.Interfaces;
using AbstractFactory.Transport.Factories.GroundFactory.Interfaces;
using AbstractFactory.Transport.Interfaces;
using AbstractFactory.TransportHandler.Interfaces;

namespace AbstractFactory;

public class ClientHandler
{
    public void Handle(ITransportHandler transportHandler, ITransportFacility transportFacility)
    {
        while (true)
        {
            Console.WriteLine("Get type of transport: 1 - ground, 2 - air");

            var inputString = Console.ReadLine();

            if (!Enum.TryParse(typeof(TransportType), inputString, out object? typeOfTransport)) continue;
            TransportType? transport = (TransportType)typeOfTransport;

            if (Enum.IsDefined(typeof(TransportType), transport))
            {
                switch (transport)
                {
                    case TransportType.Ground:
                        IGroundFactory groundFactory = transportFacility.CreateGroundFactory();
                        transportHandler.HandleGround(groundFactory);
                        break;
                    
                    case TransportType.Air:
                        IAirFactory airFactory = transportFacility.CreateAirFactory();
                        transportHandler.HandleAir(airFactory);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect key!");
            }
        }
    }
}