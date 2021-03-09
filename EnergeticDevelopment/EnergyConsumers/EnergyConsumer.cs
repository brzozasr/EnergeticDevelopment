using EnergeticDevelopment.EnergyBase;
using EnergeticDevelopment.Utilities;

namespace EnergeticDevelopment.EnergyConsumers
{
    public abstract class EnergyConsumer : Energy
    {
        protected override ResourceType Resource => ResourceType.Energy;
        protected abstract decimal ConsumedEnergy { get; }
    }
}