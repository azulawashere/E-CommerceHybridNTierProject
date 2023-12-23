using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class sdgasdg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8aad327b-5ee8-4e1a-bbf7-9032a9761f9b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4db273a4-bf0b-48e5-84e4-307418aef468", new DateTime(2023, 11, 27, 17, 24, 45, 714, DateTimeKind.Local).AddTicks(7142), "AQAAAAIAAYagAAAAELWChuzCWJeyF0HerlXj8mFXn2h+XftlYzQkIMqB/nMJi2pFGKrCa4OqlpoIcCgNzg==", "24fd63b4-093d-430d-9e42-fbfa567c6cb3" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "Description",
                value: "Çünkü kutusu cesurca dolore mutlu olduğu dolor quasi sinema sit.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Music", "Aut laudantium voluptas beğendim ipsum numquam laboriosam alias makinesi dolores." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Movies", "Ut oldular voluptate sayfası ad mi minima batarya sayfası mi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Baby", "Ratione dolayı in aut cesurca numquam fugit umut patlıcan ona." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Games", "Un değirmeni eum camisi inventore ullam göze ea veniam qui." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Tools", "Laboriosam dolore anlamsız ötekinden çobanın cesurca eum voluptatum reprehenderit quis." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Industrial", "Architecto laudantium bilgisayarı qui adipisci aliquid ut dolore değerli accusantium." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Garden", "Reprehenderit sit aut sandalye alias sit dolor architecto ipsum cesurca." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Movies", "Ab iure sed lambadaki perferendis voluptatem nemo orta laudantium dolore." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Industrial", "Ut iusto sıfat voluptatem ona voluptatem çıktılar vel dolorem aut." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Small Granite Bacon", 424.95m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Licensed Cotton Salad", 245.47m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Tasty Frozen Chair", 201.04m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Unbranded Steel Mouse", 505.11m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Handcrafted Frozen Car", 581.27m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Rustic Frozen Cheese", 840.25m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Small Rubber Gloves", 128.73m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Handmade Cotton Car", 464.44m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Rustic Granite Chips", 479.19m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7121f560-de28-4ebe-a47d-47f413877277");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a8464c5-01b2-4052-bb7d-2dc6514b518f", new DateTime(2023, 11, 21, 14, 1, 2, 179, DateTimeKind.Local).AddTicks(1038), "AQAAAAIAAYagAAAAEHRzcNgHr8TUqlKY0VDeetY5HpfbfGbc5WW3YHaofwQu+X8SXHCceKjNFt1tcR0OJQ==", "4d34578f-a422-40a4-801d-45bae6bc6249" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "Description",
                value: "Lambadaki ea anlamsız ki sokaklarda consequatur aut ut quia masanın.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Tools", "Dolor nisi exercitationem voluptas nesciunt corporis beğendim quam lambadaki qui." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Computers", "Dolorem quia sed göze eius kapının aut telefonu türemiş laboriosam." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Electronics", "Batarya çobanın telefonu fugit consequatur dolayı olduğu ut masaya tempora." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Sports", "Minima aut alias adanaya yazın enim ışık iusto ötekinden çünkü." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Industrial", "Sarmal laboriosam eos bilgiyasayarı quaerat et ea iure çakıl laboriosam." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Automotive", "Autem un veritatis çorba autem qui filmini voluptatem sit gülüyorum." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Grocery", "Sevindi sequi nisi veniam oldular quia amet mi blanditiis accusantium." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Shoes", "Labore vitae velit otobüs aliquid aut ea kalemi qui corporis." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Shoes", "Domates voluptatem voluptatem dolorem neque dağılımı mutlu autem aut kulu." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Ergonomic Cotton Keyboard", 901.92m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Generic Fresh Tuna", 651.76m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Fantastic Metal Car", 70.64m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Small Metal Soap", 577.76m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Ergonomic Frozen Bike", 983.14m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Handmade Wooden Pants", 701.35m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Practical Frozen Salad", 359.17m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Fantastic Fresh Mouse", 573.86m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Rustic Soft Pants", 32.07m });
        }
    }
}
