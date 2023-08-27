namespace TADBIR_KISH_VIRA.Models
{
    public class InsuranceResponse:InsuranceRequest
    {
        public int Id { get; set; }
        public decimal CalculatedPremium { get; set; }
    }
}
