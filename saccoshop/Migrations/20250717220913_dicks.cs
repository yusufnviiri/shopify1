using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace saccoshop.Migrations
{
    /// <inheritdoc />
    public partial class dicks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    RoomOwner = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                });

            migrationBuilder.CreateTable(
                name: "ShopItems",
                columns: table => new
                {
                    ShopItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopItemName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ShopItemDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopItems", x => x.ShopItemId);
                    table.ForeignKey(
                        name: "FK_ShopItems_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "RoomName", "RoomOwner" },
                values: new object[,]
                {
                    { 1, "Lati Technologies", "Martin Lubega" },
                    { 2, "DreamLand", "Isaac" },
                    { 3, "Pete Games", "Leonard" }
                });

            migrationBuilder.InsertData(
                table: "ShopItems",
                columns: new[] { "ShopItemId", "RoomId", "ShopItemDescription", "ShopItemName" },
                values: new object[,]
                {
                    { 1, 1, "Lenovo T430 i7 series with a built-in battery pack ", "Lenovo Think Pad " },
                    { 2, 2, "A high resolution camera with backup battery ", "GL360 Camera" },
                    { 3, 3, "This brand new console belongs the the XRNM model series with NVDIA accerelators", "XBox Game Console" },
                    { 4, 1, "i7 server with 64TB RAM provision and upto 200TB storage capacity.Comes with a built-in DHCP multi-port router", "RTC293 HP Server " }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopItems_RoomId",
                table: "ShopItems",
                column: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopItems");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
