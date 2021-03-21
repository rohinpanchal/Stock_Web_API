using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_Web_API.BusinessLayer
{
    //Stock details.
    public class Stock
    {
        //Stock id
        public int Id { get; set; }

        //The name of the company
        public string Company { get; set; }

        //Price of  one stock item
        public decimal Price { get; set; }

        //The total number of stocks in the company.
        public int NumberOfStocks { get; set; }

    }
}
