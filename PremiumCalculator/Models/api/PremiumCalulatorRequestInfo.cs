using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Models.api
{
    public class PremiumCalculatorRequestInfo
    {
        public int Age { get; set; }
        public int SumInsurred { get; set; }
        public int OccupationId { get; set; }
    }
}
