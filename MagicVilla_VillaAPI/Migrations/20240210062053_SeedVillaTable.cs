using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "UpdatedDate", "sqft" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blah Blag Blah", "", "Royal Villa", 5, 4.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200 },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blah Blag Blah", "", "Royal Villa", 5, 4.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200 },
                    { 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blah Blag Blah", "", "Royal Villa", 5, 4.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200 },
                    { 4, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blah Blag Blah", "", "Royal Villa", 5, 4.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200 },
                    { 5, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blah Blag Blah", "", "Royal Villa", 5, 4.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
