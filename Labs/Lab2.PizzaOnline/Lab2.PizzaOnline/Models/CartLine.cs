using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2.PizzaOnline.Models
{
    public class CartLine
    {
        public Pizza Product { get; set; }
        public int Quantity { get; set; }
    }
}