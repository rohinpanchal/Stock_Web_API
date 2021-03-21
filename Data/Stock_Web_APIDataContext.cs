using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stock_Web_API.BusinessLayer;

namespace Stock_Web_API.Models
{
    public class Stock_Web_APIDataContext : DbContext
    {
        public Stock_Web_APIDataContext (DbContextOptions<Stock_Web_APIDataContext> options)
            : base(options)
        {
        }

        public DbSet<Stock_Web_API.BusinessLayer.Stock> Stock { get; set; }
    }
}
