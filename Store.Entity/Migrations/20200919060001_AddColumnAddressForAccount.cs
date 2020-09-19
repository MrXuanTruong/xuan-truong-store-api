using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.Entity.Migrations
{
    public partial class AddColumnAddressForAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Accounts",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 19, 6, 0, 0, 637, DateTimeKind.Utc).AddTicks(1744), new DateTime(2020, 9, 19, 6, 0, 0, 637, DateTimeKind.Utc).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 19, 6, 0, 0, 637, DateTimeKind.Utc).AddTicks(3853), new DateTime(2020, 9, 19, 6, 0, 0, 637, DateTimeKind.Utc).AddTicks(3871) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Accounts");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 19, 5, 53, 33, 307, DateTimeKind.Utc).AddTicks(170), new DateTime(2020, 9, 19, 5, 53, 33, 307, DateTimeKind.Utc).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 19, 5, 53, 33, 307, DateTimeKind.Utc).AddTicks(5449), new DateTime(2020, 9, 19, 5, 53, 33, 307, DateTimeKind.Utc).AddTicks(5545) });
        }
    }
}
