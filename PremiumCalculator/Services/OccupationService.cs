using PremiumCalculator.Models;
using System.Collections.Generic;

namespace PremiumCalculator.Services
{
    public class OccupationService : IOccupationService
    {
        private IRatingService _ratingService;
        private List<Occupation> occupationList = new List<Occupation>()
        {
            new Occupation()
            {
                Id=1,
                Name="Cleaner",
                RatingId=3
            },
            new Occupation()
            {
                Id=2,
                Name="Doctor",
                RatingId=1
            },
            new Occupation()
            {
                Id=3,
                Name="Author",
                RatingId=2
            },
            new Occupation()
            {
                Id=4,
                Name="Farmer",
                RatingId=4
            },
            new Occupation()
            {
                Id=5,
                Name="Mechanic",
                RatingId=4
            },
            new Occupation()
            {
                Id=6,
                Name="Florist",
                RatingId=3
            }
        };

        public List<Occupation> GetOccupations()
        {
            return occupationList;
        }
    }
}
