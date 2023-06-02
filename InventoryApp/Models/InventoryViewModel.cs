using InventoryApp.Entities;
namespace InventoryApp.Models
{
    public class InventoryViewModel
    {
        public Inventory ActiveInventory { get; set; }
        public List<Inventory>? Inventory { get; set; }

    }
}
