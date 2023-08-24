using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodShoppingAPI.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_StoreDetail_StoreDetailID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_StoreDetailID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "StoreDetailID",
                table: "Order");

            migrationBuilder.CreateTable(
                name: "StoreOrder",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StoreDetailID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_StoreOrder", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StoreOrder_StoreDetail_StoreDetailID",
                        column: x => x.StoreDetailID,
                        principalTable: "StoreDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoreOrderDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: true),
                    StoreOrderID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_StoreOrderDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StoreOrderDetail_StoreOrder_StoreOrderID",
                        column: x => x.StoreOrderID,
                        principalTable: "StoreOrder",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StoreOrder_StoreDetailID",
                table: "StoreOrder",
                column: "StoreDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_StoreOrderDetail_StoreOrderID",
                table: "StoreOrderDetail",
                column: "StoreOrderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoreOrderDetail");

            migrationBuilder.DropTable(
                name: "StoreOrder");

            migrationBuilder.AddColumn<int>(
                name: "StoreDetailID",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_StoreDetailID",
                table: "Order",
                column: "StoreDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_StoreDetail_StoreDetailID",
                table: "Order",
                column: "StoreDetailID",
                principalTable: "StoreDetail",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
