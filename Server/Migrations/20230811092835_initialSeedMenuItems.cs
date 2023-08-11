using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    public partial class initialSeedMenuItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[,]
                {
                    { 1, "Friendly Package", "4 Jumbo Burgers along with 3 Mini Burgers and 7 Wings with White Sauce!", "https://winghutimages.blob.core.windows.net/winghut/friendsPackage.jpg", "Package 1 (Friendly)", 47.990000000000002, "Gathering" },
                    { 2, "One Meal", "Roasted Wings with Garlic Sauce and sprinkled onion leaves", "https://winghutimages.blob.core.windows.net/winghut/normalWings.jpg", "Roasted Wings", 8.9900000000000002, "Top Rated" },
                    { 3, "Party Package", "1 Large Pizza, 10 Cans of soft drinks, 40 Wings, Unlimited Suace, 1 Bowl of Chips, 1 Bowl of PopCorn", "https://winghutimages.blob.core.windows.net/winghut/partyPackage.jpg", "Package 1 (Party)", 82.989999999999995, "Best Seller" },
                    { 4, "Whole Meal", "1 Whole Grilled Chicken with our Special White Sauce", "https://winghutimages.blob.core.windows.net/winghut/wholeChicken.jpg", "Whole Grilled Chicken", 10.69, "" },
                    { 5, "Buckets", "A Bucket (50 pieces) of Chicken Wings with Hot Sauce and White Sauce", "https://winghutimages.blob.core.windows.net/winghut/wingOnBucket.jpg", "Package 1 (Bucket)", 12.99, "Top Rated" },
                    { 6, "Trays", "Tray of Wings specially marinated with lime and our secret sauce!", "https://winghutimages.blob.core.windows.net/winghut/wingTray.jpg", "Package 1 (Tray)", 101.98999999999999, "Top Rated" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
