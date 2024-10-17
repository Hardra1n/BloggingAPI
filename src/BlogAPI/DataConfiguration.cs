using BlogAPI.Data;

public static class DataConfiguration
{
    public static void ConfigureData(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<BloggingContext>();
        if (context == null)
            throw new ApplicationException("Unable to find BlogginContext");

        context.Database.EnsureCreated();
        if (!context.Posts.Any())
        {
            context.Posts.AddRange([
                new Post() {
                    Title = "How strong people can be",
                    Content = "Depends on problems he is solving",
                    CreatedAt=DateTime.Now.ToUniversalTime()},
                new Post() {
                    Title = "People do love pets",
                    Content = "The most common pets men own are wives.",
                    CreatedAt=DateTime.Now.ToUniversalTime()},
            ]);
            context.SaveChanges();

        }
    }
}