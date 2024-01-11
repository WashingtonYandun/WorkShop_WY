using DesignPatterns.Models;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Infraestructure.Singleton
{
    public class MemoryCollection
    {
        public ICollection<Vehicle> Vehiculos { get; set; }

        private static readonly Lazy<MemoryCollection> LazyInstance = new Lazy<MemoryCollection>(() => new MemoryCollection());

        private MemoryCollection()
        {
            Vehiculos = new List<Vehicle>();
        }

        public static MemoryCollection GetInstance()
        {
            return LazyInstance.Value;
        }
    }
}
