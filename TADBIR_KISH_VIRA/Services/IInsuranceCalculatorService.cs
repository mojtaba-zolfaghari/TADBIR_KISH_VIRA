namespace TADBIR_KISH_VIRA.Services
{
    public interface IInsuranceCalculatorService
    {
        decimal CalculatePremium(int coverageType, decimal capital);
    }
}
