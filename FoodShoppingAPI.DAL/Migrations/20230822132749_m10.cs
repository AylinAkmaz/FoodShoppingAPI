using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodShoppingAPI.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreDetail_StoreProduct_StoreProductID",
                table: "StoreDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreOrder_StoreDetail_StoreDetailID",
                table: "StoreOrder");

            migrationBuilder.DropIndex(
                name: "IX_StoreDetail_StoreProductID",
                table: "StoreDetail");

            migrationBuilder.DropColumn(
                name: "StoreProductID",
                table: "StoreDetail");

            migrationBuilder.RenameColumn(
                name: "StoreDetailID",
                table: "StoreOrder",
                newName: "StoreProductID");

            migrationBuilder.RenameIndex(
                name: "IX_StoreOrder_StoreDetailID",
                table: "StoreOrder",
                newName: "IX_StoreOrder_StoreProductID");

            migrationBuilder.AddColumn<int>(
                name: "StoreDetailID",
                table: "StoreProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StoreProduct_StoreDetailID",
                table: "StoreProduct",
                column: "StoreDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreOrder_StoreProduct_StoreProductID",
                table: "StoreOrder",
                column: "StoreProductID",
                principalTable: "StoreProduct",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreProduct_StoreDetail_StoreDetailID",
                table: "StoreProduct",
                column: "StoreDetailID",
                principalTable: "StoreDetail",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreOrder_StoreProduct_StoreProductID",
                table: "StoreOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreProduct_StoreDetail_StoreDetailID",
                table: "StoreProduct");

            migrationBuilder.DropIndex(
                name: "IX_StoreProduct_StoreDetailID",
                table: "StoreProduct");

            migrationBuilder.DropColumn(
                name: "StoreDetailID",
                table: "StoreProduct");

            migrationBuilder.RenameColumn(
                name: "StoreProductID",
                table: "StoreOrder",
                newName: "StoreDetailID");

            migrationBuilder.RenameIndex(
                name: "IX_StoreOrder_StoreProductID",
                table: "StoreOrder",
                newName: "IX_StoreOrder_StoreDetailID");

            migrationBuilder.AddColumn<int>(
                name: "StoreProductID",
                table: "StoreDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StoreDetail_StoreProductID",
                table: "StoreDetail",
                column: "StoreProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreDetail_StoreProduct_StoreProductID",
                table: "StoreDetail",
                column: "StoreProductID",
                principalTable: "StoreProduct",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreOrder_StoreDetail_StoreDetailID",
                table: "StoreOrder",
                column: "StoreDetailID",
                principalTable: "StoreDetail",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
