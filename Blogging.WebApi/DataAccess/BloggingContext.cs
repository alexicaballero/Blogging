using Blogging.WebApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blogging.WebApi.DataAccess
{
  public class BloggingContext : DbContext
  {
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
  }
}
