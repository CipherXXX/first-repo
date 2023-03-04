using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Series
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Rating { get; set; }
        public DateTime Release { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Country { get; set; }
        public TimeSpan Duration { get; set; }
        public string Season { get; set; }
        public string Episode { get; set; }
    }
}
