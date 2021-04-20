using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Core;

namespace Inventory.Data
{
    public class InMemoryProviderData
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
    }
}
