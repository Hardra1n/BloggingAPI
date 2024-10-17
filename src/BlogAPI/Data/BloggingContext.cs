using System.Net;
using Microsoft.EntityFrameworkCore;

namespace BlogAPI.Data;

public class BloggingContext : DbContext
{
    public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
    {
    }

    public DbSet<Post> Posts { get; set; }
}