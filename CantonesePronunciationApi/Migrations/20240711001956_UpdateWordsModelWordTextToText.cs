using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CantonesePronunciationApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateWordsModelWordTextToText : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "word",
                table: "Words",
                newName: "Text");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Words",
                newName: "word");
        }
    }
}
