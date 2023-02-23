using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyBookList.Model;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyBookList.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _dbContext;

        public IndexModel(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
        {
            Books = await _dbContext.Book.ToListAsync();
        }
    }
}
