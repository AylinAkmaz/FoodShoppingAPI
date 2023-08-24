using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodShoppingAPI.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodCategory_FoodDetail_FoodDetailID",
                table: "FoodCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodDetail_Menu_MenuID",
                table: "FoodDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodDetail_Product_ProductID",
                table: "FoodDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitchen_FoodCategory_FoodCategoryID",
                table: "Kitchen");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreCategory_StoreDetail_StoreDetailID",
                table: "StoreCategory");

            migrationBuilder.DropIndex(
                name: "IX_StoreCategory_StoreDetailID",
                table: "StoreCategory");

            migrationBuilder.DropIndex(
                name: "IX_Kitchen_FoodCategoryID",
                table: "Kitchen");

            migrationBuilder.DropIndex(
                name: "IX_FoodDetail_MenuID",
                table: "FoodDetail");

            migrationBuilder.DropColumn(
                name: "StoreDetailID",
                table: "StoreCategory");

            migrationBuilder.DropColumn(
                name: "FoodCategoryID",
                table: "Kitchen");

            migrationBuilder.DropColumn(
                name: "MenuID",
                table: "FoodDetail");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "FoodDetail",
                newName: "FoodCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodDetail_ProductID",
                table: "FoodDetail",
                newName: "IX_FoodDetail_FoodCategoryID");

            migrationBuilder.RenameColumn(
                name: "FoodDetailID",
                table: "FoodCategory",
                newName: "KitchenID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodCategory_FoodDetailID",
                table: "FoodCategory",
                newName: "IX_FoodCategory_KitchenID");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "StoreProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FeaturedImage",
                table: "StoreProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "StoreProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "StoreProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "StoreDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "StoreDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoreCategoryID",
                table: "StoreDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "StoreCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "StoreCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "Store",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "Store",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "Role",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "Role",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FeaturedImage",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FoodDetailID",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "OrderDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "OrderDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FeaturedImage",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FoodDetailID",
                table: "Menu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "Kitchen",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "Kitchen",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "FoodProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FeaturedImage",
                table: "FoodProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "FoodProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "FoodProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "FoodDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "FoodDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "About",
                table: "FoodDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "FoodCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "FoodCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StoreDetail_StoreCategoryID",
                table: "StoreDetail",
                column: "StoreCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_FoodDetailID",
                table: "Product",
                column: "FoodDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_FoodDetailID",
                table: "Menu",
                column: "FoodDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodCategory_Kitchen_KitchenID",
                table: "FoodCategory",
                column: "KitchenID",
                principalTable: "Kitchen",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodDetail_FoodCategory_FoodCategoryID",
                table: "FoodDetail",
                column: "FoodCategoryID",
                principalTable: "FoodCategory",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_FoodDetail_FoodDetailID",
                table: "Menu",
                column: "FoodDetailID",
                principalTable: "FoodDetail",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_FoodDetail_FoodDetailID",
                table: "Product",
                column: "FoodDetailID",
                principalTable: "FoodDetail",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreDetail_StoreCategory_StoreCategoryID",
                table: "StoreDetail",
                column: "StoreCategoryID",
                principalTable: "StoreCategory",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodCategory_Kitchen_KitchenID",
                table: "FoodCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodDetail_FoodCategory_FoodCategoryID",
                table: "FoodDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Menu_FoodDetail_FoodDetailID",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_FoodDetail_FoodDetailID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreDetail_StoreCategory_StoreCategoryID",
                table: "StoreDetail");

            migrationBuilder.DropIndex(
                name: "IX_StoreDetail_StoreCategoryID",
                table: "StoreDetail");

            migrationBuilder.DropIndex(
                name: "IX_Product_FoodDetailID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Menu_FoodDetailID",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "StoreCategoryID",
                table: "StoreDetail");

            migrationBuilder.DropColumn(
                name: "FoodDetailID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "FoodDetailID",
                table: "Menu");

            migrationBuilder.RenameColumn(
                name: "FoodCategoryID",
                table: "FoodDetail",
                newName: "ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodDetail_FoodCategoryID",
                table: "FoodDetail",
                newName: "IX_FoodDetail_ProductID");

            migrationBuilder.RenameColumn(
                name: "KitchenID",
                table: "FoodCategory",
                newName: "FoodDetailID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodCategory_KitchenID",
                table: "FoodCategory",
                newName: "IX_FoodCategory_FoodDetailID");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "StoreProduct",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FeaturedImage",
                table: "StoreProduct",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "StoreProduct",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "StoreProduct",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "StoreDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "StoreDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "StoreCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "StoreCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "StoreDetailID",
                table: "StoreCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "Store",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "Store",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "Role",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "Role",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FeaturedImage",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "OrderDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "OrderDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FeaturedImage",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "Kitchen",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "Kitchen",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "FoodCategoryID",
                table: "Kitchen",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "FoodProduct",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FeaturedImage",
                table: "FoodProduct",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "FoodProduct",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "FoodProduct",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "FoodDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "FoodDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "About",
                table: "FoodDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "MenuID",
                table: "FoodDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "FoodCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "FoodCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIPV4Adress",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AddedIPV4Adress",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_StoreCategory_StoreDetailID",
                table: "StoreCategory",
                column: "StoreDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitchen_FoodCategoryID",
                table: "Kitchen",
                column: "FoodCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodDetail_MenuID",
                table: "FoodDetail",
                column: "MenuID");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodCategory_FoodDetail_FoodDetailID",
                table: "FoodCategory",
                column: "FoodDetailID",
                principalTable: "FoodDetail",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodDetail_Menu_MenuID",
                table: "FoodDetail",
                column: "MenuID",
                principalTable: "Menu",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodDetail_Product_ProductID",
                table: "FoodDetail",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitchen_FoodCategory_FoodCategoryID",
                table: "Kitchen",
                column: "FoodCategoryID",
                principalTable: "FoodCategory",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreCategory_StoreDetail_StoreDetailID",
                table: "StoreCategory",
                column: "StoreDetailID",
                principalTable: "StoreDetail",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
