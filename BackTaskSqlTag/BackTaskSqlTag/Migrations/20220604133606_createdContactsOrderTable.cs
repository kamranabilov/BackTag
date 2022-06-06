using Microsoft.EntityFrameworkCore.Migrations;

namespace BackTaskSqlTag.Migrations
{
    public partial class createdContactsOrderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Order",
                table: "Contacts",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Contacts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Contacts");
        }
    }
}
