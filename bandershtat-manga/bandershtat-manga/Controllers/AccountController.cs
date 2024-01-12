using bandershtat_manga.Models;
using DataAcess;
using DataAcess.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace bandershtat_manga.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly MangaDbContext _context;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, MangaDbContext mangaDbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = mangaDbContext;
        }

        public IActionResult Register()
        {
            // Отримайте дані з бази даних (наприклад, жанри)
            var genres = _context.Ganrs.ToList();

            // Створіть SelectList
            SelectList genreList = new SelectList(genres, "Id", "Name");

            // Помістіть SelectList в ViewBag
            ViewBag.GenreDropdownList = genreList;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            // Отримайте дані з бази даних (наприклад, жанри)
            var genres = _context.Ganrs.ToList();

            // Створіть SelectList
            SelectList genreList = new SelectList(genres, "Id", "Name");

            // Помістіть SelectList в ViewBag
            ViewBag.GenreDropdownList = genreList;

            if (ModelState.IsValid)
            {
                var user = new User { UserName = model.Name, Email = model.Email };
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    // Збереження в базу даних
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

        public IActionResult Login()
        {
            // Отримайте дані з бази даних (наприклад, жанри)
            var genres = _context.Ganrs.ToList();

            // Створіть SelectList
            SelectList genreList = new SelectList(genres, "Id", "Name");

            // Помістіть SelectList в ViewBag
            ViewBag.GenreDropdownList = genreList;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            // Отримайте дані з бази даних (наприклад, жанри)
            var genres = _context.Ganrs.ToList();

            // Створіть SelectList
            SelectList genreList = new SelectList(genres, "Id", "Name");

            // Помістіть SelectList в ViewBag
            ViewBag.GenreDropdownList = genreList;

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Name, model.Password, model.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }

}
