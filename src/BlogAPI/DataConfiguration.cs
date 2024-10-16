public static class DataConfiguration
{
    public static void ConfigureData(this WebApplication app)
    {
        var repository = app.Services.GetRequiredService<IBlogRepository>();
        Blog[] blogs = [
            new Blog() {
                Title = "How strong people can be",
                Content = "Depends on problems he is solving",
                CreatedAt=DateTime.Now},
            new Blog() {
                Title = "People do love pets",
                Content = "The most common pets men own are wives.",
                CreatedAt=DateTime.Now},
        ];

        foreach (var blog in blogs)
        {
            repository.Add(blog);
        }

    }
}