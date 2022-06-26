using PremiumCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Services
{
    public class RatingService : IRatingService
    {
        private List<Rating> ratings = new List<Rating>()
        {
            new Rating()
            {
                Id=1,
                Name="Professional",
                Factor=1
            },
            new Rating()
            {
                Id=2,
                Name="White Collar",
                Factor=1.25
            },
            new Rating()
            {
                Id=3,
                Name="Light Manual",
                Factor=1.50
            },
            new Rating()
            {
                Id=4,
                Name="Heavy Manual",
                Factor=1.75
            }
        };

        public List<Rating> GetRatings()
        {
            return ratings;
        }
    }
}
