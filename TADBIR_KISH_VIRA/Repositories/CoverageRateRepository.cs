using TADBIR_KISH_VIRA.Data;

namespace TADBIR_KISH_VIRA.Repositories
{
    public class CoverageRateRepository : ICoverageRateRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CoverageRateRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public decimal GetRateForCoverage(int coverageType)
        {
            var rate = _dbContext.CoverageRates.SingleOrDefault(r => r.CoverageType == coverageType);

            if (rate == null)
            {
                throw new ArgumentException("Invalid coverage type.");
            }

            return rate.Rate;
        }
    }
}
