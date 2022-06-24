using IMS.CoreBusiness;
using IMS.UseCases.PluginInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Plugins.EFCore
{
    public class InventoryTransactionRepository : IInventoryTransactionRepository
    {
        private readonly IMSContext db;

        public InventoryTransactionRepository(IMSContext db)
        {
            this.db = db;
        }

        public async Task PurchaseAsync(string poNumber, Inventory inventory, int quantity, double price,string doneBy)
        {
            this.db.InventoryTransactions.Add(new InventoryTransaction
            {
                PONumber = poNumber,
                InventoryId = inventory.InventoryId,
                QuantityBefore = inventory.Quantity,
                InventoryType = InventoryTransactionType.PurchaseInventory,
                QuantityAfter = inventory.Quantity + quantity,
                TransctionDate = DateTime.Now,
                DoneBy = doneBy,
                Cost = price * quantity

            });
            await this.db.SaveChangesAsync();
        }
    }
}
