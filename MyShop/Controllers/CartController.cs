using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Controllers
{
    public class CartController : Controller
    {
        private readonly ShopContext _context;

        public CartController(ShopContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddToCart(int id, int quantity)
        {
            var bicycle = _context.Bicycles.Find(id);
            if (bicycle != null && bicycle.Stock >= quantity)
            {
                // Ajouter l'article au panier
                // Logique d'ajout au panier ici
            }
            else
            {
                TempData["ErrorMessage"] = "Insufficient stock for the selected quantity.";
            }
            return RedirectToAction("Index", "Cart");
        }
    }

}
