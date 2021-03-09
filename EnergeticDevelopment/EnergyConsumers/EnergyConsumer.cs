using EnergeticDevelopment.EnergyBase;
using EnergeticDevelopment.Storage;
using EnergeticDevelopment.Utilities;

namespace EnergeticDevelopment.EnergyConsumers
{
    public abstract class EnergyConsumer : Energy
    {
        protected override ResourceType Resource => ResourceType.Energy;
        protected abstract decimal ConsumedEnergy { get; }

        public void ConsumeEnergy(ResourcesStorage storage)
        {
            storage.SubtractProduct(Resource, ConsumedEnergy);
        }
    }
}