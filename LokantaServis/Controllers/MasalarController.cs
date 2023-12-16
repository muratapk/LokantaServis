using DataAccessLayer.Data;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LokantaServis.Controllers
{
    public class MasalarController : Controller
    {
       private readonly ApplicationDbContext _context;

        public MasalarController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var tumu = _context.Masalars.ToList();
            return View(tumu);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Masalar gelen)
        {
            _context.Masalars.Add(gelen);
            _context.SaveChanges();
                      
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Masalar gelen)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Masalar gelen)
        {
            return View();
        }
    }
}
