using System;
using System.ComponentModel.DataAnnotations;

namespace Soaps.Models
{
    public class Soap
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Fragrance { get; set; }
        public string Forms { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
    }
}