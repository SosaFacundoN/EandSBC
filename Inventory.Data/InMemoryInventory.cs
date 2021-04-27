using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventory.Core;
using Inventory.Data;

namespace Inventory.Data
{
    public class InMemoryInventory : IInventoryData
    {
        List<Product> products;
        List<Provider> providers;
 
        public InMemoryInventory()
        {
            products = new List<Product>()
            {
                new Product{Id=1, Name="Coca Cola 500cc.", Quantity= 100, ProviderId = 1 /*Quiero que en vez de un número a mano, pueda llamar al Id del proveedor directamente.*/},
                new Product{Id=2, Name="Sprite 500cc.", Quantity = 40, ProviderId=1 },
                new Product{Id=3 , Name="Coca Cola 1.5L.", Quantity=50 , ProviderId= 1},
                new Product{Id=4 , Name="Pepsi 500cc.", Quantity=100 , ProviderId= 3 },
                new Product{Id=5 , Name="7Up 500cc.", Quantity= 50, ProviderId= 3 },
                new Product{Id=6 , Name="Ivess 2L", Quantity= 40, ProviderId= 2},
                new Product{Id=7 , Name="Papas Clásicas 100gr.", Quantity= 30 , ProviderId= 4 },
                new Product{Id=8 , Name="Chocolate Block 50gr.", Quantity=32 , ProviderId= 5},
                new Product{Id=9 , Name="KitKat", Quantity=18 , ProviderId= 6 },
                new Product{Id=10 , Name="Papas Ketchup 100gr.", Quantity=20 , ProviderId= 7}
            };
        }

        public Product AddProduct(Product newProduct)
        {
            products.Add(newProduct);
            newProduct.Id = products.Max(p => p.Id) + 1;
            return newProduct;
        }

        public Product AddProviderToProduct(Product updatedProductProvider)
        {
            var provider = products.SingleOrDefault(p => p.Id == updatedProductProvider.Id);
            if (provider != null)
            {
                provider.ProviderId = updatedProductProvider.Id;
            }
            return updatedProductProvider;
        }

        public Product DeleteProduct(Product deletedProduct)
        {
            var product = products.SingleOrDefault(p => p.Id == deletedProduct.Id);
            products.Remove(product);
            return deletedProduct;

        }

        public IEnumerable<Product> GetById()
        {
            return from p in products
                   orderby p.Id ascending
                   select p;
        }

        public IEnumerable<Product> GetOperationsByProducts(string productName)
        {
            return from p in products
                   where string.IsNullOrEmpty(productName) || p.Name.StartsWith(productName)
                   orderby p.Name
                   select p;
        }

        public IEnumerable<Product> GetOperationsByProvider(string providerName)
        {
            return from p in products
                   where string.IsNullOrEmpty(providerName) || p.Name.StartsWith(providerName)
                   orderby p.Name
                   select p;
        }

        public IEnumerable<Product> GetOperationsByQuantity()
        {
            List<Product> SortedList = products.OrderByDescending(p => p.Quantity).ToList();
            return SortedList;
        }

        public Product UpdateQuantity(Product updatedQuantity)
        {
            var provider = products.SingleOrDefault(p => p.Quantity == updatedQuantity.Quantity);
            if (provider != null)
            {
                provider.Quantity = updatedQuantity.Quantity;
            }
            return updatedQuantity;
        }
        public int Commit()
        {
            return 0;
        }
    }
}
