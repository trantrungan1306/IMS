using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IAddInventoryUseCase
    {
        Task ExcuteAsync(Inventory inventory);
    }
}