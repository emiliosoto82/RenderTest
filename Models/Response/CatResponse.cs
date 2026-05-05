using Chaos.Api.Models.Enums;

namespace Chaos.Api.Models.Response
{
    // Response model for cat price calculation
    public class CatResponse : AnimalResponse
    {
        public AnimalEnum AnimalType { get; set; } = AnimalEnum.Cat;

        public string Breed { get; set; } = string.Empty;

    }
}
