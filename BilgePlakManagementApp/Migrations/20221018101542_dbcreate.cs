using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BilgePlakManagementApp.Migrations
{
    public partial class dbcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RecordDate",
                table: "Artists",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Artists",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Artists",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Albums",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(1755),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RecordDate",
                table: "Albums",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(1633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Albums",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(1450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "ProductCode", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(3470), "BM000001", new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "ProductCode", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(3476), "CK000001", new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(938), new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(940), new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(348), new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(3727), new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(3725) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Artists",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(1750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Artists",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Albums",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RecordDate",
                table: "Albums",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Albums",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 10, 18, 13, 15, 42, 501, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "ProductCode", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(4613), null, new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "ProductCode", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(4618), null, new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2056), new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2058), new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(1485), new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RecordDate" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(4834), new DateTime(2022, 10, 18, 11, 36, 48, 187, DateTimeKind.Local).AddTicks(4833) });
        }
    }
}
