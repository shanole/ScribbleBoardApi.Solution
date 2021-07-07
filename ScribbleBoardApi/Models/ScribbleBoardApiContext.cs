using Microsoft.EntityFrameworkCore;

namespace ScribbleBoardApi.Models
{
  public class ScribbleBoardApiContext : DbContext
  {
    public ScribbleBoardApiContext(DbContextOptions<ScribbleBoardApiContext> options) : base(options)
    {

    }
    public DbSet<Image> Images {get; set;}
  }
}