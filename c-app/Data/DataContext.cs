using c_app.Models;
using Microsoft.EntityFrameworkCore;

namespace c_app.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Value> Values { get; set; }

  }

}
