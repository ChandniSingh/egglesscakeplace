using Microsoft.EntityFrameworkCore.Migrations;

namespace CakeAPI.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "cakes_hilo",
                incrementBy: 10);

            migrationBuilder.CreateTable(
                name: "Cakes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(),
                    Title = table.Column<string>(),
                    PictureUrl = table.Column<string>()
                }
                );

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cakes",
                table: "Cakes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cakes",
                table: "Cakes");

            migrationBuilder.DropSequence(
                name: "cakes_hilo");

        }
    }
}
