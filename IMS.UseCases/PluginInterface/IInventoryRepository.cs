using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.PluginInterface
{
    public interface IInventoryRepository
    {
        Task<Inventory?> GetInventoriesByIdAsync(int inventoryId);
        Task UpdateInventoryAsync(Inventory inventory);
        Task AddInventoryAsync(Inventory inventory);
        Task<IEnumerable<Inventory>> GetInventoriesByName(string name);
    }
}
