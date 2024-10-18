using System.Net;
using Microsoft.EntityFrameworkCore;

namespace BlogAPI.Data;

public class BloggingContext : DbContext
{
    public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Post>()
            .Property(p => p.CreatedAt)
            .HasConversion<DateTimeConverter>();
    }

    public DbSet<Post> Posts { get; set; }
}