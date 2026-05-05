using Chaos.Api.Models.Enums;

namespace Chaos.Api.Models.Request

{
    // Request model for rabbit price calculation
    public class RabbitRequest : AnimalRequest
    {
        public RabbitBreed BreedType { get; set; }
    }
}
