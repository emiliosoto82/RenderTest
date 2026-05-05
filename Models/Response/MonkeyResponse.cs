using Chaos.Api.Models.Enums;

namespace Chaos.Api.Models.Response
{
    // Response model for monkey price calculation
    public class MonkeyResponse : AnimalResponse
    {
        public AnimalEnum AnimalType { get; set; } = AnimalEnum.Monkey  ;

        public string Breed { get; set; } = string.Empty;

    }
}
