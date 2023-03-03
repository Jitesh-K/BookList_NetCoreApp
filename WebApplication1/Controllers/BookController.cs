using Microsoft.AspNetCore.Mvc;
using MyBookList.Model;
using System.Linq;

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
        public IActionResult GetAll()
        {
            return Json(new { data = _dbContext.Book.ToList() });
        }
    }
}
