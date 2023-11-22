using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "8bf4b8b7-314e-439f-ba22-ab30be823989", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBvhkWeIXW/H7cbqWt5Vdkkp6vNTIP7qXkBjvmZGzg/Wr13D56VIfYpRT9BRKCwHcg==", null, false, "2b23b33e-5944-4a40-93a0-da730346722e", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 45, 16, 80, DateTimeKind.Local).AddTicks(5310), new DateTime(2023, 11, 22, 11, 45, 16, 80, DateTimeKind.Local).AddTicks(5321), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 45, 16, 80, DateTimeKind.Local).AddTicks(5325), new DateTime(2023, 11, 22, 11, 45, 16, 80, DateTimeKind.Local).AddTicks(5325), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 45, 16, 80, DateTimeKind.Local).AddTicks(5645), new DateTime(2023, 11, 22, 11, 45, 16, 80, DateTimeKind.Local).AddTicks(5646), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 45, 16, 80, DateTimeKind.Local).AddTicks(5647), new DateTime(2023, 11, 22, 11, 45, 16, 80, DateTimeKind.Local).AddTicks(5648), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 45, 16, 80, DateTimeKind.Local).AddTicks(5831), new DateTime(2023, 11, 22, 11, 45, 16, 80, DateTimeKind.Local).AddTicks(5831), "3Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 45, 16, 80, DateTimeKind.Local).AddTicks(5833), new DateTime(2023, 11, 22, 11, 45, 16, 80, DateTimeKind.Local).AddTicks(5834), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 22, 11, 45, 16, 80, DateTimeKind.Local).AddTicks(5861), new DateTime(2023, 11, 22, 11, 45, 16, 80, DateTimeKind.Local).AddTicks(5862), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 22, 11, 45, 16, 80, DateTimeKind.Local).AddTicks(5863), new DateTime(2023, 11, 22, 11, 45, 16, 80, DateTimeKind.Local).AddTicks(5864), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
