using Chaos.Api.Models.Enums;
using Chaos.Api.Models.Request;
using Chaos.Api.Models.Response;
using Chaos.Api.Services.Interfaces;

namespace Chaos.Api.Services
{
    public class CalculateMonkeyPriceService : CalculateAnimalPriceInterface<MonkeyRequest, MonkeyResponse>
    {

        public MonkeyResponse CalculatePrice(MonkeyRequest request)
        {
            float price;
            switch(request.BreedType)
            {
                case MonkeyBreed.Capuchin:
                    price = 1000 - (request.Age * 50);
                    break;
                case MonkeyBreed.Howler:
                    price = 1200 - (request.Age * 60);
                    break;
                case MonkeyBreed.Spider:
                    price = 1100 - (request.Age * 40);
                    break;
                case MonkeyBreed.Squirrel:
                    price = 900 - (request.Age * 30);
                    break;
            
                default:
                    price = 0;
                    break;
            };

            return new MonkeyResponse
            {
                Name = request.Name,
                Age = request.Age,
                AnimalType = AnimalEnum.Monkey,
                Breed = request.BreedType.ToString(),
                Price = price
            };
        }
    }
}