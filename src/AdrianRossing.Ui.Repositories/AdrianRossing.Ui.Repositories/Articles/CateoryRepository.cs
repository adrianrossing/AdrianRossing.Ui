using AdrianRossing.Ui.Models.Articles;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public class CateoryRepository : DbContext
    {
        public CateoryRepository(DbContextOptions<CateoryRepository> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}