using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Core;

namespace Inventory.Data
{
    public interface IProviderData
    {
        IEnumerable<Provider> GetProviderByProducts(string product);
        IEnumerable<Provider> GetProviderByName(string name);
        IEnumerable<Provider> GetProviderByCompany(string company);
        Provider GetById(int id);
        Provider AddProvider(Provider newProvider);
        Provider DeleteProduct(Provider deletedProvider);
    }
}
