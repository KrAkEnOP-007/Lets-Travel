using Microsoft.EntityFrameworkCore.Migrations;

namespace Lets_Travel.Migrations
{
    public partial class initialization_Db : Migration
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
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlightTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ORDINARYprice = table.Column<int>(type: "int", nullable: false),
                    BUSINESSprice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightID);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pincode = table.Column<long>(type: "bigint", nullable: false),
                    HotelAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hotel_Room_Features = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hotel_Additional_Features = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price_Single_Bed = table.Column<int>(type: "int", nullable: false),
                    Price_Double_Bed = table.Column<int>(type: "int", nullable: false),
                    Pic1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pic2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pic3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pic4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pic5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.HotelId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
