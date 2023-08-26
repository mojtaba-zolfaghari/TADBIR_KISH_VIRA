namespace TADBIR_KISH_VIRA.Repositories
{
    public interface ICoverageRateRepository
    {
        decimal GetRateForCoverage(int coverageType);
    }
}
