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
                    price = 700 - (request.Age * 5);
                    break;
                case RabbitBreed.NetherlandDwarf:
                    price = 400 - (request.Age * 3);
                    break;
                case RabbitBreed.Lionhead:
                    price = 500 - (request.Age * 2);
                    break;
                case RabbitBreed.MiniRex:
                    price = 30 - (request.Age * 1);
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