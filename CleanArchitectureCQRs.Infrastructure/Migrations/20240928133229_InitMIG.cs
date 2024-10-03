using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CleanArchitectureCQRs.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitMIG : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_wishLists_WishListId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_wishLists_users_UsersId",
                table: "wishLists");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_wishLists",
                table: "wishLists");

            migrationBuilder.DropIndex(
                name: "IX_wishLists_UsersId",
                table: "wishLists");

            migrationBuilder.DropIndex(
                name: "IX_products_WishListId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "WishListId",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "wishLists",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "image",
                table: "products",
                newName: "Image");

            migrationBuilder.AddPrimaryKey(
                name: "PK_wishLists",
                table: "wishLists",
                columns: new[] { "ProductId", "UsersId" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { new Guid("04c4ffe2-4d94-487e-b889-0caaebb771e1"), "Office Supplies", "Stationery and office essentials" },
                    { new Guid("16c88735-51ab-4a32-b1fb-36c2ede09b3a"), "Health & Beauty", "Healthcare and beauty products" },
                    { new Guid("2711ad5b-7850-4987-a4d5-a0db63eb6ba9"), "Home & Kitchen", "Household items" },
                    { new Guid("2d71b722-2683-4f22-b76f-47b65215862a"), "Sports", "Sporting goods and equipment" },
                    { new Guid("2dd03caa-bd6e-4cfe-b399-101fe234751a"), "Clothing", "Apparel for men and women" },
                    { new Guid("331663d3-75df-487c-8ef0-00ec96782af2"), "Music", "Instruments and music equipment" },
                    { new Guid("47605a6e-c86f-4280-bc88-819f7761eed7"), "Toys", "Toys for children of all ages" },
                    { new Guid("7b3a315a-8b3c-4ab8-b3e5-17d138a40340"), "Automotive", "Car parts and accessories" },
                    { new Guid("db72e407-4864-4ce0-8115-3eede4e44420"), "Electronics", "Devices and gadgets" },
                    { new Guid("e1fc458c-cbe4-4697-869e-24cad9c40cb4"), "Books", "Various genres of books" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "ProductId", "CategoryId", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("05b2bded-9c50-4c9d-9157-8acdec29e4dd"), new Guid("16c88735-51ab-4a32-b1fb-36c2ede09b3a"), "Herbal shampoo", "shampoo.jpg", "Shampoo", 12 },
                    { new Guid("0a27982e-34db-4c8c-9cd4-17678824da1e"), new Guid("47605a6e-c86f-4280-bc88-819f7761eed7"), "Popular action figure", "action_figure.jpg", "Action Figure", 25 },
                    { new Guid("1c465a17-a117-4ea7-b2a6-bf3e3a8123db"), new Guid("331663d3-75df-487c-8ef0-00ec96782af2"), "Acoustic guitar", "guitar.jpg", "Guitar", 200 },
                    { new Guid("27026ad2-227d-4565-bb9a-a73617ef4aaf"), new Guid("db72e407-4864-4ce0-8115-3eede4e44420"), "Latest model", "smartphone.jpg", "Smartphone", 699 },
                    { new Guid("3018f70e-d15e-4c69-89ae-a3c3dc5c2782"), new Guid("47605a6e-c86f-4280-bc88-819f7761eed7"), "Remote control car", "toy_car.jpg", "Toy Car", 50 },
                    { new Guid("39865d58-f2dc-4b85-93ae-2f9a178a395b"), new Guid("db72e407-4864-4ce0-8115-3eede4e44420"), "Water-resistant smartwatch", "smartwatch.jpg", "Smartwatch", 199 },
                    { new Guid("405e8e1a-07f8-4cc1-9ed8-646e8d893624"), new Guid("2711ad5b-7850-4987-a4d5-a0db63eb6ba9"), "Comfortable sofa", "couch.jpg", "Couch", 499 },
                    { new Guid("4790871f-e5a1-48f8-a3ae-5d9a02ac8878"), new Guid("16c88735-51ab-4a32-b1fb-36c2ede09b3a"), "Electric toothbrush", "toothbrush.jpg", "Toothbrush", 45 },
                    { new Guid("4a94cff0-0b2f-4013-8ea3-2dac82543093"), new Guid("2dd03caa-bd6e-4cfe-b399-101fe234751a"), "Leather jacket", "jacket.jpg", "Jacket", 120 },
                    { new Guid("4f73ae5a-0b04-472c-94aa-13189edf21fc"), new Guid("2711ad5b-7850-4987-a4d5-a0db63eb6ba9"), "High-speed blender", "blender.jpg", "Blender", 85 },
                    { new Guid("52cf97cd-5d44-437e-8714-9f5034f4878e"), new Guid("04c4ffe2-4d94-487e-b889-0caaebb771e1"), "Heavy-duty stapler", "stapler.jpg", "Stapler", 12 },
                    { new Guid("61a12273-71ac-425b-95e4-44f2fc874900"), new Guid("7b3a315a-8b3c-4ab8-b3e5-17d138a40340"), "Leather seat cover", "seat_cover.jpg", "Car Seat Cover", 60 },
                    { new Guid("6bdf8817-e7da-4ce7-b94a-2fec19e4e085"), new Guid("2d71b722-2683-4f22-b76f-47b65215862a"), "High-performance running shoes", "running_shoes.jpg", "Running Shoes", 60 },
                    { new Guid("74ed12b5-11c2-45e8-97fc-14deee57aa7b"), new Guid("7b3a315a-8b3c-4ab8-b3e5-17d138a40340"), "Portable tire inflator", "tire_inflator.jpg", "Tire Inflator", 35 },
                    { new Guid("79a1f31d-1d71-42ea-b40b-56f9d6378246"), new Guid("db72e407-4864-4ce0-8115-3eede4e44420"), "15-inch display", "laptop.jpg", "Laptop", 999 },
                    { new Guid("7df2e22a-d643-463e-bf3b-af3aa0e5b1dc"), new Guid("e1fc458c-cbe4-4697-869e-24cad9c40cb4"), "Portable e-book reader", "ebook.jpg", "E-book Reader", 129 },
                    { new Guid("7ec02090-e500-4115-996b-fa70c656e003"), new Guid("16c88735-51ab-4a32-b1fb-36c2ede09b3a"), "Anti-aging cream", "face_cream.jpg", "Face Cream", 35 },
                    { new Guid("8c17c175-ff51-4ae9-943c-2343f1405b90"), new Guid("2dd03caa-bd6e-4cfe-b399-101fe234751a"), "Denim jeans", "jeans.jpg", "Jeans", 45 },
                    { new Guid("8cb4a577-86c4-4d21-b8fa-51feecb1a080"), new Guid("2711ad5b-7850-4987-a4d5-a0db63eb6ba9"), "Automatic coffee machine", "coffee_maker.jpg", "Coffee Maker", 75 },
                    { new Guid("91c219c3-c300-4fc1-800b-ac1ccc4fa0e9"), new Guid("04c4ffe2-4d94-487e-b889-0caaebb771e1"), "Ergonomic office chair", "desk_chair.jpg", "Desk Chair", 180 },
                    { new Guid("9c916fbb-8b45-4881-82ef-bc474772eaa0"), new Guid("331663d3-75df-487c-8ef0-00ec96782af2"), "Digital piano", "piano.jpg", "Piano", 350 },
                    { new Guid("a74ca1f3-8a60-421d-a685-d7bfec237921"), new Guid("04c4ffe2-4d94-487e-b889-0caaebb771e1"), "Laser printer", "printer.jpg", "Printer", 150 },
                    { new Guid("a8113b83-4a2a-4b8c-9cb1-e5d49b1c783b"), new Guid("331663d3-75df-487c-8ef0-00ec96782af2"), "Complete drum kit", "drum_set.jpg", "Drum Set", 550 },
                    { new Guid("b737837c-e328-435a-8bf1-c002eec9e4c8"), new Guid("47605a6e-c86f-4280-bc88-819f7761eed7"), "Colorful building blocks", "building_blocks.jpg", "Building Blocks", 40 },
                    { new Guid("c87d4738-0453-4021-94b9-8d3a0db61fa1"), new Guid("2dd03caa-bd6e-4cfe-b399-101fe234751a"), "Cotton T-shirt", "tshirt.jpg", "T-shirt", 15 },
                    { new Guid("cc51d424-c008-4334-8e72-a432e12985e8"), new Guid("7b3a315a-8b3c-4ab8-b3e5-17d138a40340"), "12V car battery", "car_battery.jpg", "Car Battery", 120 },
                    { new Guid("dc866dd1-6d16-4870-b4ad-3d7a7a7d0777"), new Guid("e1fc458c-cbe4-4697-869e-24cad9c40cb4"), "Bestselling novel", "book.jpg", "Fiction Book", 20 },
                    { new Guid("e07078a5-0ce1-4f8d-9ab4-c4abfb104e37"), new Guid("2d71b722-2683-4f22-b76f-47b65215862a"), "Lightweight racket", "racket.jpg", "Tennis Racket", 99 },
                    { new Guid("e2958444-5a96-4124-bc5e-53e9cf094f4b"), new Guid("2d71b722-2683-4f22-b76f-47b65215862a"), "Official size basketball", "basketball.jpg", "Basketball", 29 },
                    { new Guid("e6ea9f17-ac41-4ad0-8c86-942831accfad"), new Guid("e1fc458c-cbe4-4697-869e-24cad9c40cb4"), "Self-improvement guide", "self_help.jpg", "Self-help Book", 15 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_wishLists_products_ProductId",
                table: "wishLists",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wishLists_products_ProductId",
                table: "wishLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_wishLists",
                table: "wishLists");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("05b2bded-9c50-4c9d-9157-8acdec29e4dd"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("0a27982e-34db-4c8c-9cd4-17678824da1e"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("1c465a17-a117-4ea7-b2a6-bf3e3a8123db"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("27026ad2-227d-4565-bb9a-a73617ef4aaf"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("3018f70e-d15e-4c69-89ae-a3c3dc5c2782"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("39865d58-f2dc-4b85-93ae-2f9a178a395b"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("405e8e1a-07f8-4cc1-9ed8-646e8d893624"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("4790871f-e5a1-48f8-a3ae-5d9a02ac8878"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("4a94cff0-0b2f-4013-8ea3-2dac82543093"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f73ae5a-0b04-472c-94aa-13189edf21fc"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("52cf97cd-5d44-437e-8714-9f5034f4878e"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("61a12273-71ac-425b-95e4-44f2fc874900"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("6bdf8817-e7da-4ce7-b94a-2fec19e4e085"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("74ed12b5-11c2-45e8-97fc-14deee57aa7b"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("79a1f31d-1d71-42ea-b40b-56f9d6378246"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("7df2e22a-d643-463e-bf3b-af3aa0e5b1dc"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("7ec02090-e500-4115-996b-fa70c656e003"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("8c17c175-ff51-4ae9-943c-2343f1405b90"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("8cb4a577-86c4-4d21-b8fa-51feecb1a080"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("91c219c3-c300-4fc1-800b-ac1ccc4fa0e9"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("9c916fbb-8b45-4881-82ef-bc474772eaa0"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("a74ca1f3-8a60-421d-a685-d7bfec237921"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("a8113b83-4a2a-4b8c-9cb1-e5d49b1c783b"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("b737837c-e328-435a-8bf1-c002eec9e4c8"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("c87d4738-0453-4021-94b9-8d3a0db61fa1"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("cc51d424-c008-4334-8e72-a432e12985e8"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("dc866dd1-6d16-4870-b4ad-3d7a7a7d0777"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("e07078a5-0ce1-4f8d-9ab4-c4abfb104e37"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("e2958444-5a96-4124-bc5e-53e9cf094f4b"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: new Guid("e6ea9f17-ac41-4ad0-8c86-942831accfad"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("04c4ffe2-4d94-487e-b889-0caaebb771e1"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("16c88735-51ab-4a32-b1fb-36c2ede09b3a"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2711ad5b-7850-4987-a4d5-a0db63eb6ba9"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2d71b722-2683-4f22-b76f-47b65215862a"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2dd03caa-bd6e-4cfe-b399-101fe234751a"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("331663d3-75df-487c-8ef0-00ec96782af2"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("47605a6e-c86f-4280-bc88-819f7761eed7"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7b3a315a-8b3c-4ab8-b3e5-17d138a40340"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("db72e407-4864-4ce0-8115-3eede4e44420"));

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e1fc458c-cbe4-4697-869e-24cad9c40cb4"));

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "wishLists",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "products",
                newName: "image");

            migrationBuilder.AddColumn<Guid>(
                name: "WishListId",
                table: "products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_wishLists",
                table: "wishLists",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UsersId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_wishLists_UsersId",
                table: "wishLists",
                column: "UsersId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_WishListId",
                table: "products",
                column: "WishListId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_wishLists_WishListId",
                table: "products",
                column: "WishListId",
                principalTable: "wishLists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_wishLists_users_UsersId",
                table: "wishLists",
                column: "UsersId",
                principalTable: "users",
                principalColumn: "UsersId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
