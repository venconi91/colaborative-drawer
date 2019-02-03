namespace CollaborativeDrawer.Data
{
  using Microsoft.EntityFrameworkCore;

  public class DrawerContext : DbContext
  {
    public DrawerContext(DbContextOptions<DrawerContext> options)
            : base(options)
    {
    }

    public DbSet<Post> Posts { get; set; }
  }

  public class Post
  {
    public int Id { get; set; }
    public string Title { get; set; }
  }
}
