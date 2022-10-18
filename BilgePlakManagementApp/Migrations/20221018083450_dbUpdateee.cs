using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BilgePlakManagementApp.Migrations
{
    public partial class dbUpdateee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "char(100)",
                table: "Albums",
                newName: "ProductCode");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RecordDate",
                table: "Artists",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Artists",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Artists",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(1210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Albums",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(4093),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RecordDate",
                table: "Albums",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(3993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Albums",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(3836),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(5077));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductCode",
                table: "Albums",
                newName: "char(100)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RecordDate",
                table: "Artists",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(4377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Artists",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(4187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Artists",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(4465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Albums",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(5336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RecordDate",
                table: "Albums",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(5239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Albums",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(5077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 34, 50, 4, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "ArtistName", "ModifiedDate", "RecordDate" },
                values: new object[,]
                {
                    { 1, "Barış Manço", new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(4521), new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(4520) },
                    { 2, "Cem Karaca", new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(4523), new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(4522) }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "ModifiedDate", "RecordDate" },
                values: new object[] { 1, "Plak", new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(3931), new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ModifiedDate", "Password", "RecordDate", "UserName" },
                values: new object[] { 1, new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(7330), "Asdf_1234", new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(7330), "Admin" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "ProductId", "AlbumName", "ArtistId", "CategoryId", "CriticalLevel", "Discontinued", "Discount", "ModifiedDate", "Price", "char(100)", "RecordDate", "UnitsInStock" },
                values: new object[] { 1, "Darısı Başınıza", 1, 1, 10, false, 10f, new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(7099), 100m, null, new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(7101), 10 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "ProductId", "AlbumName", "ArtistId", "CategoryId", "CriticalLevel", "Discontinued", "Discount", "ModifiedDate", "Price", "char(100)", "RecordDate", "UnitsInStock" },
                values: new object[] { 2, "Nerede Kalmıştık", 2, 1, 10, false, 10f, new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(7103), 100m, null, new DateTime(2022, 10, 18, 10, 40, 29, 853, DateTimeKind.Local).AddTicks(7104), 10 });
        }
    }
}
