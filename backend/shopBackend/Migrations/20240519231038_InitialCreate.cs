using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace shopBackend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UnitType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderStatusId = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatuses_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Biscuits" },
                    { 2, "Cakes" },
                    { 3, "Vegetables" },
                    { 4, "Fruits" },
                    { 5, "Dairy" },
                    { 6, "Beverages" },
                    { 7, "Snacks" },
                    { 8, "Bakery" },
                    { 9, "Meat" },
                    { 10, "Seafood" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price", "StockQuantity", "UnitType" },
                values: new object[,]
                {
                    { 1, 1, "Delicious Ukrainian cookies", "Cookies 'Maria'", 1.50m, 100, 0 },
                    { 2, 2, "Traditional Kyiv cake", "Kyiv Cake", 5.00m, 50, 0 },
                    { 3, 3, "Fresh tomatoes", "Tomatoes", 2.50m, 200, 1 },
                    { 4, 3, "Fresh cucumbers", "Cucumbers", 2.00m, 150, 1 },
                    { 5, 4, "Fresh apples", "Apples", 1.80m, 250, 1 },
                    { 6, 4, "Fresh bananas", "Bananas", 1.50m, 180, 1 },
                    { 7, 5, "Fresh milk", "Milk", 1.00m, 200, 0 },
                    { 8, 5, "Delicious cheese", "Cheese", 8.00m, 100, 1 },
                    { 9, 6, "Freshly squeezed orange juice", "Orange Juice", 3.00m, 150, 0 },
                    { 10, 6, "Premium coffee beans", "Coffee", 10.00m, 75, 1 },
                    { 11, 7, "Delicious chocolate bar", "Chocolate Bar", 2.00m, 300, 0 },
                    { 12, 8, "Freshly baked croissant", "Croissant", 1.50m, 120, 0 },
                    { 13, 8, "Fresh bread", "Bread", 1.20m, 250, 0 },
                    { 14, 9, "Fresh chicken breast", "Chicken Breast", 6.00m, 100, 1 },
                    { 15, 10, "Fresh salmon fillet", "Salmon Fillet", 15.00m, 80, 1 },
                    { 16, 3, "Fresh potatoes", "Potatoes", 1.00m, 500, 1 },
                    { 17, 3, "Fresh carrots", "Carrots", 0.80m, 400, 1 },
                    { 18, 3, "Fresh onions", "Onions", 0.70m, 350, 1 },
                    { 19, 3, "Fresh garlic", "Garlic", 3.00m, 100, 1 },
                    { 20, 3, "Fresh bell peppers", "Peppers", 2.50m, 200, 1 },
                    { 21, 3, "Fresh zucchini", "Zucchini", 1.80m, 150, 1 },
                    { 22, 4, "Fresh strawberries", "Strawberries", 4.00m, 100, 1 },
                    { 23, 4, "Fresh blueberries", "Blueberries", 5.00m, 80, 1 },
                    { 24, 4, "Fresh raspberries", "Raspberries", 5.50m, 90, 1 },
                    { 25, 4, "Fresh pineapple", "Pineapple", 3.50m, 60, 0 },
                    { 26, 4, "Fresh watermelon", "Watermelon", 2.50m, 70, 1 },
                    { 27, 4, "Fresh grapes", "Grapes", 3.00m, 100, 1 },
                    { 28, 4, "Fresh peaches", "Peaches", 2.80m, 80, 1 },
                    { 29, 4, "Fresh plums", "Plums", 2.50m, 100, 1 },
                    { 30, 4, "Fresh cherries", "Cherries", 3.50m, 70, 1 },
                    { 31, 5, "Fresh yogurt", "Yogurt", 0.80m, 150, 0 },
                    { 32, 5, "Fresh butter", "Butter", 2.50m, 120, 0 },
                    { 33, 5, "Fresh cream", "Cream", 1.20m, 100, 0 },
                    { 34, 6, "Refreshing lemonade", "Lemonade", 1.00m, 200, 0 },
                    { 35, 6, "Premium tea leaves", "Tea", 5.00m, 150, 0 },
                    { 36, 7, "Crispy potato chips", "Potato Chips", 1.50m, 300, 0 },
                    { 37, 7, "Salty pretzels", "Pretzels", 1.20m, 250, 0 },
                    { 38, 8, "Sweet donut", "Donut", 1.00m, 150, 0 },
                    { 39, 8, "Fresh bagel", "Bagel", 1.50m, 200, 0 },
                    { 40, 8, "French baguette", "Baguette", 1.80m, 150, 0 },
                    { 41, 9, "Fresh pork chops", "Pork Chops", 5.00m, 90, 1 },
                    { 42, 9, "Juicy beef steak", "Beef Steak", 10.00m, 70, 1 },
                    { 43, 9, "Fresh turkey breast", "Turkey Breast", 7.00m, 100, 1 },
                    { 44, 10, "Fresh shrimps", "Shrimps", 12.00m, 60, 1 },
                    { 45, 10, "Fresh salmon", "Salmon", 15.00m, 80, 1 },
                    { 46, 10, "Fresh mackerel", "Mackerel", 6.00m, 70, 1 },
                    { 47, 10, "Fresh haddock", "Haddock", 8.00m, 60, 1 },
                    { 48, 10, "Fresh oysters", "Oysters", 20.00m, 50, 1 },
                    { 49, 10, "Fresh mussels", "Mussels", 10.00m, 100, 1 },
                    { 50, 10, "Fresh scallops", "Scallops", 25.00m, 40, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStatusId",
                table: "Orders",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
