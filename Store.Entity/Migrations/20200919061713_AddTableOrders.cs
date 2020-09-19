using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.Entity.Migrations
{
    public partial class AddTableOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 19, 6, 17, 12, 698, DateTimeKind.Utc).AddTicks(7378), new DateTime(2020, 9, 19, 6, 17, 12, 698, DateTimeKind.Utc).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 19, 6, 17, 12, 698, DateTimeKind.Utc).AddTicks(9488), new DateTime(2020, 9, 19, 6, 17, 12, 698, DateTimeKind.Utc).AddTicks(9506) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
