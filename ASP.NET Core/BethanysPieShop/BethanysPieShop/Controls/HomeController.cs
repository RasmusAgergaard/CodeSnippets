using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controls
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        //Note: This is using constuctor injection. A MockPieRepository is automatic added as the parameter
        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel
            {
                Title = "Welcome to my Pie-Shop",
                Pies = pies.ToList()
            };

            return View(homeViewModel);
        }
    }
}
