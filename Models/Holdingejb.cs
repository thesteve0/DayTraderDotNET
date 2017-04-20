using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayTraderDotNet.Models
{
    public class Holdingejb
    {
        public double purchaseprice {get; set;}
        public int holdingID { get; set; }
        public double quantity { get; set; }
        public DateTime purchasedate { get; set; }
        public int account_accountid { get; set; }
        public string quote_symbol { get; set; }

    }
}
