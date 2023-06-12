using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SenderCity = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    SenderLocation = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    RecipientCity = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    RecipientLocation = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    LoadWeight = table.Column<long>(type: "bigint", nullable: false),
                    PickupDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
