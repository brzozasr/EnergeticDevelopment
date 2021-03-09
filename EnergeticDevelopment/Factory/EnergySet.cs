using EnergeticDevelopment.Utilities;

namespace EnergeticDevelopment.Factory
{
    public class EnergySet
    {
        public int EnergyAssetsCount => 9;
            
        public (EnergyAsset asset, int amount) ColeMine = (EnergyAsset.CoalMine, 0);
        
        public (EnergyAsset asset, int amount) UraniumMine = (EnergyAsset.UraniumMine, 0);
        
        public (EnergyAsset asset, int amount) MoonMine = (EnergyAsset.MoonMine, 0);
        
        public (EnergyAsset asset, int amount) HadronCollider = (EnergyAsset.HadronCollider, 0);
        
        public (EnergyAsset asset, int amount) CoalPlant = (EnergyAsset.CoalPlant, 0);
        
        public (EnergyAsset asset, int amount) SolarPlant = (EnergyAsset.SolarPlant, 0);
        
        public (EnergyAsset asset, int amount) NuclearPlant = (EnergyAsset.NuclearPlant, 0);
        
        public (EnergyAsset asset, int amount) FusionPlant = (EnergyAsset.FusionPlant, 0);
        
        public (EnergyAsset asset, int amount) AnnihilationPlant = (EnergyAsset.AnnihilationPlant, 0);
    }
}