using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.Entity.Migrations
{
    public partial class AddAccountType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountTypeId",
                table: "Accounts",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AccountTypes",
                columns: table => new
                {
                    AccountTypeId = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    AccountTypeName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTypes", x => x.AccountTypeId);
                    table.ForeignKey(
                        name: "FK_AccountTypes_Accounts_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountTypes_Accounts_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 28, 15, 39, 8, 996, DateTimeKind.Utc).AddTicks(1021), new DateTime(2020, 9, 28, 15, 39, 8, 996, DateTimeKind.Utc).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 28, 15, 39, 8, 996, DateTimeKind.Utc).AddTicks(3418), new DateTime(2020, 9, 28, 15, 39, 8, 996, DateTimeKind.Utc).AddTicks(3439) });

            migrationBuilder.CreateIndex(
                name: "IX_AccountTypes_CreatedBy",
                table: "AccountTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AccountTypes_UpdatedBy",
                table: "AccountTypes",
                column: "UpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountTypes");

            migrationBuilder.DropColumn(
                name: "AccountTypeId",
                table: "Accounts");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 19, 6, 19, 13, 892, DateTimeKind.Utc).AddTicks(9041), new DateTime(2020, 9, 19, 6, 19, 13, 893, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 9, 19, 6, 19, 13, 893, DateTimeKind.Utc).AddTicks(2695), new DateTime(2020, 9, 19, 6, 19, 13, 893, DateTimeKind.Utc).AddTicks(2724) });
        }
    }
}
