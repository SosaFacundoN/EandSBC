using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Inventory.Core
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Provider Contact { get; set; }

    }
    public partial class Provider
    {
        public int Id { get; set; }
        public string ProviderName { get; set; }
        [Required]
        public int Telephone { get; set; }
        public string Email { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public DayOfWeek Day { get; set; }
    }
}
