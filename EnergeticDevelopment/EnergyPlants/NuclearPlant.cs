using EnergeticDevelopment.Utilities;

namespace EnergeticDevelopment.EnergyPlants
{
    public class NuclearPlant : EnergyPlant
    {
        protected override decimal ProducedUnit => 10000;
        protected override decimal ConsumedResources => 1;
        protected override ResourceType Resource => ResourceType.Uranium;
    }
}