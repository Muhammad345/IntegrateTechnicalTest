using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IntegrateTechnicalTest.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LeadClass",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LeadClass",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LeadClass",
                keyColumn: "Id",
                keyValue: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LeadClass",
                columns: new[] { "Id", "Company", "DateCreated", "Email", "FirstName", "IsAcceptedTerms", "LastName", "PostCode" },
                values: new object[] { 1, "Akroo", new DateTime(2019, 11, 13, 19, 10, 23, 605, DateTimeKind.Utc).AddTicks(9581), "myhotmail@gmail.com", "First Name", true, "Last Name ", "TM12 XT5" });

            migrationBuilder.InsertData(
                table: "LeadClass",
                columns: new[] { "Id", "Company", "DateCreated", "Email", "FirstName", "IsAcceptedTerms", "LastName", "PostCode" },
                values: new object[] { 2, "Akroo2", new DateTime(2019, 11, 13, 19, 10, 23, 606, DateTimeKind.Utc).AddTicks(85), "myhotmail@gmail.com", "First Name2", true, "Last Name2 ", "TM12 XT5" });

            migrationBuilder.InsertData(
                table: "LeadClass",
                columns: new[] { "Id", "Company", "DateCreated", "Email", "FirstName", "IsAcceptedTerms", "LastName", "PostCode" },
                values: new object[] { 3, "Akroo23", new DateTime(2019, 11, 13, 19, 10, 23, 606, DateTimeKind.Utc).AddTicks(100), "myhotmail@gmail.com", "First Name3", true, "Last Name 3", "TM12 XT5" });
        }
    }
}
