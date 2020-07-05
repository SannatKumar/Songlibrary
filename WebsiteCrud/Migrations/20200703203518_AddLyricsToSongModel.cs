using Microsoft.EntityFrameworkCore.Migrations;

namespace WebsiteCrud.Migrations
{
    public partial class AddLyricsToSongModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lyrics",
                table: "Song",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lyrics",
                table: "Song");
        }
    }
}
