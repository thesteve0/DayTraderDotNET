using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DayTraderDotNet.Models
{
    [Table("QUOTEEJB")]
    public class Quoteejb
    {
        public decimal low { get; set; }       
        public decimal open1 { get; set; }
        public double volume { get; set; }
        public decimal price { get; set; }
        public decimal high { get; set; }
        public double change1 { get; set; }
        public string companyname { get; set; }

        [Key]
        public string symbol { get; set; }

        public ICollection<Holdingejb> Holdings { get; set; }

    }
}
