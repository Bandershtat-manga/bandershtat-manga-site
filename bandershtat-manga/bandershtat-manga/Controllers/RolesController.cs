using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DataAcess.Entity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAcess;
using Microsoft.AspNetCore.Authorization;
using System.Data;

[Authorize(Roles = "Admin")]
public class RolesController : Controller
{
    private readonly RoleManager<Roles> _roleManager;
    private readonly UserManager<User> _userManager;
    private readonly MangaDbContext _context;

    public RolesController(RoleManager<Roles> roleManager, UserManager<User> userManager, MangaDbContext context)
    {
        _roleManager = roleManager;
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

        var roles = _roleManager.Roles.ToList();
        return View(roles);
    }

    public IActionResult Create()
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
    public async Task<IActionResult> Create(Roles role)
    {
        if (ModelState.IsValid)
        {
            var result = await _roleManager.CreateAsync(role);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        return View(role);
    }

    public IActionResult Assign()
    {
        // Отримайте дані з бази даних (наприклад, жанри)
        var genres = _context.Ganrs.ToList();

        // Створіть SelectList
        SelectList genreList = new SelectList(genres, "Id", "Name");

        // Помістіть SelectList в ViewBag
        ViewBag.GenreDropdownList = genreList;

        var users = _userManager.Users.ToList();
        var roles = _roleManager.Roles.ToList();

        ViewBag.Users = users;
        ViewBag.Roles = roles;

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Assign(string userId, string roleId)
    {
        var user = await _userManager.FindByNameAsync(userId);
        var role = await _roleManager.FindByNameAsync(roleId);

        if (user != null && role != null)
        {
            var result = await _userManager.AddToRoleAsync(user, role.Name);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        return View();
    }

    public IActionResult Delete()
    {
        // Отримайте дані з бази даних (наприклад, жанри)
        var genres = _context.Ganrs.ToList();

        // Створіть SelectList
        SelectList genreList = new SelectList(genres, "Id", "Name");

        // Помістіть SelectList в ViewBag
        ViewBag.GenreDropdownList = genreList;

        var roles = _roleManager.Roles.ToList();
        return View(roles);
    }

    [HttpPost]
    public async Task<IActionResult> Delete(string roleId)
    {
        var role = await _roleManager.FindByIdAsync(roleId);

        if (role != null)
        {
            var result = await _roleManager.DeleteAsync(role);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        return View();
    }
}
