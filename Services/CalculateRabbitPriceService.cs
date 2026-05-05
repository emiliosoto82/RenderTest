using Chaos.Api.Models.Enums;
using Chaos.Api.Models.Request;
using Chaos.Api.Models.Response;
using Chaos.Api.Services.Interfaces;

namespace Chaos.Api.Services
{
    public class CalculateRabbitPriceService : CalculateAnimalPriceInterface<RabbitRequest, RabbitResponse>
    {

        public RabbitResponse CalculatePrice(RabbitRequest  request)
        {
            float price;
            switch(request.BreedType)
            {
                case RabbitBreed.HollandLop:
                    price = 1000 - (request.Age * 50);
                    break;
                case RabbitBreed.NetherlandDwarf:
                    price = 1200 - (request.Age * 60);
                    break;
                case RabbitBreed.Lionhead:
                    price = 1100 - (request.Age * 40);
                    break;
                case RabbitBreed.MiniRex:
                    price = 900 - (request.Age * 30);
                    break;
               
                default:
                    price = 0;
                    break;
            };

            return new RabbitResponse
            {
                Name = request.Name,
                Age = request.Age,
                AnimalType = AnimalEnum.Rabbit,
                Breed = request.BreedType.ToString(),
                Price = price
            };
        }
    }
}