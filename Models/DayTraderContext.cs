using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayTraderDotNet.Models
{
    public class DayTraderContext :DbContext
    {
        private readonly ILogger _logger;
        public DayTraderContext(DbContextOptions<DayTraderContext> options, ILogger<DayTraderContext> logger) : base(options)
        {
            _logger = logger;
        }

        public DbSet<Quoteejb> Quoteejbs { get; set; }
        public DbSet<Holdingejb> Holdingejbs { get; set; }
    }
}
