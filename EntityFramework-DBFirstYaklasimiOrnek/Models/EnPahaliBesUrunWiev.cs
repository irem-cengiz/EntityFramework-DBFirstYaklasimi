using System;
using System.Collections.Generic;

namespace EntityFramework_DBFirstYaklasimiOrnek.Models
{
    public partial class EnPahaliBesUrunWiev
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
    }
}
