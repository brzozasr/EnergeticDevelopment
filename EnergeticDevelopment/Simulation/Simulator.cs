using System;
using System.Collections.Generic;
using System.Globalization;
using EnergeticDevelopment.EnergyConsumers;
using EnergeticDevelopment.EnergyPlants;
using EnergeticDevelopment.Factory;
using EnergeticDevelopment.Mines;
using EnergeticDevelopment.Storage;

namespace EnergeticDevelopment.Simulation
{
    public class Simulator
    {
        public void RunSimulation()
        {
            var singleton = ResourcesStorage.Singleton;
            var energyAssets = new EnergyAssetsFactory();
            
            energyAssets.CreateAssets();

            List<EnergyConsumer> consumers = new List<EnergyConsumer>
            {
                // new NewYork(),
                // new Poland(),
                new World()
            };

            foreach (var asset in energyAssets.Assets)
            {
                if (asset is Mine mine)
                {
                    mine.ResourcesMining(singleton);
                }
                else if (asset is EnergyPlant energyPlant)
                {
                    energyPlant.ProduceEnergy(singleton);
                }
            }

            foreach (var consumer in consumers)
            {
                consumer.ConsumeEnergy(singleton);
            }

            Display(singleton);
        }

        private void Display(ResourcesStorage singleton)
        {
            var storage = singleton.GetAllProducts();

            foreach (var (key, value) in storage)
            {
                Console.WriteLine($"{key}: {value:0.00} unit(s)");
            }

            Console.WriteLine($"Total energy usage: {singleton.TotalUsage.ToString("0.00", CultureInfo.CurrentCulture)}");
        }
    }
}