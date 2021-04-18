using Microsoft.EntityFrameworkCore.Migrations;

namespace Lets_Travel.Migrations
{
    public partial class initLetsTravelDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlightFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlightTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    FlightTime = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    ORDINARYprice = table.Column<int>(type: "int", nullable: false),
                    BUSINESSprice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");
        }
    }
}
