using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBookList.Model;

namespace MyBookList.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDBContext _dbContext;

        public CreateModel(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Book Book { get; set; }

        public void OnGet()
        {
        }
    }
}
