using Chaos.Api.Models.Request;
using Chaos.Api.Models.Response;
using Chaos.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Chaos.Api.Controllers
{
    [ApiController]
    [Route("api/animals")]
    public class AnimalController : ControllerBase
    {
        // Separate services for each animal type, and you would inject them using dependency injection.
        private readonly CalculateAnimalPriceInterface<DogRequest, DogResponse> _dogService;

        // Constructor injection for the dog price calculation service
        public AnimalController(CalculateAnimalPriceInterface<DogRequest, DogResponse> dogService)
        { _dogService = dogService; }

        // Endpoint for calculating dog price
        [HttpPost("dog")]
        public IActionResult CalculateDogPrice(DogRequest request)
        {
            var response = _dogService.CalculateDogPrice(request);
            return Ok(response);
        }

        
    }
}