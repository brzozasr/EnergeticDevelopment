using EnergeticDevelopment.Utilities;

namespace EnergeticDevelopment.EnergyPlants
{
    public class SolarPlant : EnergyPlant
    {
        protected override decimal ProducedUnit => 2;
        protected override decimal ConsumedResources => 0;
        protected override ResourceType Resource => ResourceType.Solar;
        
        public override decimal ProduceEnergy()
        {
            throw new System.NotImplementedException();
        }
    }
}