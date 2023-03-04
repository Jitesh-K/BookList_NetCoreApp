using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBookList.Model;
using System.Threading.Tasks;

namespace MyBookList.Pages.Books
{
    public class UpsertModel : PageModel
    {
        private readonly ApplicationDBContext _dbContext;

        public UpsertModel(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [BindProperty]
        public Book Book { get; set; }
        public async Task OnGet(int id)
        {
            Book = await _dbContext.Book.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var bookFromDb = await _dbContext.Book.FindAsync(Book.Id);
                bookFromDb.Name = Book.Name;
                bookFromDb.Author = Book.Author;
                bookFromDb.ISBN = Book.ISBN;
                await _dbContext.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
