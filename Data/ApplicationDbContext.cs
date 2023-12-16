using Gu.Process.Models;
using Microsoft.EntityFrameworkCore;
namespace Gu.Process.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<SubGroup> SubGroups { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Painting> Paintings { get; set; }
    public DbSet<Color> Colors { get; set; }
}