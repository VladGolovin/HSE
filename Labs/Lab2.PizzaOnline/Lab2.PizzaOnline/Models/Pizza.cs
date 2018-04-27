﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2.PizzaOnline.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public decimal Price { get; set; }
    }
}