using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IProduceProductUseCase
    {
        Task ExecuteAsync(string productNumber, Product product, int quantity, string doneBy);
    }
}