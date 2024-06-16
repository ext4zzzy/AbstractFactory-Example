# AbstractFactory-Example

This project is an example of the application of the "Abstract Factory" pattern. Using the example of a transport manufacturing factory, the architecture and applicability of this pattern are shown.


```mermaid
---
title: "Factory Architecture"
---
flowchart TD;
    A[ITransportFacility] -->|СreateGroundFactory| B[GroundFactory];
    A[ITransportFacility] -->|СreateAirFactory| C[AirFactory];
	B -->|CreateCar| D((IGroundTansport))
	B -->|CreateTruck| E((IGroundTansport))
	C -->|CreateAircraft| F((IAirTansport))
	C -->|СreateHelicopter| G((IAirTansport))
```

After choosing the type of production (ground / air), we create the transport we need and work with it.