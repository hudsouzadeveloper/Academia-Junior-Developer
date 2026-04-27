using ASP.NETWebApplication2.Src.Application.DTOs;
using ASP.NETWebApplication2.Src.Application.Services;
using ASP.NETWebApplication2.Src.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Reflection.Emit;

namespace ASP.NETWebApplication2.Src.Api.Controllers
{
    [ApiController]
    [Route("api/Calculation[controller]")]
    public class CalculationController : ControllerBase
    {
        private readonly ICalculationService _service;

        public CalculationController(ICalculationService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<CalculationResponseDto> Calculate(CalculationRequestDto request)
        {
            var numbers = new NumberSet(request.A, request.B, request.C, request.D);
            var result = _service.Calculate(numbers);

            var response = new CalculationResponseDto
            {
                Winner = result.WinnerLabel,
                LowestTotal = result.LowestTotal,
                Details = result.Details.Select(d => new DivisionDetailDto
                {
                    Label = d.SourceLabel,
                    Total = d.Total,
                    Results = d.Results
                }).ToList()
            };

            return Ok(response);
        }
    }
}
