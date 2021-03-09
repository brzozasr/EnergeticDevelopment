using System;
using System.Runtime.InteropServices;
using EnergeticDevelopment.EnergyBase;
using EnergeticDevelopment.Storage;
using EnergeticDevelopment.Utilities;

namespace EnergeticDevelopment.EnergyPlants
{
    public abstract class EnergyPlant : Energy
    {
        private ResourceType ProducedUnitType => ResourceType.Energy;
        protected abstract decimal ProducedUnit { get; }
        protected abstract decimal ConsumedResources { get; }

        public virtual void ProduceEnergy(ResourcesStorage storage)
        {
            if (storage.SubtractProduct(Resource, ConsumedResources) is var subtractProduct && subtractProduct)
            {
                storage.StoreProducts(ProducedUnitType, ProducedUnit);
            }
        }
    }
}