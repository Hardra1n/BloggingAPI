public static class DataConfiguration
{
    public static void ConfigureData(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<BloggingContext>();
        if (context == null)
            throw new ApplicationException("Unable to find BlogginContext");

        context.Database.EnsureCreated();
        if (context.Blogs.Count() == 0)
        {
            context.Blogs.AddRange([
                new Blog() {
                    BlogId = 1,
                    Title = "How strong people can be",
                    Content = "Depends on problems he is solving",
                    CreatedAt=DateTime.Now.ToUniversalTime()},
                new Blog() {
                    BlogId = 2,
                    Title = "People do love pets",
                    Content = "The most common pets men own are wives.",
                    CreatedAt=DateTime.Now.ToUniversalTime()},
            ]);
            context.SaveChanges();

        }
    }
}