using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CantonesePronunciationApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateWordsModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Page = table.Column<int>(type: "int", nullable: false),
                    word = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AlternativeWord = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Jyutping = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Consonant = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    Vowel = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    Tone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Words");
        }
    }
}
