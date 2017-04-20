using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayTraderDotNet.Models
{
    public class StockChange
    {
        public string StockID { get; set; }
        public decimal newPrice { get; set; }

    }
}
