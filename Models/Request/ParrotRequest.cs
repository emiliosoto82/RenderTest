using Chaos.Api.Models.Enums;

namespace Chaos.Api.Models.Request

{
    // Request model for parrot price calculation
    public class ParrotRequest : AnimalRequest
    {
        public ParrotBreed BreedType { get; set; }
    }
}
