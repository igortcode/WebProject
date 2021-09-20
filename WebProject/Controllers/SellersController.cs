using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Services;

namespace WebProject.Controllers
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
