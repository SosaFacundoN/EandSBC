using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Inventory.Core;
using Inventory.Data;
using Microsoft.Extensions.Configuration;

namespace ExpenseTracking.Pages.AppPages
{
    public class TestsModel : PageModel
    {
        public TestsModel(IConfiguration config, IInventoryData inventoryData, IProviderData providerData)
        {
            this.config = config;
            this.inventoryData = inventoryData;
            this.providerData = providerData;
        }
        private IConfiguration config;
        private IInventoryData inventoryData;
        private IProviderData providerData;


        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        public IEnumerable<Product> Products { get; set;}
        [BindProperty]
        public Product Product { get; set; }


        public void OnGet()
        {
            Products = inventoryData.GetById(); ;
        }
    }
}
