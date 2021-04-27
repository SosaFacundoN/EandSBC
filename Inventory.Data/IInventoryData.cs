using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Core;

namespace Inventory.Data
{
    public interface IInventoryData
    {
        IEnumerable<Product> GetOperationsByProducts(string productName);
        IEnumerable<Product> GetOperationsByProvider(string providerName);
        IEnumerable<Product> GetOperationsByQuantity();
        Product GetById(int id);
        Product AddProduct(Product newProduct);
        Product AddProviderToProduct(Product updatedProductProvider);
        Product UpdateQuantity(Product updatedQuantity);
        Product DeleteProduct(Product deletedProduct);
        int Commit();

    }
}
