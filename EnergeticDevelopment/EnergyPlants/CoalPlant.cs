using EnergeticDevelopment.Storage;
using EnergeticDevelopment.Utilities;

namespace EnergeticDevelopment.EnergyPlants
{
    public class CoalPlant : EnergyPlant
    {
        protected override decimal ProducedUnit => 7;
        protected override decimal ConsumedResources => 100;
        protected override ResourceType Resource => ResourceType.Coal;
    }
}