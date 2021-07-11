using Microsoft.EntityFrameworkCore.Migrations;

namespace ScribbleBoardApi.Migrations
{
    public partial class changetoUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Artist",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "ArtistId",
                table: "Images",
                newName: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Images",
                newName: "ArtistId");

            migrationBuilder.AddColumn<string>(
                name: "Artist",
                table: "Images",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
