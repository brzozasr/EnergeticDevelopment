using EnergeticDevelopment.Storage;
using EnergeticDevelopment.Utilities;

namespace EnergeticDevelopment.Mines
{
    public class UraniumMine : Mine
    {
        protected override ResourceType Resource => ResourceType.Uranium;
        protected override decimal ProduceResources => 100;
    }
}