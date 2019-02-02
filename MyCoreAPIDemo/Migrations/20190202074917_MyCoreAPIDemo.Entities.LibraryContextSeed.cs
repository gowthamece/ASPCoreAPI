using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCoreAPIDemo.Migrations
{
    public partial class MyCoreAPIDemoEntitiesLibraryContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Author",
                columns: new[] { "AuthorId", "FirstName", "Genre", "LastName" },
                values: new object[] { new Guid("4a2bc798-4c71-4169-84d9-0a0e0d778c95"), "Bob", "Drama", "Ross" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Author",
                columns: new[] { "AuthorId", "FirstName", "Genre", "LastName" },
                values: new object[] { new Guid("0ec75223-99a4-4df8-8da3-847afa4c1b8a"), "David", "Fantasy", "Miller" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("0ec75223-99a4-4df8-8da3-847afa4c1b8a"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: new Guid("4a2bc798-4c71-4169-84d9-0a0e0d778c95"));
        }
    }
}
