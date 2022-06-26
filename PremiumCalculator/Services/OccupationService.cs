using PremiumCalculator.Models;
using PremiumCalculator.Models.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                Name="Mechanin",
                RatingId=4
            },
            new Occupation()
            {
                Id=6,
                Name="Florist",
                RatingId=3
            }
        };

        public OccupationService(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }
        public double CalculatePremium(PremiumCalculatorRequestInfo premiumCalulatorRequestInfo)
        {
            double premium = 0;

            var occupation = occupationList.FirstOrDefault(m => m.Id == premiumCalulatorRequestInfo.OccupationId);
            var factor = _ratingService.GetRating(occupation.RatingId);

            premium = (premiumCalulatorRequestInfo.SumInsurred * factor.Factor * premiumCalulatorRequestInfo.Age) / 1000 * 12;

            return premium;
        }

        public List<Occupation> GetOccupations()
        {
            return occupationList;
        }
    }
}
