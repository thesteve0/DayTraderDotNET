﻿
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
            var holdingslist = _context.Holdingejbs.ToList();           
            return "Controller is running " + holdingslist.LongCount();
        }

        // 
        [HttpPost]
        public JsonResult Post([FromBody]StockChange Change)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            // expects JSON like this {"StockID": "RTH","newPrice": 220}
            var stock = (from q in _context.Quoteejbs
                         where q.symbol.Equals(Change.StockID) select q).Single();
            decimal oldPrice = stock.price;
            stock.price = Change.newPrice;
            stock.change1 = (double) (Change.newPrice - oldPrice);
            _context.SaveChanges();
            
            result.Add("symbol", Change.StockID);
            result.Add("price", stock.price.ToString());
            return Json(result);
                
            
        }

        [HttpGet("{id}")]
        public JsonResult Get(string id)
        {
            var stockprice = (from q in _context.Quoteejbs
                                where q.symbol.Equals(id)
                                select q.price).Single();
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add("symbol", id);
            result.Add("price",  stockprice.ToString());

            return Json(result);
        }
    }
}