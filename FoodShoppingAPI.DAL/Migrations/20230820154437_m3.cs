using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodShoppingAPI.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Store_StoreID",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodCategory_Kitchen_KitchenID",
                table: "FoodCategory");

            migrationBuilder.DropTable(
                name: "Kitchen");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropIndex(
                name: "IX_FoodCategory_KitchenID",
                table: "FoodCategory");

            migrationBuilder.DropColumn(
                name: "KitchenID",
                table: "FoodCategory");

            migrationBuilder.RenameColumn(
                name: "StoreID",
                table: "Category",
                newName: "StoreCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Category_StoreID",
                table: "Category",
                newName: "IX_Category_StoreCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_StoreCategory_StoreCategoryID",
                table: "Category",
                column: "StoreCategoryID",
                principalTable: "StoreCategory",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_StoreCategory_StoreCategoryID",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "StoreCategoryID",
                table: "Category",
                newName: "StoreID");

            migrationBuilder.RenameIndex(
                name: "IX_Category_StoreCategoryID",
                table: "Category",
                newName: "IX_Category_StoreID");

            migrationBuilder.AddColumn<int>(
                name: "KitchenID",
                table: "FoodCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Kitchen",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedUser = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitchen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreCategoryID = table.Column<int>(type: "int", nullable: false),
                    AddedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedUser = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Store_StoreCategory_StoreCategoryID",
                        column: x => x.StoreCategoryID,
                        principalTable: "StoreCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategory_KitchenID",
                table: "FoodCategory",
                column: "KitchenID");

            migrationBuilder.CreateIndex(
                name: "IX_Store_StoreCategoryID",
                table: "Store",
                column: "StoreCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Store_StoreID",
                table: "Category",
                column: "StoreID",
                principalTable: "Store",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodCategory_Kitchen_KitchenID",
                table: "FoodCategory",
                column: "KitchenID",
                principalTable: "Kitchen",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
