using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Models
{
    public class Occupation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Rating")]
        public int RatingId { get; set; }
        public Rating Rating { get; set; }
    }
}
