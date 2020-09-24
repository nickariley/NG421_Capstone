using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace capstone.Data.Migrations
{
    public partial class AddedMoviesSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "MovieTitle", "ReleaseDate", "UserId", "Watched" },
                values: new object[] { 1, "Sci-fi/Adventure", "Back to the Future", new DateTime(1985, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "86b6a5a5-2da1-4287-a6d6-478b0a7c6072", true });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "MovieTitle", "ReleaseDate", "UserId", "Watched" },
                values: new object[] { 2, "Comedy/Sci-fi", "Back to the Future Part II", new DateTime(1989, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "86b6a5a5-2da1-4287-a6d6-478b0a7c6072", true });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "MovieTitle", "ReleaseDate", "UserId", "Watched" },
                values: new object[] { 3, "Comedy/Western", "Back to the Future Part III", new DateTime(1990, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "86b6a5a5-2da1-4287-a6d6-478b0a7c6072", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
