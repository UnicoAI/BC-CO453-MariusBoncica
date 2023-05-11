using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApps.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostID",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "PostID",
                table: "Comments",
                newName: "Postid");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostID",
                table: "Comments",
                newName: "IX_Comments_Postid");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_Postid",
                table: "Comments",
                column: "Postid",
                principalTable: "Posts",
                principalColumn: "PostID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_Postid",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "Postid",
                table: "Comments",
                newName: "PostID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_Postid",
                table: "Comments",
                newName: "IX_Comments_PostID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostID",
                table: "Comments",
                column: "PostID",
                principalTable: "Posts",
                principalColumn: "PostID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
