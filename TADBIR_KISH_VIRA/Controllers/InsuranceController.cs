using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TADBIR_KISH_VIRA.Models;
using TADBIR_KISH_VIRA.Repositories;
using TADBIR_KISH_VIRA.Services;

namespace TADBIR_KISH_VIRA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceController : ControllerBase
    {
        private readonly IInsuranceCalculatorService _insuranceCalculatorService;
        private readonly IInsuranceRequestRepository _insuranceRequestRepository;

        public InsuranceController(IInsuranceCalculatorService insuranceCalculatorService, IInsuranceRequestRepository insuranceRequestRepository)
        {
            _insuranceCalculatorService = insuranceCalculatorService;
            _insuranceRequestRepository = insuranceRequestRepository;
        }

        [HttpPost("Calculate")]
        public ActionResult<decimal> CalculatePremium([FromBody] InsuranceRequest request)
        {
            // Add validation logic here if needed

            decimal premium = _insuranceCalculatorService.CalculatePremium(request.CoverageType, request.Capital);
            InsuranceResponse response = new()
            {
                CalculatedPremium = premium,
                Capital = request.Capital,
                CoverageType = request.CoverageType,
                Title = request.Title,
            };
            _insuranceRequestRepository.SaveInsuranceRequest(response);

            return Ok(premium);
        }
    }
}
