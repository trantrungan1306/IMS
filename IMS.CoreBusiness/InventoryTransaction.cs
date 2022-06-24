using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.CoreBusiness
{
    public class InventoryTransaction
    {
        public int InventoryTransactionId { get; set; }
        [Required]
        public int InventoryId { get; set; }
        [Required]
        public int QuantityBefore { get; set; }

        // This is the action taken (purchase or product product)
        [Required]
        public InventoryTransactionType InventoryType { get; set; }
        [Required]
        public int QuantityAfter { get; set; }
        public string? PONumber { get; set; }
        public string? ProductionNumber { get; set; }
        public double? Cost { get; set; }
        [Required]
        public DateTime TransctionDate { get; set; }
        [Required]
        public string DoneBy { get; set; }
        //Navigation Properties
        public Inventory Inventory { get; set; }
    }
}
