using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirlineReservationSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixModelProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Customers_CustomerID",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Flights_FlightID",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "AirplaneID",
                table: "Seat",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeatColumn",
                table: "Seat",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SeatNumber",
                table: "Seat",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SeatRow",
                table: "Seat",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Seat",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerID1",
                table: "Reservations",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seat_AirplaneID",
                table: "Seat",
                column: "AirplaneID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerID1",
                table: "Reservations",
                column: "CustomerID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Customers_CustomerID",
                table: "Reservations",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Customers_CustomerID1",
                table: "Reservations",
                column: "CustomerID1",
                principalTable: "Customers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Flights_FlightID",
                table: "Reservations",
                column: "FlightID",
                principalTable: "Flights",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Airplanes_AirplaneID",
                table: "Seat",
                column: "AirplaneID",
                principalTable: "Airplanes",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Customers_CustomerID",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Customers_CustomerID1",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Flights_FlightID",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Airplanes_AirplaneID",
                table: "Seat");

            migrationBuilder.DropIndex(
                name: "IX_Seat_AirplaneID",
                table: "Seat");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_CustomerID1",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "AirplaneID",
                table: "Seat");

            migrationBuilder.DropColumn(
                name: "SeatColumn",
                table: "Seat");

            migrationBuilder.DropColumn(
                name: "SeatNumber",
                table: "Seat");

            migrationBuilder.DropColumn(
                name: "SeatRow",
                table: "Seat");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Seat");

            migrationBuilder.DropColumn(
                name: "CustomerID1",
                table: "Reservations");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Customers_CustomerID",
                table: "Reservations",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Flights_FlightID",
                table: "Reservations",
                column: "FlightID",
                principalTable: "Flights",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
