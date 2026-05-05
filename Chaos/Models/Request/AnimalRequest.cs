using Chaos.Api.Models.Enums;

namespace Chaos.Api.Models.Request
{
    public abstract class AnimalRequest
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public AnimalEnum AnimalType { get; set; }
    }
}
