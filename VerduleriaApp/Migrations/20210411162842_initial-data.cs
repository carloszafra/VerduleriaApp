using Microsoft.EntityFrameworkCore.Migrations;

namespace VerduleriaApp.Migrations
{
    public partial class initialdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Img", "Name", "Price", "Stock", "Type" },
                values: new object[,]
                {
                    { 1, "Tomates Frescos", "https://images.app.goo.gl/2eWj98yqJfpHnH5B7", "Tomates", 100f, 200, "fruta" },
                    { 2, "Fresas ideales para batidos y ensaladas de frutas", "https://images.app.goo.gl/jmrrXLpTCAeRpDCNA", "Fresas", 150f, 250, "fruta" },
                    { 3, "Ideales para jugos", "https://images.app.goo.gl/XwLsj8CW3nyMEQNM9", "Naranjas", 90f, 300, "fruta" },
                    { 4, "Buenas para ensaladas", "https://images.app.goo.gl/QxwFnaTZqapADkdE7", "Cebollas", 100f, 200, "vegetal" },
                    { 5, "Frescas recien traidas del campo", "https://images.app.goo.gl/9ZuU2n4K1treJwU98", "Lechuga", 100f, 200, "vegetal" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
