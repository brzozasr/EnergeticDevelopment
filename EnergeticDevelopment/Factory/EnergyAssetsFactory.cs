using EnergeticDevelopment.EnergyPlants;
using EnergeticDevelopment.Mines;
using EnergeticDevelopment.Utilities;

namespace EnergeticDevelopment.Factory
{
    public class EnergyAssetsFactory : EnergyFactory
    {
        public override void CreateAssets()
        {
            for (int i = 0; i < EnergyStartSet.EnergyAssetsCount; i++)
            {
                switch (i)
                {
                    case (int) EnergyAsset.CoalMine:
                        for (int j = 0; j < EnergyStartSet.ColeMine.amount; j++)
                        {
                            Assets.Add(new CoalMine());
                        }
                        break;
                    case (int) EnergyAsset.UraniumMine:
                        for (int j = 0; j < EnergyStartSet.UraniumMine.amount; j++)
                        {
                            Assets.Add(new UraniumMine());
                        }
                        break;
                    case (int) EnergyAsset.MoonMine:
                        for (int j = 0; j < EnergyStartSet.MoonMine.amount; j++)
                        {
                            Assets.Add(new MoonMine());
                        }
                        break;
                    case (int) EnergyAsset.HadronCollider:
                        for (int j = 0; j < EnergyStartSet.HadronCollider.amount; j++)
                        {
                            Assets.Add(new HadronCollider());
                        }
                        break;
                    case (int) EnergyAsset.CoalPlant:
                        for (int j = 0; j < EnergyStartSet.CoalPlant.amount; j++)
                        {
                            Assets.Add(new CoalPlant());
                        }
                        break;
                    case (int) EnergyAsset.SolarPlant:
                        for (int j = 0; j < EnergyStartSet.SolarPlant.amount; j++)
                        {
                            Assets.Add(new SolarPlant());
                        }
                        break;
                    case (int) EnergyAsset.NuclearPlant:
                        for (int j = 0; j < EnergyStartSet.NuclearPlant.amount; j++)
                        {
                            Assets.Add(new NuclearPlant());
                        }
                        break;
                    case (int) EnergyAsset.FusionPlant:
                        for (int j = 0; j < EnergyStartSet.FusionPlant.amount; j++)
                        {
                            Assets.Add(new FusionPlant());
                        }
                        break;
                    case (int) EnergyAsset.AnnihilationPlant:
                        for (int j = 0; j < EnergyStartSet.AnnihilationPlant.amount; j++)
                        {
                            Assets.Add(new AnnihilationPlant());
                        }
                        break;
                }
            }
        }
    }
}