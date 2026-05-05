using Chaos.Api.Models.Enums;

namespace Chaos.Api.Models.Response
{
    // Response model for rabbit price calculation
    public class RabbitResponse : AnimalResponse
    {
        public AnimalEnum AnimalType { get; set; } = AnimalEnum.Rabbit  ;

        public string Breed { get; set; } = string.Empty;

    }
}
