using Microsoft.EntityFrameworkCore;

namespace MyBookList.Model
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Book> Book { get; set; }
    }
}
