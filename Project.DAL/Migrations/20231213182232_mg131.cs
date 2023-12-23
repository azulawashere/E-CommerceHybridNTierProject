using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mg131 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "86285e6a-e254-44ac-9c3f-3ca89999baf2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61a2d57c-9545-408d-b5c3-ecfd01867be2", new DateTime(2023, 12, 13, 21, 22, 31, 885, DateTimeKind.Local).AddTicks(4131), "AQAAAAIAAYagAAAAEHenC6CD7vsjWLk0Z4rT6kV7yawbahzAd20NVZZ5GZ60Gyh8JOelSAH3QpevWQ+hUQ==", "bf1b5b27-ef73-4119-aab6-b3fdaa52eadd" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Beauty", "Sinema gördüm quia teldeki perferendis perferendis quia tempora minima oldular." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Health", "Filmini qui esse doloremque salladı filmini inventore aperiam enim lambadaki." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Kids", "Ona qui gül mi quae odio ad cesurca çakıl sarmal." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Computers", "Masaya reprehenderit et voluptas aspernatur adresini ex odio molestiae ötekinden." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Baby", "Sokaklarda quia doğru gülüyorum okuma aperiam teldeki ea yaptı ve." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Outdoors", "Ratione adipisci çünkü voluptate tempora nihil laboriosam çarpan suscipit çünkü." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Jewelery", "Doloremque nostrum quam bundan modi quasi alias karşıdakine mıknatıslı sayfası." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Electronics", "Açılmadan kalemi mıknatıslı ab qui koştum cesurca ekşili totam bahar." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Grocery", "Suscipit ut koşuyorlar totam ve aut velit consectetur molestiae lakin." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Toys", "Fugit adipisci deleniti ötekinden aliquam vel çorba çarpan architecto sıla." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Handmade Plastic Towels", 216.11m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Tasty Plastic Bacon", 848.59m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Small Wooden Pizza", 19.10m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Sleek Soft Sausages", 324.57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Refined Frozen Cheese", 554.13m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Tasty Granite Bacon", 83.03m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Practical Granite Hat", 432.29m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Handmade Frozen Soap", 430.29m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "ProductName", "UnitPrice" },
                values: new object[] { "Handmade Fresh Keyboard", 898.44m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Baby", "Çünkü kutusu cesurca dolore mutlu olduğu dolor quasi sinema sit." });

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
    }
}
