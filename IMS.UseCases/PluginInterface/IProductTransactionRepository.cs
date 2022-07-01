using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.PluginInterface
{
    public interface IProductTransactionRepository
    {
        Task ProduceAsync(string productNumber, Product product, int quantity, double price, string doneBy);
        Task SellProductAsync(string saleOrderNumber, Product product, int quantity, double price, string doneBy);
    }
}
