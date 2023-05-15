using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApps.Data.Migrations
{
    /// <inheritdoc />
    public partial class Postid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_Postid",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "PostID",
                table: "Posts",
                newName: "PostId");

            migrationBuilder.RenameColumn(
                name: "Postid",
                table: "Comments",
                newName: "PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_Postid",
                table: "Comments",
                newName: "IX_Comments_PostId");

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Posts",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "Posts",
                newName: "PostID");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "Comments",
                newName: "Postid");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostId",
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
    }
}
