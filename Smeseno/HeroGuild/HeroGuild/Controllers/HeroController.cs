using HeroGuild.DTO;
using HeroGuild.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HeroGuild.Controllers
{
    public class HeroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(HeroDTO_in dto)
        {
            var hero = new Hero(dto.Name, dto.Fraction);
            DB.Heroes.Add(hero);
            return View();
        }
    }
}
