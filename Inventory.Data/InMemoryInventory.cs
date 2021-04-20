using System;
using System.Collections.Generic;
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
            providers = new List<Provider>()
            {
                new Provider { Id = 1, ProviderName = "Ramón García", CompanyName = "Coca Cola", Email = null, Day = DayOfWeek.Monday, Telephone = 1156874532 },
                new Provider { Id = 2, ProviderName = "Santiago Biendonado", CompanyName = "Ivess", Email = "Santiago@ivess.com.ar", Day = DayOfWeek.Monday, Telephone = 1143284832 },
                new Provider { Id = 3, ProviderName = "Fabiana Tubir", CompanyName = "Pepsi Co.", Email = null, Day = DayOfWeek.Thursday, Telephone = 1184624862 },
                new Provider { Id = 4, ProviderName = "Fernando", CompanyName = "Quento", Email = "fernando@quento.com", Day = DayOfWeek.Wednesday, Telephone = 1151272817 },
                new Provider { Id = 5, ProviderName = "Damián Alegre", CompanyName = "Arcor", Email = "DamianAlegre@Arcor.com.ar", Day = DayOfWeek.Tuesday, Telephone = 1170677304 },
                new Provider { Id = 6, ProviderName = "Tiziana Derian", CompanyName = "Nestlé", Email = "TizianaNestle@gmail.com", Day = DayOfWeek.Friday, Telephone = 1143060324 }


            };
            products = new List<Product>()
            {
                new Product{Id=1, Name="Coca Cola 500cc.", Quantity= 100, ProviderId = 1 /*Quiero que en vez de un número, pueda hacer la relación con el Id de la lista*/},
                new Product{Id=2, Name="Sprite 500cc.", Quantity = 40, ProviderId= providers.IndexOf(Provider is providers.Id.1)},
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

    }
}
