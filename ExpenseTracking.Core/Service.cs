using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracking.Core
{
    public partial class Service : Operation
    {
        public bool IsPaid { get; set; }
        public DateTime DueDate { get; set; }

    }
}
