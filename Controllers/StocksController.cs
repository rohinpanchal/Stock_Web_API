using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stock_Web_API.BusinessLayer;
using Stock_Web_API.Models;

namespace Stock_Web_API.Controllers
{
    //API controller to manage the stocks 
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly Stock_Web_APIDataContext _context;

        public StocksController(Stock_Web_APIDataContext context)
        {
            _context = context;
        }

        // GET: api/Stocks
        //Get all stocks  using a linq  query.
        [HttpGet]
        public ActionResult<IEnumerable<Stock>> GetStock()
        {
            return (from stocks in _context.Stock select stocks).ToList();
        }

        // GET: api/Stocks/5
        //Gets a Stock detail.
        [HttpGet("{id}")]
        public ActionResult<Stock> GetStock(int id)
        {
            var stock =  _context.Stock.Find(id);

            if (stock == null)
            {
                return NotFound();
            }

            return stock;
        }

        // PUT: api/Stocks/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //Update the stock.
        [HttpPut("{id}")]
        public IActionResult PutStock(int id, Stock stock)
        {
            if (id != stock.Id)
            {
                return BadRequest();
            }

            _context.Entry(stock).State = EntityState.Modified;

            try
            {
                 _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StockExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Stocks
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //Adds the stock to the database.
        [HttpPost]
        public ActionResult<Stock> PostStock(Stock stock)
        {
            _context.Stock.Add(stock);
            _context.SaveChanges();

            return CreatedAtAction("GetStock", new { id = stock.Id }, stock);
        }

        // DELETE: api/Stocks/5
        //Remove the stock detail from the databse.
        [HttpDelete("{id}")]
        public ActionResult<Stock> DeleteStock(int id)
        {
            var stock = (from stocks in _context.Stock
                         where stocks.Id == id
                         select stocks).FirstOrDefault();
            if (stock == null)
            {
                return NotFound();
            }

            _context.Stock.Remove(stock);
           _context.SaveChanges();

            return stock;
        }

        //Checks the stock exists using a lamda query.
        private bool StockExists(int id)
        {
            return _context.Stock.Any(e => e.Id == id);
        }
    }
}
