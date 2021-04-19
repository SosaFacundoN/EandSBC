using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Core;

namespace Inventory.Data
{
    public class InMemoryInventory : IInventoryData
    {
        List<Product> products;

        public InMemoryInventory()
        {
            var provider1 = new Provider { Id = 1, ProviderName = "Ramón García", CompanyName = "Coca Cola", Email = null, Day = DayOfWeek.Monday, Telephone = 1156874532 };
            var provider2 = new Provider { Id = 2, ProviderName = "Santiago Biendonado", CompanyName = "Ivess", Email = "Santiago@ivess.com.ar", Day = DayOfWeek.Monday, Telephone = 1143284832 };
            var provider3 = new Provider { Id = 3, ProviderName = "Fabiana Tubir", CompanyName = "Pepsi Co.", Email = null, Day = DayOfWeek.Thursday, Telephone = 1184624862 };
            var provider4 = new Provider { Id = 4, ProviderName = "Fernando", CompanyName = "Quento", Email = "fernando@quento.com", Day = DayOfWeek.Wednesday, Telephone = 1151272817 };
            var provider5 = new Provider { Id = 5, ProviderName = "Damián Alegre", CompanyName = "Arcor", Email = "DamianAlegre@Arcor.com.ar", Day = DayOfWeek.Tuesday, Telephone = 1170677304 };
            var provider6 = new Provider { Id = 6, ProviderName = "Tiziana Derian", CompanyName = "Nestlé", Email = "TizianaNestle@gmail.com", Day = DayOfWeek.Friday, Telephone = 1143060324 };

            products = new List<Product>()
            {
                new Product{Id=1, Name="Coca Cola 500cc.", Quantity= 100, Contact = provider1},
                new Product{Id=2, Name="Sprite 500cc.", Quantity = 40, Contact= provider1},
                new Product{Id=3 , Name="Coca Cola 1.5L.", Quantity=50 , Contact= provider1},
                new Product{Id=4 , Name="Pepsi 500cc.", Quantity=100 , Contact= provider3 },
                new Product{Id=5 , Name="7Up 500cc.", Quantity= 50, Contact= provider3 },
                new Product{Id=6 , Name="Ivess 2L", Quantity= 40, Contact= provider2},
                new Product{Id=7 , Name="Papas Clásicas 100gr.", Quantity= 30 , Contact= provider4 },
                new Product{Id=8 , Name="Chocolate Block 50gr.", Quantity=32 , Contact= provider5},
                new Product{Id=9 , Name="KitKat", Quantity=18 , Contact= provider6 },
                new Product{Id=10 , Name="Papas Ketchup 100gr.", Quantity=20 , Contact= provider4}
            };
        }

    }
}
