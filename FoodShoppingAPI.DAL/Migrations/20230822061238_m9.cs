using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodShoppingAPI.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "StoreOrder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StoreOrder_UserID",
                table: "StoreOrder",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreOrder_User_UserID",
                table: "StoreOrder",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreOrder_User_UserID",
                table: "StoreOrder");

            migrationBuilder.DropIndex(
                name: "IX_StoreOrder_UserID",
                table: "StoreOrder");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "StoreOrder");
        }
    }
}
