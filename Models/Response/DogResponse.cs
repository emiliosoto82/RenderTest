using Chaos.Api.Models.Enums;

namespace Chaos.Api.Models.Response
{
    // Response model for dog price calculation
    public class DogResponse : AnimalResponse
    {
        public AnimalEnum AnimalType { get; set; } = AnimalEnum.Dog;

        public string Breed { get; set; } = string.Empty;

    }
}
