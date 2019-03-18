using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;
using WebMvc.Services;

namespace WebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            return View(_sellerService.FindAll());
        }
    }
}