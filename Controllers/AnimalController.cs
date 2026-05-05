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
        private readonly CalculateAnimalPriceInterface<MonkeyRequest, MonkeyResponse> _monkeyService;
        private readonly CalculateAnimalPriceInterface<RabbitRequest, RabbitResponse> _rabbitService;
        private readonly CalculateAnimalPriceInterface<ParrotRequest, ParrotResponse> _parrotService;

        // Constructor injection for the dog price calculation service
        public AnimalController(
            CalculateAnimalPriceInterface<DogRequest, DogResponse> dogService,
            CalculateAnimalPriceInterface<CatRequest, CatResponse> catService,
            CalculateAnimalPriceInterface<MonkeyRequest, MonkeyResponse> monkeyService,
            CalculateAnimalPriceInterface<RabbitRequest, RabbitResponse> rabbitService,
             CalculateAnimalPriceInterface<ParrotRequest, ParrotResponse> parrotService

        )
        {
            _dogService = dogService;
            _catService = catService;
            _monkeyService = monkeyService;
            _rabbitService = rabbitService;
            _parrotService = parrotService;
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

        // Endpoint for calculating monkey price
        [HttpPost("monkey")]
        public IActionResult CalculateMonkeyPrice(MonkeyRequest request)
        {
            var response = _monkeyService.CalculatePrice(request);
            return Ok(response);

        }
        [HttpPost("rabbit")]
        public IActionResult CalculateRabbitPrice(RabbitRequest request)
        {
            var response = _rabbitService.CalculatePrice(request);
            return Ok(response);
        }
        [HttpPost("parrot")]
        public IActionResult CalculateParrotPrice(ParrotRequest request)
        {
            var response = _parrotService.CalculatePrice(request);
            return Ok(response);
        } 
    }
}