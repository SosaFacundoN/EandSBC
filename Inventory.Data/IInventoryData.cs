using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Core;

namespace Inventory.Data
{
    public interface IInventoryData
    {
        IEnumerable<Product> GetOperationsByProducts(string product);
        IEnumerable<Product> GetOperationsByProvider(string provider);
        IEnumerable<Product> GetOperationsByQuantity();
        Product GetById(int id);
        Product AddProduct(Product newProduct);
        Product AddProvider(Product newProvider);
        Product UpdateQuantity(int quantity);
        Product DeleteProduct(Product deletedProduct);

    }
}
