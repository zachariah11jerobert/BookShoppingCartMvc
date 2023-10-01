using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookShoppingCartMvcUI.Controllers
{
    [Authorize]
    public class CartController1 : Controller
    {
        public IActionResult AddItem(int bookId, int qty=1)
        {
            return View();
        }

        public IActionResult RrmoveItem(int bookId)
        {
            return View();
        }
        public IActionResult GetUserCart()
        {
            return View();
        }
        public IActionResult GetTotalItemInCart()
        {
            return View();
        }
    }
}
