using System.Collections.Generic;
using EnergeticDevelopment.EnergyBase;

namespace EnergeticDevelopment.Factory
{
    public abstract class EnergyFactory
    {
        public IList<Energy> Assets { get; } = new List<Energy>();
        protected readonly EnergySet EnergyStartSet = new();
        
        public abstract void CreateAssets();
    }
}