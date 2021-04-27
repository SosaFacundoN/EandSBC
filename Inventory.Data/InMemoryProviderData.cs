using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventory.Core;

namespace Inventory.Data
{
    public class InMemoryProviderData : IProviderData
    {
        List<Provider> providers;
        public InMemoryProviderData()
        {
            providers = new List<Provider>
            {
                new Provider { Id = 1, ProviderName = "Ramón García", CompanyName = "Coca Cola", Email = null, Day = DayOfWeek.Monday, Telephone = 1156874532 },
                new Provider { Id = 2, ProviderName = "Santiago Biendonado", CompanyName = "Ivess", Email = "Santiago@ivess.com.ar", Day = DayOfWeek.Monday, Telephone = 1143284832 },
                new Provider { Id = 3, ProviderName = "Fabiana Tubir", CompanyName = "Pepsi Co.", Email = null, Day = DayOfWeek.Thursday, Telephone = 1184624862 },
                new Provider { Id = 4, ProviderName = "Fernando", CompanyName = "Quento", Email = "fernando@quento.com", Day = DayOfWeek.Wednesday, Telephone = 1151272817 },
                new Provider { Id = 5, ProviderName = "Damián Alegre", CompanyName = "Arcor", Email = "DamianAlegre@Arcor.com.ar", Day = DayOfWeek.Tuesday, Telephone = 1170677304 },
                new Provider { Id = 6, ProviderName = "Tiziana Derian", CompanyName = "Nestlé", Email = "TizianaNestle@gmail.com", Day = DayOfWeek.Friday, Telephone = 1143060324 }
            };
        }

        public Provider AddProvider(Provider newProvider)
        {
            throw new NotImplementedException();
        }

        public Provider DeleteProduct(Provider deletedProvider)
        {
            throw new NotImplementedException();
        }

        public Provider GetById(int id)
        {
            return providers.SingleOrDefault(p => p.Id == id);
        }

        public IEnumerable<Provider> GetProviderByCompany(string company)
        {
            return from p in providers
                   where string.IsNullOrEmpty(company) || p.CompanyName.StartsWith(company)
                   orderby p.CompanyName
                   select p;
        }

        public IEnumerable<Provider> GetProviderByName(string name)
        {
            return from p in providers
                   where string.IsNullOrEmpty(name) || p.ProviderName.StartsWith(name)
                   orderby p.ProviderName
                   select p;
        }

        public IEnumerable<Provider> GetProviderByProducts(string product)
        {
            return from p in providers
                   where string.IsNullOrEmpty(product) || p.ProviderName.StartsWith(product)
                   orderby p.ProviderName
                   select p;
        }
    }
}
