using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShopStockApp.Models
{
    public class Pie
    {
        public int Id { get; set; }

        public string PieName { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool InStock { get; set; }
    }
}
