using IMS.CoreBusiness;
using IMS.UseCases.PluginInterface;

namespace IMS.UseCases
{
    public class ViewInventoriesByNameUseCase : IViewInventoriesByNameUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }
        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await this.inventoryRepository.GetInventoriesByName(name);
        }
    }
}