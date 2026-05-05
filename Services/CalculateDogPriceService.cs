using Chaos.Api.Models.Enums;
using Chaos.Api.Models.Request;
using Chaos.Api.Models.Response;
using Chaos.Api.Services.Interfaces;

namespace Chaos.Api.Services
{
    public class CalculateDogPriceService : CalculateAnimalPriceInterface<DogRequest, DogResponse>
    {

        public DogResponse CalculatePrice(DogRequest request)
        {
            float price;
            switch (request.BreedType)
            {
                case DogBreed.Labrador:
                    price = 1000 - (request.Age * 50);
                    break;
                case DogBreed.Poodle:
                    price = 1200 - (request.Age * 60);
                    break;
                case DogBreed.Boxer:
                    price = 1100 - (request.Age * 40);
                    break;
                case DogBreed.Beagle:
                    price = 900 - (request.Age * 30);
                    break;
                case DogBreed.Bulldog:
                    price = 1200 - (request.Age * 80);
                    break;
                default:
                    price = 0;
                    break;
            }
            ;

            return new DogResponse
            {
                Name = request.Name,
                Age = request.Age,
                AnimalType = AnimalEnum.Dog,
                Breed = request.BreedType.ToString(),
                Price = price
            };
        }
    }
}