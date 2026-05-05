using Chaos.Api.Models.Enums;

namespace Chaos.Api.Models.Response
{
    // Response model for parrot price calculation
    public class ParrotResponse : AnimalResponse
    {
        public AnimalEnum AnimalType { get; set; } = AnimalEnum.Parrot  ;

        public string Breed { get; set; } = string.Empty;

    }
}
