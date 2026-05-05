using Chaos.Api.Models.Enums;

namespace Chaos.Api.Models.Request

{
    // Request model for cat price calculation
    public class CatRequest : AnimalRequest
    {
        public CatBreed BreedType { get; set; }
    }
}
