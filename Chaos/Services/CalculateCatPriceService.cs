using Chaos.Api.Models.Enums;
using Chaos.Api.Models.Request;
using Chaos.Api.Models.Response;
using Chaos.Api.Services.Interfaces;

namespace Chaos.Api.Services
{
    public class CalculateCatPriceService : CalculateAnimalPriceInterface<CatRequest, CatResponse>
    {

        public CatResponse CalculatePrice(CatRequest request)
        {
            float price;
            switch (request.BreedType)
            {
                case CatBreed.MaineCoon:
                    price = 1120 - (request.Age * 40);
                    break;
                case CatBreed.Siamese:
                    price = 1200 - (request.Age * 20);
                    break;
                case CatBreed.Bengal:
                    price = 1100 - (request.Age * 10);
                    break;
                case CatBreed.Sphynx:
                    price = 930 - (request.Age * 40);
                    break;
                case CatBreed.Persian:
                    price = 1250 - (request.Age * 80);
                    break;
                default:
                    price = 0;
                    break;
            }
            ;

            return new CatResponse
            {
                Name = request.Name,
                Age = request.Age,
                AnimalType = AnimalEnum.Cat,
                Breed = request.BreedType.ToString(),
                Price = price
            };
        }
    }
}