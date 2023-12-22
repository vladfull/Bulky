using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BulkyWebRazor.Data;
using BulkyWebRazor.Models;

namespace BulkyWebRazor.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        [BindProperty]
        public Category Category { get; set; }
        public CreateModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public void OnGet() 
        {

        }
        public IActionResult OnPost()
        {
            _db.Add(Category);
            _db.SaveChanges();
            TempData["success"] = "Category created successfully";
            return RedirectToPage("Index");
        }
    }
}
