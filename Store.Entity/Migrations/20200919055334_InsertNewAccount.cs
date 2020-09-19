using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.Entity.Migrations
{
    public partial class InsertNewAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate", "Username" },
                values: new object[] { new DateTime(2020, 9, 19, 5, 53, 33, 307, DateTimeKind.Utc).AddTicks(170), new DateTime(2020, 9, 19, 5, 53, 33, 307, DateTimeKind.Utc).AddTicks(2843), "admin" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountId", "CreatedBy", "CreatedDate", "DateOfBirth", "Email", "FullName", "Password", "Phone", "UpdatedBy", "UpdatedDate", "Username" },
                values: new object[] { 2L, null, new DateTime(2020, 9, 19, 5, 53, 33, 307, DateTimeKind.Utc).AddTicks(5449), new DateTime(1991, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "locxtit1@gmail.com", "locxtit", "e10adc3949ba59abbe56e057f20f883e", "0986210955", null, new DateTime(2020, 9, 19, 5, 53, 33, 307, DateTimeKind.Utc).AddTicks(5545), "locxtit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 2L);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate", "Username" },
                values: new object[] { new DateTime(2020, 9, 14, 7, 23, 45, 683, DateTimeKind.Utc).AddTicks(1959), new DateTime(2020, 9, 14, 7, 23, 45, 683, DateTimeKind.Utc).AddTicks(3034), "locxtit" });
        }
    }
}
