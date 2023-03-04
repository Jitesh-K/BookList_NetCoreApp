using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBookList.Model;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookList.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly ApplicationDBContext _dbContext;

        public BookController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _dbContext.Book.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var book = await _dbContext.Book.FirstOrDefaultAsync(x => x.Id == id);
            if(book != null)
            {
                _dbContext.Book.Remove(book);
                await _dbContext.SaveChangesAsync();
                return Json(new { success = true,message = "Error While Deleting." });
            }
            return Json(new { success = false,message = "Delete Successful." });
        }
    }
}
