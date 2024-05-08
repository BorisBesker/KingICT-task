﻿namespace KingICT.Tickets.ServiceLayer
{
    public class Service
    {

        // Service layer act as a bridge (gluer) between applications and bussiness logic, services get Unit of work(repository), mappers(for DTO transform) ... via dependency injection(resovled in the app)

        // in this project are located all services(interface and implementations) => external api calls, internal processing....etc

        // Its dependend of bussines logic, it does not need to know anything about particual implementation of DataAcess(abstraction)

        // processing the request, db calls, buiness logic methods are called(change object states)....        
    }
}
