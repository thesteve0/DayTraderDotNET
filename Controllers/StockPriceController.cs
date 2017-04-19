
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace DayTraderDotNet.Controllers
{
    [Route("api/[controller]")]
    public class StockPriceController : Controller
    {
        // GET: /<controller>/
        public string Index()
        {
            return "Controller is running";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
