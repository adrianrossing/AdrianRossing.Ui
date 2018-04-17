using AdrianRossing.Ui.Models.Articles;
using Microsoft.EntityFrameworkCore;

namespace AdrianRossing.Ui.Repositories
{
    public class ArticleRepository : DbContext
    {
        public ArticleRepository(DbContextOptions<ArticleRepository> options)
            : base(options)
        {
        }

        public DbSet<Article> Article { get; set; }
    }
}