namespace Chaos.Api.Models.Response
{
    // Response model for dog price calculation
    public class DogResponse : AnimalResponse
    {
        public string Breed { get; set; } = string.Empty;

    }
}
