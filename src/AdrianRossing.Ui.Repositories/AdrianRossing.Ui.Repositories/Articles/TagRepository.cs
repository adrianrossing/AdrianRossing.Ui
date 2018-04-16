using Microsoft.EntityFrameworkCore;
using AdrianRossing.Ui.Models.Articles;

namespace MvcMovie.Models
{
    public class TagRepository : DbContext
    {
        public TagRepository(DbContextOptions<TagRepository> options)
            : base(options)
        {
        }

        public DbSet<Tag> Tags { get; set; }
    }
}