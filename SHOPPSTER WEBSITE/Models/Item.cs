using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHOPPSTER_WEBSITE.Models
{
    public class Item
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int ItemId { get; set; }
        public decimal Price { get; set; }
        public string ItemArtUrl { get; set; }
        public Category Category { get; set; }
        public Producer Producer { get; set; }
    }
}