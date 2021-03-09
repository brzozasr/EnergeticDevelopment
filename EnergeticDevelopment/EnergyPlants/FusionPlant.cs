using EnergeticDevelopment.Utilities;

namespace EnergeticDevelopment.EnergyPlants
{
    public class FusionPlant : EnergyPlant
    {
        protected override decimal ProducedUnit => 20000;
        protected override decimal ConsumedResources => 1;
        protected override ResourceType Resource => ResourceType.Helium;
        
        public override decimal ProduceEnergy()
        {
            throw new System.NotImplementedException();
        }
    }
}