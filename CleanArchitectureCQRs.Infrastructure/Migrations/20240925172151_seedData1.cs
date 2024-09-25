using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CleanArchitectureCQRs.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "image",
                table: "Products",
                newName: "Image");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1b3ae46e-e597-4430-833f-891aff03559a"), "Stationery and office essentials", "Office Supplies" },
                    { new Guid("21f6e64f-3b2a-4831-8799-9de336dc624c"), "Various genres of books", "Books" },
                    { new Guid("4ead4f84-3df2-4d23-8d18-1ec570f59c1a"), "Instruments and music equipment", "Music" },
                    { new Guid("70e380b2-4889-4a25-9be8-17d55e1f79a0"), "Household items", "Home & Kitchen" },
                    { new Guid("7fdd10ab-cbc5-4be0-af6e-944f5b3ddf00"), "Apparel for men and women", "Clothing" },
                    { new Guid("8e63f99a-a27a-4560-a3de-f6a7cfb3e8ec"), "Car parts and accessories", "Automotive" },
                    { new Guid("b2f25d71-1386-4cd6-9d2f-fcd4b8fde1c4"), "Healthcare and beauty products", "Health & Beauty" },
                    { new Guid("cbe5e340-69d2-4080-bfe0-6cc9ecbb9b6d"), "Toys for children of all ages", "Toys" },
                    { new Guid("d196fdf4-b242-4fd7-b0a8-6d321fded772"), "Devices and gadgets", "Electronics" },
                    { new Guid("fc8afc8f-8b2a-4bab-b8ed-3391a982314e"), "Sporting goods and equipment", "Sports" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("00b3bc64-ac40-4dd3-ba6f-11aa7be81a21"), new Guid("21f6e64f-3b2a-4831-8799-9de336dc624c"), "Portable e-book reader", "ebook.jpg", "E-book Reader", 129 },
                    { new Guid("01326155-bd05-4923-9e09-6e2be377b63e"), new Guid("fc8afc8f-8b2a-4bab-b8ed-3391a982314e"), "Lightweight racket", "racket.jpg", "Tennis Racket", 99 },
                    { new Guid("0ade2104-bae6-4305-859c-cfe6659bce22"), new Guid("b2f25d71-1386-4cd6-9d2f-fcd4b8fde1c4"), "Anti-aging cream", "face_cream.jpg", "Face Cream", 35 },
                    { new Guid("13372628-186f-477f-b585-092db4a7b5db"), new Guid("d196fdf4-b242-4fd7-b0a8-6d321fded772"), "Latest model", "smartphone.jpg", "Smartphone", 699 },
                    { new Guid("13b1b3ca-e63b-47fe-958b-60faf7d3c60a"), new Guid("70e380b2-4889-4a25-9be8-17d55e1f79a0"), "High-speed blender", "blender.jpg", "Blender", 85 },
                    { new Guid("20dc7d3e-9c79-44d6-bd57-0f2774077411"), new Guid("70e380b2-4889-4a25-9be8-17d55e1f79a0"), "Automatic coffee machine", "coffee_maker.jpg", "Coffee Maker", 75 },
                    { new Guid("2cf500f0-bca1-43f0-922e-8a4c5ed1cc22"), new Guid("4ead4f84-3df2-4d23-8d18-1ec570f59c1a"), "Digital piano", "piano.jpg", "Piano", 350 },
                    { new Guid("2efe4ed7-5eab-41ad-a8d7-c6e380afe289"), new Guid("b2f25d71-1386-4cd6-9d2f-fcd4b8fde1c4"), "Electric toothbrush", "toothbrush.jpg", "Toothbrush", 45 },
                    { new Guid("2f6e3cf5-1560-4282-8790-90f5d616a8e4"), new Guid("8e63f99a-a27a-4560-a3de-f6a7cfb3e8ec"), "Portable tire inflator", "tire_inflator.jpg", "Tire Inflator", 35 },
                    { new Guid("387f345b-ae4c-47e8-9fd2-99dd53132eb8"), new Guid("7fdd10ab-cbc5-4be0-af6e-944f5b3ddf00"), "Denim jeans", "jeans.jpg", "Jeans", 45 },
                    { new Guid("45255879-6ff4-48a2-9ac0-c26b5cf00255"), new Guid("8e63f99a-a27a-4560-a3de-f6a7cfb3e8ec"), "12V car battery", "car_battery.jpg", "Car Battery", 120 },
                    { new Guid("4b14f67e-713b-4b6c-8d75-81ebe6a6fc96"), new Guid("21f6e64f-3b2a-4831-8799-9de336dc624c"), "Bestselling novel", "book.jpg", "Fiction Book", 20 },
                    { new Guid("672babad-80c2-4060-9328-fa23c4154baa"), new Guid("8e63f99a-a27a-4560-a3de-f6a7cfb3e8ec"), "Leather seat cover", "seat_cover.jpg", "Car Seat Cover", 60 },
                    { new Guid("68b985b5-c3a6-4912-b33d-b3ae0789246a"), new Guid("fc8afc8f-8b2a-4bab-b8ed-3391a982314e"), "Official size basketball", "basketball.jpg", "Basketball", 29 },
                    { new Guid("6990e415-0091-466a-b6a7-ccd6d53daef0"), new Guid("21f6e64f-3b2a-4831-8799-9de336dc624c"), "Self-improvement guide", "self_help.jpg", "Self-help Book", 15 },
                    { new Guid("70408125-f494-452d-b14e-252cd83b0ea4"), new Guid("1b3ae46e-e597-4430-833f-891aff03559a"), "Heavy-duty stapler", "stapler.jpg", "Stapler", 12 },
                    { new Guid("7b203b82-bb8a-4dad-a50a-d7d9f9eebefe"), new Guid("b2f25d71-1386-4cd6-9d2f-fcd4b8fde1c4"), "Herbal shampoo", "shampoo.jpg", "Shampoo", 12 },
                    { new Guid("7b362711-746b-4b38-a4fc-2afe1e375df2"), new Guid("cbe5e340-69d2-4080-bfe0-6cc9ecbb9b6d"), "Remote control car", "toy_car.jpg", "Toy Car", 50 },
                    { new Guid("98d037aa-0a30-415d-9679-b59f26b3059c"), new Guid("cbe5e340-69d2-4080-bfe0-6cc9ecbb9b6d"), "Colorful building blocks", "building_blocks.jpg", "Building Blocks", 40 },
                    { new Guid("9a29bb2f-6f28-42c6-acc7-32c9d3af89a1"), new Guid("d196fdf4-b242-4fd7-b0a8-6d321fded772"), "15-inch display", "laptop.jpg", "Laptop", 999 },
                    { new Guid("a34a919d-d004-41a4-bddf-b58fb59c6506"), new Guid("1b3ae46e-e597-4430-833f-891aff03559a"), "Ergonomic office chair", "desk_chair.jpg", "Desk Chair", 180 },
                    { new Guid("a95e2efa-bb65-4466-a6de-20bfb8f2eda3"), new Guid("7fdd10ab-cbc5-4be0-af6e-944f5b3ddf00"), "Leather jacket", "jacket.jpg", "Jacket", 120 },
                    { new Guid("b1e9caff-3dbc-4971-a2c9-696adce7e39f"), new Guid("1b3ae46e-e597-4430-833f-891aff03559a"), "Laser printer", "printer.jpg", "Printer", 150 },
                    { new Guid("b2bcaba4-f21c-4d82-960c-c9a03dee10b0"), new Guid("70e380b2-4889-4a25-9be8-17d55e1f79a0"), "Comfortable sofa", "couch.jpg", "Couch", 499 },
                    { new Guid("c615a9aa-5893-4196-9c04-11613edd05ca"), new Guid("d196fdf4-b242-4fd7-b0a8-6d321fded772"), "Water-resistant smartwatch", "smartwatch.jpg", "Smartwatch", 199 },
                    { new Guid("c89da56e-9b38-4288-ba2e-36166f866f2f"), new Guid("4ead4f84-3df2-4d23-8d18-1ec570f59c1a"), "Complete drum kit", "drum_set.jpg", "Drum Set", 550 },
                    { new Guid("c9c0a336-c621-42db-a585-ce083740d53f"), new Guid("7fdd10ab-cbc5-4be0-af6e-944f5b3ddf00"), "Cotton T-shirt", "tshirt.jpg", "T-shirt", 15 },
                    { new Guid("ce9bc056-4351-4e29-a5c3-01e9b3c05ab2"), new Guid("4ead4f84-3df2-4d23-8d18-1ec570f59c1a"), "Acoustic guitar", "guitar.jpg", "Guitar", 200 },
                    { new Guid("d5624702-c76c-404f-9403-af521fb38320"), new Guid("cbe5e340-69d2-4080-bfe0-6cc9ecbb9b6d"), "Popular action figure", "action_figure.jpg", "Action Figure", 25 },
                    { new Guid("f0dc8d6f-8614-4dc2-a080-839a43685af2"), new Guid("fc8afc8f-8b2a-4bab-b8ed-3391a982314e"), "High-performance running shoes", "running_shoes.jpg", "Running Shoes", 60 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00b3bc64-ac40-4dd3-ba6f-11aa7be81a21"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01326155-bd05-4923-9e09-6e2be377b63e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ade2104-bae6-4305-859c-cfe6659bce22"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13372628-186f-477f-b585-092db4a7b5db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13b1b3ca-e63b-47fe-958b-60faf7d3c60a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20dc7d3e-9c79-44d6-bd57-0f2774077411"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2cf500f0-bca1-43f0-922e-8a4c5ed1cc22"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2efe4ed7-5eab-41ad-a8d7-c6e380afe289"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f6e3cf5-1560-4282-8790-90f5d616a8e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("387f345b-ae4c-47e8-9fd2-99dd53132eb8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45255879-6ff4-48a2-9ac0-c26b5cf00255"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b14f67e-713b-4b6c-8d75-81ebe6a6fc96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("672babad-80c2-4060-9328-fa23c4154baa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68b985b5-c3a6-4912-b33d-b3ae0789246a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6990e415-0091-466a-b6a7-ccd6d53daef0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70408125-f494-452d-b14e-252cd83b0ea4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b203b82-bb8a-4dad-a50a-d7d9f9eebefe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b362711-746b-4b38-a4fc-2afe1e375df2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98d037aa-0a30-415d-9679-b59f26b3059c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a29bb2f-6f28-42c6-acc7-32c9d3af89a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a34a919d-d004-41a4-bddf-b58fb59c6506"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a95e2efa-bb65-4466-a6de-20bfb8f2eda3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1e9caff-3dbc-4971-a2c9-696adce7e39f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2bcaba4-f21c-4d82-960c-c9a03dee10b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c615a9aa-5893-4196-9c04-11613edd05ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c89da56e-9b38-4288-ba2e-36166f866f2f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9c0a336-c621-42db-a585-ce083740d53f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce9bc056-4351-4e29-a5c3-01e9b3c05ab2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5624702-c76c-404f-9403-af521fb38320"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0dc8d6f-8614-4dc2-a080-839a43685af2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b3ae46e-e597-4430-833f-891aff03559a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("21f6e64f-3b2a-4831-8799-9de336dc624c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4ead4f84-3df2-4d23-8d18-1ec570f59c1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70e380b2-4889-4a25-9be8-17d55e1f79a0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fdd10ab-cbc5-4be0-af6e-944f5b3ddf00"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8e63f99a-a27a-4560-a3de-f6a7cfb3e8ec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2f25d71-1386-4cd6-9d2f-fcd4b8fde1c4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cbe5e340-69d2-4080-bfe0-6cc9ecbb9b6d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d196fdf4-b242-4fd7-b0a8-6d321fded772"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc8afc8f-8b2a-4bab-b8ed-3391a982314e"));

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Products",
                newName: "image");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
