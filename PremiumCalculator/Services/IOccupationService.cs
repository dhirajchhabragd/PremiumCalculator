using PremiumCalculator.Models;
using PremiumCalculator.Models.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Services
{
    public interface IOccupationService
    {
        List<Occupation> GetOccupations();

        double CalculatePremium(PremiumCalculatorRequestInfo premiumCalulatorRequestInfo);
    }
}
