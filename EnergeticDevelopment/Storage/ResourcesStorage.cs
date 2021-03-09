using System;
using System.Collections.Generic;
using EnergeticDevelopment.Utilities;

namespace EnergeticDevelopment.Storage
{
    public sealed class ResourcesStorage
    {
        public static ResourcesStorage Singleton => Storage.Value;
        public decimal TotalUsage { get; private set; }

        private static readonly Lazy<ResourcesStorage> Storage =
            new Lazy<ResourcesStorage>(() => new ResourcesStorage());

        private readonly Dictionary<ResourceType, decimal> _stockedProducts = new();

        private ResourcesStorage()
        {
            PrepareStorage();
        }

        private void PrepareStorage()
        {
            foreach (ResourceType type in Enum.GetValues(typeof(ResourceType)))
            {
                _stockedProducts.Add(type, 0);
            }
        }

        public void StoreProducts(ResourceType product, decimal quantity)
        {
            if (_stockedProducts.ContainsKey(product))
            {
                _stockedProducts[product] += quantity;
            }
            else
            {
                _stockedProducts[product] = quantity;
            }
        }

        public bool SubtractProduct(ResourceType product, decimal quantity)
        {
            try
            {
                if (_stockedProducts.ContainsKey(product))
                {
                    if (_stockedProducts[product] >= quantity)
                    {
                        _stockedProducts[product] -= quantity;
                        TotalUsage += quantity;
                        return true;
                    }
                    else
                    {
                        throw new ArgumentException($"There is not enough {product.ToString()} in the storage!");
                    }
                }
                else
                {
                    throw new ArgumentException(
                        $"There is no this kind of product ({product.ToString()}) in the storage!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public Dictionary<ResourceType, decimal> GetAllProducts()
        {
            return _stockedProducts;
        }
    }
}