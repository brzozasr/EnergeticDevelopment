using System;
using EnergeticDevelopment.EnergyPlants;
using EnergeticDevelopment.Mines;
using EnergeticDevelopment.Storage;

namespace EnergeticDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = ResourcesStorage.Singleton;
            
            var coalMine = new CoalMine();
            coalMine.ResourcesMining(singleton);

            var coalPlant = new CoalPlant();
            coalPlant.ProduceEnergy(singleton);
            
            var storage = singleton.GetAllProducts();

            foreach (var (key, value) in storage)
            {
                Console.WriteLine($"Key: {key}, value: {value}");
            }
        }
    }
}