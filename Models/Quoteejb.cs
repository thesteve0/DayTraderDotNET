using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DayTraderDotNet.Models
{
    public class Quoteejb
    {
        public double low { get; set; }
        public double open { get; set; }
        public double volume { get; set; }
        public double price { get; set; }
        public double high { get; set; }
        public double change1 { get; set; }
        public string companyname { get; set; }

        [Key]
        public string symbol { get; set; }

        public ICollection<Holdingejb> Holdings { get; set; }

    }
}
