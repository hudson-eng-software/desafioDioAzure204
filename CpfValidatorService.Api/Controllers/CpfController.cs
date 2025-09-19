using Microsoft.AspNetCore.Mvc;
using CpfValidatorService.Core.Services;

namespace CpfValidatorService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CpfController : ControllerBase
    {
        private readonly CpfValidationService _cpfService;

        public CpfController()
        {
            _cpfService = new CpfValidationService();
        }

        [HttpGet("validate-cpf")]
        public IActionResult ValidateCpf([FromQuery] string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
                return BadRequest("CPF não informado.");

            bool isValid = _cpfService.IsValid(cpf);
            return Ok(new { cpf, isValid });
        }
    }
}
