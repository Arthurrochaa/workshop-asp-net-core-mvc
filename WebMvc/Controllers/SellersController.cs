using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly WebMvcContext _context;

        public SellersController(WebMvcContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}