using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DayTraderDotNet.Controllers
{
    [Route("api/[controller]")]
    public class PortfolioController : Controller
    {
        // GET api/portfolio
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Does it work", "yes" };
        }

        // GET api/portfolio/values/5
        [HttpGet("values/{id}")]
        public string Get(int id)
        {
            return "value " + id;
        }




    }
}