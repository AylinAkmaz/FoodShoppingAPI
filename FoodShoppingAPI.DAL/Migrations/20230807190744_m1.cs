using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodShoppingAPI.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodProduct",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeaturedImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedUser = table.Column<int>(type: "int", nullable: false),
                    AddedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<int>(type: "int", nullable: false),
                    UpdatedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodProduct", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeaturedImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedUser = table.Column<int>(type: "int", nullable: false),
                    AddedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<int>(type: "int", nullable: false),
                    UpdatedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedUser = table.Column<int>(type: "int", nullable: false),
                    AddedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<int>(type: "int", nullable: false),
                    UpdatedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StoreProduct",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    FeaturedImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedUser = table.Column<int>(type: "int", nullable: false),
                    AddedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<int>(type: "int", nullable: false),
                    UpdatedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreProduct", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedUser = table.Column<int>(type: "int", nullable: false),
                    AddedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<int>(type: "int", nullable: false),
                    UpdatedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    FoodProductID = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeaturedImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedUser = table.Column<int>(type: "int", nullable: false),
                    AddedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<int>(type: "int", nullable: false),
                    UpdatedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Menu_FoodProduct_FoodProductID",
                        column: x => x.FoodProductID,
                        principalTable: "FoodProduct",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoreDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StoreProductID = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedUser = table.Column<int>(type: "int", nullable: false),
                    AddedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<int>(type: "int", nullable: false),
                    UpdatedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StoreDetail_StoreProduct_StoreProductID",
                        column: x => x.StoreProductID,
                        principalTable: "StoreProduct",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DeliveryTıme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Openning = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Closing = table.Column<DateTime>(type: "datetime2", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedUser = table.Column<int>(type: "int", nullable: false),
                    AddedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<int>(type: "int", nullable: false),
                    UpdatedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FoodDetail_Menu_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodDetail_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodDetail_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoreCategory",
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
                    AddedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<int>(type: "int", nullable: false),
                    UpdatedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreCategory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StoreCategory_StoreDetail_StoreDetailID",
                        column: x => x.StoreDetailID,
                        principalTable: "StoreDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FoodDetailID = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedUser = table.Column<int>(type: "int", nullable: false),
                    AddedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<int>(type: "int", nullable: false),
                    UpdatedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FoodCategory_FoodDetail_FoodDetailID",
                        column: x => x.FoodDetailID,
                        principalTable: "FoodDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    FoodDetailID = table.Column<int>(type: "int", nullable: false),
                    StoreDetailID = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedUser = table.Column<int>(type: "int", nullable: false),
                    AddedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<int>(type: "int", nullable: false),
                    UpdatedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Order_FoodDetail_FoodDetailID",
                        column: x => x.FoodDetailID,
                        principalTable: "FoodDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_StoreDetail_StoreDetailID",
                        column: x => x.StoreDetailID,
                        principalTable: "StoreDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StoreCategoryID = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedUser = table.Column<int>(type: "int", nullable: false),
                    AddedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<int>(type: "int", nullable: false),
                    UpdatedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Kitchen",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FoodCategoryID = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedUser = table.Column<int>(type: "int", nullable: false),
                    AddedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<int>(type: "int", nullable: false),
                    UpdatedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitchen", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Kitchen_FoodCategory_FoodCategoryID",
                        column: x => x.FoodCategoryID,
                        principalTable: "FoodCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedUser = table.Column<int>(type: "int", nullable: false),
                    AddedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<int>(type: "int", nullable: false),
                    UpdatedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FoodCategoryID = table.Column<int>(type: "int", nullable: false),
                    StoreID = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    AddedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedUser = table.Column<int>(type: "int", nullable: false),
                    AddedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<int>(type: "int", nullable: false),
                    UpdatedIPV4Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                        name: "FK_Category_Store_StoreID",
                        column: x => x.StoreID,
                        principalTable: "Store",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_FoodCategoryID",
                table: "Category",
                column: "FoodCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_StoreID",
                table: "Category",
                column: "StoreID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategory_FoodDetailID",
                table: "FoodCategory",
                column: "FoodDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodDetail_MenuID",
                table: "FoodDetail",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodDetail_ProductID",
                table: "FoodDetail",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodDetail_RoleID",
                table: "FoodDetail",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitchen_FoodCategoryID",
                table: "Kitchen",
                column: "FoodCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_FoodProductID",
                table: "Menu",
                column: "FoodProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_FoodDetailID",
                table: "Order",
                column: "FoodDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StoreDetailID",
                table: "Order",
                column: "StoreDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserID",
                table: "Order",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderID",
                table: "OrderDetail",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Store_StoreCategoryID",
                table: "Store",
                column: "StoreCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_StoreCategory_StoreDetailID",
                table: "StoreCategory",
                column: "StoreDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_StoreDetail_StoreProductID",
                table: "StoreDetail",
                column: "StoreProductID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Kitchen");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "FoodCategory");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "StoreCategory");

            migrationBuilder.DropTable(
                name: "FoodDetail");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "StoreDetail");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "StoreProduct");

            migrationBuilder.DropTable(
                name: "FoodProduct");
        }
    }
}
