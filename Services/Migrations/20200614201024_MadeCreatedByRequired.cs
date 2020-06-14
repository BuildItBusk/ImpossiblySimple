using Microsoft.EntityFrameworkCore.Migrations;

namespace Services.Migrations
{
    public partial class MadeCreatedByRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Assets",
                maxLength: 64,
                nullable: false,
                defaultValueSql: "SYSTEM_USER",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValueSql: "SYSTEM_USER");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Agreements",
                maxLength: 64,
                nullable: false,
                defaultValueSql: "SYSTEM_USER",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValueSql: "SYSTEM_USER");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Assets",
                type: "nvarchar(max)",
                nullable: true,
                defaultValueSql: "SYSTEM_USER",
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldDefaultValueSql: "SYSTEM_USER");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Agreements",
                type: "nvarchar(max)",
                nullable: true,
                defaultValueSql: "SYSTEM_USER",
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldDefaultValueSql: "SYSTEM_USER");
        }
    }
}
