using DataAcess;
using DataAcess.Entity;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace bandershtat_manga.Controllers
{
    public class MangaController : Controller
    {
        private readonly MangaDbContext _context;

        public MangaController(MangaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var allManga = _context.Mangas.ToList();
            return View(allManga);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.AllGenres = _context.Ganrs.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(Manga manga)
        {
            if (ModelState.IsValid)
            {
                if (manga.files != null && manga.files.Count > 0)
                {
                    foreach (var photo in manga.files)
                    {
                        // Створення унікального імені файлу
                        var fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(photo.FileName);

                        // Шлях до місця зберігання файлів (можна налаштувати в конфігурації)
                        var filePath = Path.Combine("wwwroot/images", fileName);

                        // Збереження файлу на сервері
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await photo.CopyToAsync(fileStream);
                        }

                        // Додавання імені файлу до колекції властивості
                        manga.files.Add(photo);
                        manga.fileName.Add(filePath);
                    }
                }
                _context.Mangas.Add(manga);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manga);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var manga = _context.Mangas.Find(id);

            if (manga == null)
            {
                return NotFound();
            }

            return View(manga);
        }

        [HttpPost]
        public IActionResult Edit(Manga manga)
        {
            if (ModelState.IsValid)
            {
                _context.Mangas.Update(manga);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manga);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var manga = _context.Mangas.Find(id);

            if (manga == null)
            {
                return NotFound();
            }

            return View(manga);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var manga = _context.Mangas.Find(id);

            if (manga != null)
            {
                _context.Mangas.Remove(manga);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}
