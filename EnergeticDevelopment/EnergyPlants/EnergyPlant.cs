using EnergeticDevelopment.EnergyBase;
using EnergeticDevelopment.Utilities;

namespace EnergeticDevelopment.EnergyPlants
{
    public abstract class EnergyPlant : Energy
    {
        protected abstract decimal ProducedUnit { get; }
        protected abstract decimal ConsumedResources { get; }

        public abstract decimal ProduceEnergy();
    }
}