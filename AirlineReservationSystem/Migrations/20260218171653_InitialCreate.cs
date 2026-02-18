using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineReservationSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airplanes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airplanes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AirplaneID = table.Column<int>(type: "INTEGER", nullable: false),
                    DepartureAirport = table.Column<int>(type: "INTEGER", nullable: false),
                    ArrivalAirport = table.Column<int>(type: "INTEGER", nullable: false),
                    AirplaneID1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Flights_Airplanes_AirplaneID",
                        column: x => x.AirplaneID,
                        principalTable: "Airplanes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Flights_Airplanes_AirplaneID1",
                        column: x => x.AirplaneID1,
                        principalTable: "Airplanes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerID = table.Column<int>(type: "INTEGER", nullable: false),
                    FlightID = table.Column<int>(type: "INTEGER", nullable: false),
                    FlightID1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reservations_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Flights_FlightID",
                        column: x => x.FlightID,
                        principalTable: "Flights",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Flights_FlightID1",
                        column: x => x.FlightID1,
                        principalTable: "Flights",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReservationID = table.Column<int>(type: "INTEGER", nullable: false),
                    SeatNumber = table.Column<string>(type: "TEXT", nullable: false),
                    SeatRow = table.Column<int>(type: "INTEGER", nullable: false),
                    SeatColumn = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    SeatClass = table.Column<int>(type: "INTEGER", nullable: false),
                    AirplaneID = table.Column<int>(type: "INTEGER", nullable: true),
                    FlightID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Seat_Airplanes_AirplaneID",
                        column: x => x.AirplaneID,
                        principalTable: "Airplanes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Seat_Flights_FlightID",
                        column: x => x.FlightID,
                        principalTable: "Flights",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Seat_Reservations_ReservationID",
                        column: x => x.ReservationID,
                        principalTable: "Reservations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flights_AirplaneID",
                table: "Flights",
                column: "AirplaneID");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_AirplaneID1",
                table: "Flights",
                column: "AirplaneID1");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerID",
                table: "Reservations",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_FlightID",
                table: "Reservations",
                column: "FlightID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_FlightID1",
                table: "Reservations",
                column: "FlightID1");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_AirplaneID",
                table: "Seat",
                column: "AirplaneID");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_FlightID",
                table: "Seat",
                column: "FlightID");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_ReservationID",
                table: "Seat",
                column: "ReservationID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Airplanes");
        }
    }
}
