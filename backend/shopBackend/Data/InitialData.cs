using shopBackend.Models;
using shopBackend.Models.Enums;

namespace shopBackend.Data
{
    public static class InitialData
    {
        public static List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { Id = 1, Name = "Biscuits" },
                new Category { Id = 2, Name = "Cakes" },
                new Category { Id = 3, Name = "Vegetables" },
                new Category { Id = 4, Name = "Fruits" },
                new Category { Id = 5, Name = "Dairy" },
                new Category { Id = 6, Name = "Beverages" },
                new Category { Id = 7, Name = "Snacks" },
                new Category { Id = 8, Name = "Bakery" },
                new Category { Id = 9, Name = "Meat" },
                new Category { Id = 10, Name = "Seafood" }
            };
        }
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Cookies 'Maria'", Description = "Delicious Ukrainian cookies", Price = 1.50m, StockQuantity = 100, CategoryId = 1, UnitType = UnitTypeEnum.Piece },
                new Product { Id = 2, Name = "Kyiv Cake", Description = "Traditional Kyiv cake", Price = 5.00m, StockQuantity = 50, CategoryId = 2, UnitType = UnitTypeEnum.Piece },
                new Product { Id = 3, Name = "Tomatoes", Description = "Fresh tomatoes", Price = 2.50m, StockQuantity = 200, CategoryId = 3, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 4, Name = "Cucumbers", Description = "Fresh cucumbers", Price = 2.00m, StockQuantity = 150, CategoryId = 3, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 5, Name = "Apples", Description = "Fresh apples", Price = 1.80m, StockQuantity = 250, CategoryId = 4, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 6, Name = "Bananas", Description = "Fresh bananas", Price = 1.50m, StockQuantity = 180, CategoryId = 4, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 7, Name = "Milk", Description = "Fresh milk", Price = 1.00m, StockQuantity = 200, CategoryId = 5, UnitType = UnitTypeEnum.Piece },
                new Product { Id = 8, Name = "Cheese", Description = "Delicious cheese", Price = 8.00m, StockQuantity = 100, CategoryId = 5, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 9, Name = "Orange Juice", Description = "Freshly squeezed orange juice", Price = 3.00m, StockQuantity = 150, CategoryId = 6, UnitType = UnitTypeEnum.Piece },
                new Product { Id = 10, Name = "Coffee", Description = "Premium coffee beans", Price = 10.00m, StockQuantity = 75, CategoryId = 6, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 11, Name = "Chocolate Bar", Description = "Delicious chocolate bar", Price = 2.00m, StockQuantity = 300, CategoryId = 7, UnitType = UnitTypeEnum.Piece },
                new Product { Id = 12, Name = "Croissant", Description = "Freshly baked croissant", Price = 1.50m, StockQuantity = 120, CategoryId = 8, UnitType = UnitTypeEnum.Piece },
                new Product { Id = 13, Name = "Bread", Description = "Fresh bread", Price = 1.20m, StockQuantity = 250, CategoryId = 8, UnitType = UnitTypeEnum.Piece },
                new Product { Id = 14, Name = "Chicken Breast", Description = "Fresh chicken breast", Price = 6.00m, StockQuantity = 100, CategoryId = 9, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 15, Name = "Salmon Fillet", Description = "Fresh salmon fillet", Price = 15.00m, StockQuantity = 80, CategoryId = 10, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 16, Name = "Potatoes", Description = "Fresh potatoes", Price = 1.00m, StockQuantity = 500, CategoryId = 3, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 17, Name = "Carrots", Description = "Fresh carrots", Price = 0.80m, StockQuantity = 400, CategoryId = 3, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 18, Name = "Onions", Description = "Fresh onions", Price = 0.70m, StockQuantity = 350, CategoryId = 3, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 19, Name = "Garlic", Description = "Fresh garlic", Price = 3.00m, StockQuantity = 100, CategoryId = 3, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 20, Name = "Peppers", Description = "Fresh bell peppers", Price = 2.50m, StockQuantity = 200, CategoryId = 3, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 21, Name = "Zucchini", Description = "Fresh zucchini", Price = 1.80m, StockQuantity = 150, CategoryId = 3, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 22, Name = "Strawberries", Description = "Fresh strawberries", Price = 4.00m, StockQuantity = 100, CategoryId = 4, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 23, Name = "Blueberries", Description = "Fresh blueberries", Price = 5.00m, StockQuantity = 80, CategoryId = 4, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 24, Name = "Raspberries", Description = "Fresh raspberries", Price = 5.50m, StockQuantity = 90, CategoryId = 4, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 25, Name = "Pineapple", Description = "Fresh pineapple", Price = 3.50m, StockQuantity = 60, CategoryId = 4, UnitType = UnitTypeEnum.Piece },
                new Product { Id = 26, Name = "Watermelon", Description = "Fresh watermelon", Price = 2.50m, StockQuantity = 70, CategoryId = 4, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 27, Name = "Grapes", Description = "Fresh grapes", Price = 3.00m, StockQuantity = 100, CategoryId = 4, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 28, Name = "Peaches", Description = "Fresh peaches", Price = 2.80m, StockQuantity = 80, CategoryId = 4, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 29, Name = "Plums", Description = "Fresh plums", Price = 2.50m, StockQuantity = 100, CategoryId = 4, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 30, Name = "Cherries", Description = "Fresh cherries", Price = 3.50m, StockQuantity = 70, CategoryId = 4, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 31, Name = "Yogurt", Description = "Fresh yogurt", Price = 0.80m, StockQuantity = 150, CategoryId = 5, UnitType = UnitTypeEnum.Piece },
                new Product { Id = 32, Name = "Butter", Description = "Fresh butter", Price = 2.50m, StockQuantity = 120, CategoryId = 5, UnitType = UnitTypeEnum.Piece },
                new Product { Id = 33, Name = "Cream", Description = "Fresh cream", Price = 1.20m, StockQuantity = 100, CategoryId = 5, UnitType = UnitTypeEnum.Piece },
                new Product { Id = 34, Name = "Lemonade", Description = "Refreshing lemonade", Price = 1.00m, StockQuantity = 200, CategoryId = 6, UnitType = UnitTypeEnum.Piece },
                new Product { Id = 35, Name = "Tea", Description = "Premium tea leaves", Price = 5.00m, StockQuantity = 150, CategoryId = 6, UnitType = UnitTypeEnum.Piece },
                new Product { Id = 36, Name = "Potato Chips", Description = "Crispy potato chips", Price = 1.50m, StockQuantity = 300, CategoryId = 7, UnitType = UnitTypeEnum.Piece },
                new Product { Id = 37, Name = "Pretzels", Description = "Salty pretzels", Price = 1.20m, StockQuantity = 250, CategoryId = 7, UnitType = UnitTypeEnum.Piece },
                new Product { Id = 38, Name = "Donut", Description = "Sweet donut", Price = 1.00m, StockQuantity = 150, CategoryId = 8, UnitType = UnitTypeEnum.Piece },
                new Product { Id = 39, Name = "Bagel", Description = "Fresh bagel", Price = 1.50m, StockQuantity = 200, CategoryId = 8, UnitType = UnitTypeEnum.Piece },
                new Product { Id = 40, Name = "Baguette", Description = "French baguette", Price = 1.80m, StockQuantity = 150, CategoryId = 8, UnitType = UnitTypeEnum.Piece },
                new Product { Id = 41, Name = "Pork Chops", Description = "Fresh pork chops", Price = 5.00m, StockQuantity = 90, CategoryId = 9, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 42, Name = "Beef Steak", Description = "Juicy beef steak", Price = 10.00m, StockQuantity = 70, CategoryId = 9, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 43, Name = "Turkey Breast", Description = "Fresh turkey breast", Price = 7.00m, StockQuantity = 100, CategoryId = 9, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 44, Name = "Shrimps", Description = "Fresh shrimps", Price = 12.00m, StockQuantity = 60, CategoryId = 10, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 45, Name = "Salmon", Description = "Fresh salmon", Price = 15.00m, StockQuantity = 80, CategoryId = 10, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 46, Name = "Mackerel", Description = "Fresh mackerel", Price = 6.00m, StockQuantity = 70, CategoryId = 10, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 47, Name = "Haddock", Description = "Fresh haddock", Price = 8.00m, StockQuantity = 60, CategoryId = 10, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 48, Name = "Oysters", Description = "Fresh oysters", Price = 20.00m, StockQuantity = 50, CategoryId = 10, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 49, Name = "Mussels", Description = "Fresh mussels", Price = 10.00m, StockQuantity = 100, CategoryId = 10, UnitType = UnitTypeEnum.Kilogram },
                new Product { Id = 50, Name = "Scallops", Description = "Fresh scallops", Price = 25.00m, StockQuantity = 40, CategoryId = 10, UnitType = UnitTypeEnum.Kilogram },
            };
        }
    }
};
