using TADBIR_KISH_VIRA.Data;
using TADBIR_KISH_VIRA.Models;

namespace TADBIR_KISH_VIRA.Repositories
{
    public class InsuranceRequestRepository : IInsuranceRequestRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public InsuranceRequestRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SaveInsuranceRequest(InsuranceResponse request)
        {
            _dbContext.InsuranceResponses.Add(request);
            _dbContext.SaveChanges();
        }
    }
}
