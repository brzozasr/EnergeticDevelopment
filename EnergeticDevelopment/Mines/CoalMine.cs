using System;
using EnergeticDevelopment.Storage;
using EnergeticDevelopment.Utilities;

namespace EnergeticDevelopment.Mines
{
    public class CoalMine : Mine
    {
        protected override ResourceType Resource => ResourceType.Coal;
        protected override decimal ProduceResources => 40;
    }
}