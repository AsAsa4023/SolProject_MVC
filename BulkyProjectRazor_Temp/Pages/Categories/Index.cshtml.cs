using BulkyProjectRazor_Temp.Data;
using BulkyProjectRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyProjectRazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
	{
		private readonly ApplicationDbContext _db;

		public List<Category> CategoryList { get; set; }

		//constructor

		public IndexModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet()
		{
			CategoryList = _db.Categories.ToList();
		}
	}
}
