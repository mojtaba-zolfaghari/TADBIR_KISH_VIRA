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
        private readonly ILogger<InsuranceController> _logger;
        private readonly IInsuranceCalculatorService _insuranceCalculatorService;
        private readonly IInsuranceRequestRepository _insuranceRequestRepository;

        public InsuranceController(IInsuranceCalculatorService insuranceCalculatorService, IInsuranceRequestRepository insuranceRequestRepository, ILogger<InsuranceController> logger)
        {
            _insuranceCalculatorService = insuranceCalculatorService;
            _insuranceRequestRepository = insuranceRequestRepository;
            _logger = logger;
        }

        [HttpPost("Calculate")]
        public ActionResult<decimal> CalculatePremium([FromBody] InsuranceRequest request)
        {
            try
            {
                // Add validation logic here if needed
                // Validate input if needed
                if (request.Capital <= 0)
                {
                    return BadRequest("Capital must be a positive value.");
                }
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
            catch (Exception ex)
            {
                // Log the exception
                _logger.LogError(ex, "An error occurred while processing the request.");
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing the request.");
            }
        }
    }
}
