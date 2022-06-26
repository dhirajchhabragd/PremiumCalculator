using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Factor { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}
