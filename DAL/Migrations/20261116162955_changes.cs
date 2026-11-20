using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Rooms_Price",
                table: "Rooms");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Rooms_Price",
                table: "Rooms",
                sql: "[Price]>=0");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Rooms_RoomNumber",
                table: "Rooms",
                sql: "[RoomNumber]>=0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Rooms_Price",
                table: "Rooms");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Rooms_RoomNumber",
                table: "Rooms");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Rooms_Price",
                table: "Rooms",
                sql: "[RoomNumber]>=0");
        }
    }
}
