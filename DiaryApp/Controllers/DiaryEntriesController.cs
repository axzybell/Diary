using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            //Dependency Injection (DI)
            //use db directly without defining it or injecting it, it would cause an error like:
            //The name 'db' does not exist in the current context
            _db = db;
        }

        public IActionResult Index()
        {
            List<DiaryEntry> entries = _db.DiaryEntries.ToList();
            return View(entries);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length < 3) {
                ModelState.AddModelError("Title", "Title too short");
            }
            
            if (obj != null && obj.Content.Length < 10) {
                ModelState.AddModelError("Content", "Content is too short");
            }
            
            if (obj != null && obj.Content.Length > 500) {
                ModelState.AddModelError("Content", "Content is too Long");
            }

            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Add(obj); //Adds the new diary entry to the database
                _db.SaveChanges(); //Saves the changes to the database
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) { 
                return NotFound();
            }

            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);

            if (diaryEntry == null) {
                return NotFound();
            }

            return View(diaryEntry);
        }
    }
}
