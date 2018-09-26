using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakeShop.Models;
using CakeShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CakeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;

        public HomeController(ICakeRepository cakeRepository)
        {
            _cakeRepository = cakeRepository;
        }

        public IActionResult Index()
        {


            var cakes = _cakeRepository.GetAllCakes().OrderBy(c => c.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Our Cake Shop",
                Cakes = cakes.ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var cake = _cakeRepository.GetCakeById(id);
            if (cake == null)
                return NotFound();

            return View(cake);
        }

    }
}