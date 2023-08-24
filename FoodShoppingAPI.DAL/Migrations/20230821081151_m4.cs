using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodShoppingAPI.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedUser = table.Column<int>(type: "int", nullable: false),
                    AddedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<int>(type: "int", nullable: false),
                    UpdatedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodCategoryID = table.Column<int>(type: "int", nullable: false),
                    StoreCategoryID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Category", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Category_FoodCategory_FoodCategoryID",
                        column: x => x.FoodCategoryID,
                        principalTable: "FoodCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Category_StoreCategory_StoreCategoryID",
                        column: x => x.StoreCategoryID,
                        principalTable: "StoreCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_FoodCategoryID",
                table: "Category",
                column: "FoodCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_StoreCategoryID",
                table: "Category",
                column: "StoreCategoryID");
        }
    }
}
