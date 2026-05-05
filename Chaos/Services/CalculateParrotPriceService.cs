using Chaos.Api.Models.Enums;
using Chaos.Api.Models.Request;
using Chaos.Api.Models.Response;
using Chaos.Api.Services.Interfaces;

namespace Chaos.Api.Services
{
    public class CalculateParrotPriceService : CalculateAnimalPriceInterface<ParrotRequest, ParrotResponse>
    {

        public ParrotResponse CalculatePrice(ParrotRequest request)
        {
            float price;
            switch (request.BreedType)
            {
                case ParrotBreed.AfricanGrey:
                    price = 1000 - (request.Age * 50);
                    break;
                case ParrotBreed.Macaw:
                    price = 1200 - (request.Age * 60);
                    break;
                case ParrotBreed.Cockatoo:
                    price = 1100 - (request.Age * 40);
                    break;
                case ParrotBreed.Budgerigar:
                    price = 900 - (request.Age * 30);
                    price = 1000 - (request.Age * 50);
                    break;
      
                default:
                    price = 0;
                    break;
            }
            ;

            return new ParrotResponse
            {
                Name = request.Name,
                Age = request.Age,
                AnimalType = AnimalEnum.Parrot,
                Breed = request.BreedType.ToString(),
                Price = price
            };
        }
    }
}