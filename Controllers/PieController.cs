
using Microsoft.AspNetCore.Mvc;

using Staj1.Models.Abstract;
using Staj1.Models.Concrete;
using System.Diagnostics;

namespace Staj1.Controllers
{
    public class PieController:Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            ViewBag.CurrentCategory = "Cheese cakes";
            return View(_pieRepository.AllPies);
        }

        

    }
}
