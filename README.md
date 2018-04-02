# DotNetCore2-Architecture
Dot Net Core 2 Architecture

**This Architecture comes with the "battery-pack included"**:

* Multi-layer structure
* Code first approach including migrations.
* Comes with IOC (Inversion of Control) i.e. Dependency Injection.
* Comes with your favorite swagger template with authorize feature
* Comes with the JWT token authorization


## Layers :

#### RS.Common

Layer contains common and shared features.
That can be use in the project, across any layer

#### RS.Data

Layer will intract with the db entities and perform various db operations.
Here Interfaces and there implementation is present, that in turn send data
back to service layer i.e. business.
Migration history is also maintained here.

NOTE : Data sent back from this layer should be of Entity type.

#### RS.Entity

In this layer database entities are managed.

#### RS.Service

Service layer i.e. also called business layer; data sent from data layer managed and 
manipulated here and sent data back to web layer. 

NOTE : Data sent back from here should be of Viewmodel type.

#### RS.ViewModel

This layer keeps the list of Data transfer objects

#### RS.Web

This Layer will intract with outside world. :-)

