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
    public class PortfolioController : Controller
    {
        private readonly DayTraderContext _context;
        private readonly ILogger _logger;

        public PortfolioController(DayTraderContext context, ILogger<StockPriceController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET api/portfolio
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Does it work", "yes" };
        }

        // GET api/portfolio/values/5
        [HttpGet("values/{id}")]
        public JsonResult Get(int id)
        {
              
            var holdingslist = (from h in _context.Holdingejbs
                                join q in _context.Quoteejbs on h.Quoteejbsymbol equals q.symbol
                                where h.account_accountid == id
                                select (q.price * Convert.ToDecimal(h.quantity))).ToList();
            decimal amount = 0.0M;

           for (int i = 0; i < holdingslist.Count; i++)
            {
                amount += holdingslist[i];
            }


            Dictionary<string, decimal> result = new Dictionary<string, decimal>();
            result.Add("value", amount);

            return Json(result);
        }




    }
}