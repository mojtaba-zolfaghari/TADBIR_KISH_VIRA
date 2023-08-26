using TADBIR_KISH_VIRA.Repositories;

namespace TADBIR_KISH_VIRA.Services
{
    public class InsuranceCalculatorService : IInsuranceCalculatorService
    {
        private readonly ICoverageRateRepository _coverageRateRepository;

        public InsuranceCalculatorService(ICoverageRateRepository coverageRateRepository)
        {
            _coverageRateRepository = coverageRateRepository;
        }

        public decimal CalculatePremium(int coverageType, decimal capital)
        {
            decimal rate = _coverageRateRepository.GetRateForCoverage(coverageType);
            return capital * rate;
        }
    }
}
