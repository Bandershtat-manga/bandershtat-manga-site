using bandershtat_manga.Models;
using DataAcess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace bandershtat_manga.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MangaDbContext _context;

        public HomeController(ILogger<HomeController> logger, MangaDbContext mangaDb)
        {
            _logger = logger;
            _context = mangaDb;
        }

        public IActionResult Index()
        {
            // Отримайте дані з бази даних (наприклад, жанри)
            var genres = _context.Ganrs.ToList();

            // Створіть SelectList
            SelectList genreList = new SelectList(genres, "Id", "Name");

            // Помістіть SelectList в ViewBag
            ViewBag.GenreDropdownList = genreList;

            return View();
        }

        public IActionResult Search(string query)
        {
            // Отримайте дані з бази даних (наприклад, жанри)
            var genres = _context.Ganrs.ToList();

            // Створіть SelectList
            SelectList genreList = new SelectList(genres, "Id", "Name");

            // Помістіть SelectList в ViewBag
            ViewBag.GenreDropdownList = genreList;

            // Приклад: якщо вам потрібно виконати пошук у моделі Manga
            var searchResults = _context.Mangas.Where(m => m.Name.Contains(query)).ToList();

            return View("SearchResults", searchResults);
        }

        public IActionResult Privacy()
        {
            // Отримайте дані з бази даних (наприклад, жанри)
            var genres = _context.Ganrs.ToList();

            // Створіть SelectList
            SelectList genreList = new SelectList(genres, "Id", "Name");

            // Помістіть SelectList в ViewBag
            ViewBag.GenreDropdownList = genreList;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}