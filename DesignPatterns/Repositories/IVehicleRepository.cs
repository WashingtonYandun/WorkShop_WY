using DesignPatterns.Models;
using System.Collections.Generic;

namespace DesignPatterns.Repositories
{
    public interface IVehicleRepository
    {
        ICollection<Vehicle> GetVehicles();

        void AddVehicle(Vehicle vehicle);

        Vehicle Find(string id);

    }
}