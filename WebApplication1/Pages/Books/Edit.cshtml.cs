using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBookList.Model;
using System.Threading.Tasks;

namespace MyBookList.Pages.Books
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDBContext _dbContext;

        public EditModel(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [BindProperty]
        public Book Book { get; set; }
        public async Task OnGet(int id)
        {
            Book = await _dbContext.Book.FindAsync(id);
        }
    }
}
