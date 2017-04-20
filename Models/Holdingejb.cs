using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DayTraderDotNet.Models
{
    [Table("HOLDINGEJB")]
    public class Holdingejb
    {
        public decimal purchaseprice {get; set;}
        [Key]
        public int holdingID { get; set; }
        public double quantity { get; set; }
        public DateTime purchasedate { get; set; }
        public int account_accountid { get; set; }
        [Column("quote_symbol")]
        public string Quoteejbsymbol { get; set; }

    }
}
