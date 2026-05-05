using Chaos.Api.Models.Enums;

namespace Chaos.Api.Models.Request

{
    // Request model for dog price calculation
    public class DogRequest : AnimalRequest
    {
        public DogBreed BreedType { get; set; }
    }
}
