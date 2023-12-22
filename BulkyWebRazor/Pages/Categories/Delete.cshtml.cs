using BulkyWebRazor.Data;
using BulkyWebRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDBContext _db;
		[BindProperty]
		public Category Category { get; set; }
		public DeleteModel(ApplicationDBContext db)
		{
			_db = db;
		}
		public void OnGet(int? id)
        {
			if(id != null & id != 0)
			{
				Category = _db.Categories.Find(id);
			}

        }
		public IActionResult OnPost()
		{
			Category? obj = _db.Categories.Find(Category.Id);
			if (obj == null)
			{
				return NotFound();
			}
			_db.Remove(obj);
			_db.SaveChanges();
			TempData["success"] = "Category deleted successfully";
			return RedirectToPage("Index");
		}
	}
}
