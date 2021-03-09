using EnergeticDevelopment.Storage;
using EnergeticDevelopment.Utilities;

namespace EnergeticDevelopment.EnergyPlants
{
    public class AnnihilationPlant : EnergyPlant
    {
        protected override decimal ProducedUnit => 25000;
        protected override decimal ConsumedResources => 1;
        protected override ResourceType Resource => ResourceType.Antimatter;
    }
}