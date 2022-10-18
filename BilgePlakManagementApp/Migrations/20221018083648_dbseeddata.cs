using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BilgePlakManagementApp.Migrations
{
    public partial class dbseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RecordDate",
                table: "Artists",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(1912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Artists",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(1750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Artists",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Albums",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RecordDate",
                table: "Albums",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Albums",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "ArtistName", "ModifiedDate", "RecordDate" },
                values: new object[,]
                {
                    { 1, "Barış Manço", new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2056), new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2055) },
                    { 2, "Cem Karaca", new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2058), new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2058) }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "ModifiedDate", "RecordDate" },
                values: new object[] { 1, "Plak", new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(1485), new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(1473) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ModifiedDate", "Password", "RecordDate", "UserName" },
                values: new object[] { 1, new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(4834), "Asdf_1234", new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(4833), "Admin" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "ProductId", "AlbumName", "ArtistId", "CategoryId", "CriticalLevel", "Discontinued", "Discount", "ModifiedDate", "Price", "ProductCode", "RecordDate", "UnitsInStock" },
                values: new object[] { 1, "Darısı Başınıza", 1, 1, 10, false, 10f, new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(4613), 100m, null, new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(4614), 10 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "ProductId", "AlbumName", "ArtistId", "CategoryId", "CriticalLevel", "Discontinued", "Discount", "ModifiedDate", "Price", "ProductCode", "RecordDate", "UnitsInStock" },
                values: new object[] { 2, "Nerede Kalmıştık", 2, 1, 10, false, 10f, new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(4618), 100m, null, new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(4618), 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RecordDate",
                table: "Artists",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Artists",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Artists",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(1210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Albums",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(4093),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RecordDate",
                table: "Albums",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(3993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Albums",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(3836),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2628));
        }
    }
}
