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
        public async Task<IActionResult> OnGet(int? id)
        {
            Book = new Book();
            if(id == null)
            {
                //create
                return Page();
            }
            //update
            Book = await _dbContext.Book.FindAsync(id);
            if(Book == null)
                return NotFound();
            return Page();

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Book.Id == 0)
                    await _dbContext.Book.AddAsync(Book);
                else
                    _dbContext.Book.Update(Book);
                await _dbContext.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
