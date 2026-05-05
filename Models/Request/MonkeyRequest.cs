using Chaos.Api.Models.Enums;

namespace Chaos.Api.Models.Request

{
    // Request model for monkey price calculation
    public class MonkeyRequest : AnimalRequest
    {
        public MonkeyBreed BreedType { get; set; }
    }
}
