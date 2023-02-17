using System;
using System.ComponentModel.DataAnnotations;

namespace Spunges.Models
{
    public class Spunge
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Material { get; set; }


        public string Color { get; set; }
        public string Shape { get; set; }
        public int Rating { get; set; }
        public decimal Price { get; set; }
    }
}