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
                    price = 5000 - (request.Age * 5);
                    break;
                case MonkeyBreed.Howler:
                    price = 5200 - (request.Age * 10);
                    break;
                case MonkeyBreed.Spider:
                    price = 6100 - (request.Age * 7);
                    break;
                case MonkeyBreed.Squirrel:
                    price = 2900 - (request.Age * 6);
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