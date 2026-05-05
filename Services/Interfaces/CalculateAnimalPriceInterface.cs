using Chaos.Api.Models.Request;
using Chaos.Api.Models.Response;

namespace Chaos.Api.Services.Interfaces
{
    public interface CalculateAnimalPriceInterface<TRequest, TResponse> 
        where TRequest : AnimalRequest 
        where TResponse : AnimalResponse
    {
            TResponse CalculatePrice(TRequest request);
    }
}
