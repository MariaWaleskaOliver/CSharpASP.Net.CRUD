using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventoryApp.Entities;
using InventoryApp.Models;

namespace InventoryApp.Controllers
{
    public class InventoryController : Controller
    {
        private InventoryDbContext _context;

        public InventoryController(InventoryDbContext context)
        {
            _context = context;
        }
        public IActionResult Items()
        {
            var inventories = _context.Inventories.ToList();
            return View(inventories);
        }
        [HttpGet]
        public IActionResult Add()
        {

            var inventory = _context.Inventories.ToList();

            var inventoryViewModel = new InventoryViewModel()
            {
                ActiveInventory = new Inventory(),
                Inventory = inventory
            };
            return View(inventoryViewModel);
        }
        [HttpPost]
        public IActionResult Add(InventoryViewModel inventoryViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Inventories.Add(inventoryViewModel.ActiveInventory);
                _context.SaveChanges();
                return RedirectToAction("Items", "Inventory");
            }
            else
            {
                return View(inventoryViewModel);
            }            
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var activeInventory = _context.Inventories.Find(id);
            var inventory = _context.Inventories.ToList();

            var inventoryViewModel = new InventoryViewModel()
            {
                ActiveInventory = activeInventory,
                Inventory = inventory
            };
            return View(inventoryViewModel);
        }
        [HttpPost]
        public IActionResult Edit(InventoryViewModel inventoryViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Inventories.Update(inventoryViewModel.ActiveInventory);
                _context.SaveChanges();
                return RedirectToAction("Items", "Inventory");
            }
            else
            {
                return View(inventoryViewModel);
            }

        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var activeInventory = _context.Inventories.Find(id);
            var inventory = _context.Inventories.ToList();

            var inventoryViewModel = new InventoryViewModel()
            {
                ActiveInventory = activeInventory,
                Inventory = inventory
            };
            return View(inventoryViewModel);
        }
    }
}
