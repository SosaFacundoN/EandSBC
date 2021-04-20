using System;
using System.ComponentModel.DataAnnotations;


namespace Inventory.Core
{
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
