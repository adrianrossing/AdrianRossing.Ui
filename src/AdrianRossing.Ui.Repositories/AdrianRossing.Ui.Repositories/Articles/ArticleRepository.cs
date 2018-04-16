using AdrianRossing.Ui.Models.Articles;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public class ArticleRepository : DbContext
    {
        public ArticleRepository(DbContextOptions<ArticleRepository> options)
            : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
    }
}