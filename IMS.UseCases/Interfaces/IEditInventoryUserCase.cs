using IMS.CoreBusiness;

namespace IMS.UseCases
{
    public interface IEditInventoryUserCase
    {
        Task ExcuteAsync(Inventory inventory);
    }
}