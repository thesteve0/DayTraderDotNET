
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DayTraderDotNet.Models;
using Microsoft.Extensions.Logging;

namespace DayTraderDotNet.Controllers
{
    [Route("api/[controller]")]
    public class StockPriceController : Controller
    {
        private readonly DayTraderContext _context;
        private readonly ILogger _logger;

        public StockPriceController(DayTraderContext context, ILogger<StockPriceController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: /<controller>/
        public string Index()
        {
            //var holdingslist = context.Holdingejbs.ToList();
            return "Controller is running "; //+ holdingslist.LongCount();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]StockChange Change)
        {

            //return the new price after the change
        }

        [HttpGet("{id}")]
        public JsonResult Get(string id)
        {
            //SELECT sum(q.price*h.QUANTITY) as value FROM tradedb.holdingejb as h, tradedb.quoteejb as q where q.SYMBOL = h.QUOTE_SYMBOL AND h.ACCOUNT_ACCOUNTID = 1  group by h.ACCOUNT_ACCOUNTID;
            Dictionary<string, double> result = new Dictionary<string, double>();
            result.Add(id, 101.09);

            return Json(result);
        }
    }
}
