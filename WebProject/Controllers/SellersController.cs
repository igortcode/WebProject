using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Models;
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
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
