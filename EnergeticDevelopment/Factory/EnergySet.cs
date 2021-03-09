using EnergeticDevelopment.Utilities;

namespace EnergeticDevelopment.Factory
{
    public class EnergySet
    {
        public int EnergyAssetsCount => 9;
            
        public (EnergyAsset asset, int amount) ColeMine = (EnergyAsset.CoalMine, 22530);
        
        public (EnergyAsset asset, int amount) UraniumMine = (EnergyAsset.UraniumMine, 5);
        
        public (EnergyAsset asset, int amount) MoonMine = (EnergyAsset.MoonMine, 6);
        
        public (EnergyAsset asset, int amount) HadronCollider = (EnergyAsset.HadronCollider, 75);
        
        public (EnergyAsset asset, int amount) CoalPlant = (EnergyAsset.CoalPlant, 9000);
        
        public (EnergyAsset asset, int amount) SolarPlant = (EnergyAsset.SolarPlant, 2500);
        
        public (EnergyAsset asset, int amount) NuclearPlant = (EnergyAsset.NuclearPlant, 450);
        
        public (EnergyAsset asset, int amount) FusionPlant = (EnergyAsset.FusionPlant, 28);
        
        public (EnergyAsset asset, int amount) AnnihilationPlant = (EnergyAsset.AnnihilationPlant, 10);
    }
}