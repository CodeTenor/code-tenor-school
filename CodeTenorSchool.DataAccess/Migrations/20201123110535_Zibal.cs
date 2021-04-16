using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeTenorSchool.DataAccess.Migrations
{
    public partial class Zibal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Student",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Age", "CreatedDate", "Name", "Surname" },
                values: new object[] { new Guid("915ad581-3c72-4e24-a0ec-f1e30d12fc45"), 26, new DateTime(2020, 11, 23, 11, 5, 35, 136, DateTimeKind.Utc).AddTicks(9862), "Jason", "Pietersen" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Age", "CreatedDate", "Name", "Surname" },
                values: new object[] { new Guid("6f0713f9-e5a0-408b-8983-c7b4d40c7511"), 23, new DateTime(2020, 11, 23, 11, 5, 35, 137, DateTimeKind.Utc).AddTicks(1654), "Sean", "Pietersen" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Age", "CreatedDate", "Name", "Surname" },
                values: new object[] { new Guid("1604b6e2-b4a6-4eec-9f30-09229fdebeb4"), 50, new DateTime(2020, 11, 23, 11, 5, 35, 137, DateTimeKind.Utc).AddTicks(1683), "Claudia", "Pietersen" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("1604b6e2-b4a6-4eec-9f30-09229fdebeb4"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("6f0713f9-e5a0-408b-8983-c7b4d40c7511"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("915ad581-3c72-4e24-a0ec-f1e30d12fc45"));

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Student");
        }
    }
}
