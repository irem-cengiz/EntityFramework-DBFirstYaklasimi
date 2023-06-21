using System;
using System.Collections.Generic;

namespace EntityFramework_DBFirstYaklasimiOrnek.Models
{
    public partial class Ogretmenler
    {
        public int OgretmenId { get; set; }
        public string OgretmenAd { get; set; } = null!;
        public string OgretmenSoyAd { get; set; } = null!;
    }
}
