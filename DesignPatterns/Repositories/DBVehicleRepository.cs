﻿using DesignPatterns.Models;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Repositories
{
    public class DBVehicleRepository : IVehicleRepository
    {
        public void AddVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public Vehicle Find(string id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Vehicle> GetVehicles()
        {
            throw new NotImplementedException();
        }
    }
}
