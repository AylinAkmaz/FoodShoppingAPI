using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodShoppingAPI.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StoreCategoryID",
                table: "Stores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stores_StoreCategoryID",
                table: "Stores",
                column: "StoreCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_StoreCategory_StoreCategoryID",
                table: "Stores",
                column: "StoreCategoryID",
                principalTable: "StoreCategory",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stores_StoreCategory_StoreCategoryID",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_StoreCategoryID",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "StoreCategoryID",
                table: "Stores");
        }
    }
}
