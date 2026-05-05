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
        private readonly CalculateAnimalPriceInterface<CatRequest, CatResponse> _catService;


        // Constructor injection for the dog price calculation service
        public AnimalController(
            CalculateAnimalPriceInterface<DogRequest, DogResponse> dogService,
            CalculateAnimalPriceInterface<CatRequest, CatResponse> catService
        )
        { 
           _dogService = dogService;
           _catService = catService;
        }

        // Endpoint for calculating dog price
        [HttpPost("dog")]
        public IActionResult CalculateDogPrice(DogRequest request)
        {
            var response = _dogService.CalculatePrice(request);
            return Ok(response);
        }

        // Endpoint for calculating cat price
        [HttpPost("cat")]
        public IActionResult CalculateCatPrice(CatRequest request)
        {
            var response = _catService.CalculatePrice(request);
            return Ok(response);
        }

    }
}