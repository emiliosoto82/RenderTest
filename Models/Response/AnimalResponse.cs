using Chaos.Api.Models.Enums;

namespace Chaos.Api.Models.Response
{
    public class AnimalResponse
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public float Price { get; set; }
    }
}
