using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogAPI.Migrations
{
    /// <inheritdoc />
    public partial class renameBlogModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "Blogs",
                newName: "PostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "Blogs",
                newName: "BlogId");
        }
    }
}
