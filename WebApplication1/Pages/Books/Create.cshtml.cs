using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBookList.Model;
using System.Threading.Tasks;

namespace MyBookList.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDBContext _dbContext;

        public CreateModel(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public Book Book { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                await _dbContext.Book.AddAsync(Book);
                await _dbContext.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
