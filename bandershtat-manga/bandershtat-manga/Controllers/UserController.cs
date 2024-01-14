using bandershtat_manga.Models;
using DataAcess;
using DataAcess.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace bandershtat_manga.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly MangaDbContext _context;

        public UserController(UserManager<User> userManager, MangaDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Index()
        {
            // Отримайте дані з бази даних (наприклад, жанри)
            var genres = _context.Ganrs.ToList();

            // Створіть SelectList
            SelectList genreList = new SelectList(genres, "Id", "Name");

            // Помістіть SelectList в ViewBag
            ViewBag.GenreDropdownList = genreList;

            var users = _userManager.Users.ToList();
            return View(users);
        }
    }
}
