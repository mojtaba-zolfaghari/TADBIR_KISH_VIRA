using TADBIR_KISH_VIRA.Models;

namespace TADBIR_KISH_VIRA.Repositories
{
    public interface IInsuranceRequestRepository
    {
        void SaveInsuranceRequest(InsuranceResponse request);
    }
}
