﻿using System;
using System.Collections.Generic;

namespace EntityFramework_DBFirstYaklasimiOrnek.Models
{
    public partial class CurrentProductList
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
    }
}
