using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Entities
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        [Required(ErrorMessage = "Please enter the Data!.")]
        public DateTime  DataOfInventory { get; set; } = DateTime.Now; 
        [Required(ErrorMessage = "Please enter the product Content!.")]
        public string ProductContent { get; set; }
        [Required(ErrorMessage = "Please enter the Quantity!.")]
        [Range(1, 40, ErrorMessage = "Quantity must be btween 1 and 40.")]
        public int Quantity { get; set; }
        
    }
}
