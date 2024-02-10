using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTableWithCreatedDateNewId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 9, 24, 23, 923, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 9, 24, 23, 923, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 9, 24, 23, 923, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "UpdatedDate", "sqft" },
                values: new object[,]
                {
                    { 6, "", new DateTime(2024, 2, 10, 9, 24, 23, 923, DateTimeKind.Local).AddTicks(4598), "Blah Blag Blah", "", "Royal Villa", 5, 4.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200 },
                    { 7, "", new DateTime(2024, 2, 10, 9, 24, 23, 923, DateTimeKind.Local).AddTicks(4607), "Blah Blag Blah", "", "Royal Villa", 5, 4.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 9, 23, 19, 882, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 9, 23, 19, 882, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 9, 23, 19, 882, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "UpdatedDate", "sqft" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 2, 10, 9, 23, 19, 882, DateTimeKind.Local).AddTicks(9377), "Blah Blag Blah", "", "Royal Villa", 5, 4.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200 },
                    { 2, "", new DateTime(2024, 2, 10, 9, 23, 19, 882, DateTimeKind.Local).AddTicks(9384), "Blah Blag Blah", "", "Royal Villa", 5, 4.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200 }
                });
        }
    }
}
