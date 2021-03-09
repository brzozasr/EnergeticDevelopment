using EnergeticDevelopment.Storage;
using EnergeticDevelopment.Utilities;

namespace EnergeticDevelopment.Mines
{
    public class HadronCollider : Mine
    {
        protected override ResourceType Resource => ResourceType.Antimatter;
        protected override decimal ProduceResources => 1;
        
        public override void ResourcesMining(ResourcesStorage storage)
        {
            storage.StoreProducts(Resource, ProduceResources / 7);
        }
    }
}