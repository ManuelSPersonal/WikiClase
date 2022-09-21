using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WikiClase.Migrations
{
    public partial class correction7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Posts_IdTags",
                table: "Posts",
                column: "IdTags");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Tags_IdTags",
                table: "Posts",
                column: "IdTags",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Tags_IdTags",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_IdTags",
                table: "Posts");
        }
    }
}
