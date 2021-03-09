using EnergeticDevelopment.Storage;
using EnergeticDevelopment.Utilities;

namespace EnergeticDevelopment.Mines
{
    public class MoonMine : Mine
    {
        protected override ResourceType Resource => ResourceType.Helium;
        protected override decimal ProduceResources => 10;
        
        public override void ResourcesMining(ResourcesStorage storage)
        {
            storage.StoreProducts(Resource, ProduceResources);
        }
    }
}