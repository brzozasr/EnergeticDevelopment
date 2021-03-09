using EnergeticDevelopment.EnergyBase;
using EnergeticDevelopment.Storage;

namespace EnergeticDevelopment.Mines
{
    public abstract class Mine : Energy
    {
        protected abstract decimal ProduceResources { get; }

        public virtual void ResourcesMining(ResourcesStorage storage)
        {
            storage.StoreProducts(Resource, ProduceResources);
        }
    }
    
    
}