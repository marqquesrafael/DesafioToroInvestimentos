using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DesafioToroInvestimentos.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class userAssets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_user",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    full_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    balance = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_investiment_asset",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    value = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_investiment_asset", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_investiment_asset_tb_user_user_id",
                        column: x => x.user_id,
                        principalTable: "tb_user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tb_user",
                columns: new[] { "id", "active", "balance", "cpf", "created_at", "email", "full_name", "password", "phone_number", "type", "updated_at" },
                values: new object[,]
                {
                    { 1L, true, 100m, "111.111.111-01", new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(8880), "admin@toroinvestimentos.com", "Administrator", "1234", "31 99999-9999", "Administrator", null },
                    { 2L, true, 150m, "222.222.222-02", new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(8893), "fernando@toroinvestimentos.com", "Fernando Souza", "1234", "31 98888-8888", "Client", null },
                    { 3L, true, 250m, "333.333.333-03", new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(8894), "ricardo@toroinvestimentos.com", "Ricardo Giani", "1234", "31 97777-7777", "Client", null },
                    { 4L, true, 300m, "444.444.444-04", new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(8895), "rafael@toroinvestimentos.com", "Rafael Marques", "1234", "31 96666-6666", "Client", null }
                });

            migrationBuilder.InsertData(
                table: "tb_investiment_asset",
                columns: new[] { "id", "active", "created_at", "name", "quantity", "updated_at", "user_id", "value" },
                values: new object[,]
                {
                    { 1L, true, new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9841), "PETR4", 10, null, 2L, 28.44m },
                    { 2L, true, new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9843), "SANB11", 4, null, 2L, 40.77m },
                    { 3L, true, new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9844), "MGLU3", 12, null, 2L, 25.91m },
                    { 4L, true, new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9844), "VVAR3", 2, null, 2L, 25.91m },
                    { 5L, true, new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9845), "TORO4", 25, null, 2L, 115.91m },
                    { 6L, true, new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9846), "PETR4", 5, null, 3L, 28.44m },
                    { 7L, true, new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9847), "SANB11", 9, null, 3L, 40.77m },
                    { 8L, true, new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9847), "MGLU3", 12, null, 3L, 25.91m },
                    { 9L, true, new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9848), "VVAR3", 1, null, 3L, 25.91m },
                    { 10L, true, new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9849), "TORO4", 18, null, 3L, 115.91m },
                    { 11L, true, new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9849), "PETR4", 14, null, 4L, 28.44m },
                    { 12L, true, new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9850), "SANB11", 9, null, 4L, 40.77m },
                    { 13L, true, new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9851), "MGLU3", 13, null, 4L, 25.91m },
                    { 14L, true, new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9852), "VVAR3", 7, null, 4L, 25.91m },
                    { 15L, true, new DateTime(2023, 8, 10, 5, 43, 46, 467, DateTimeKind.Local).AddTicks(9852), "TORO4", 22, null, 4L, 115.91m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_investiment_asset_user_id",
                table: "tb_investiment_asset",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_investiment_asset");

            migrationBuilder.DropTable(
                name: "tb_user");
        }
    }
}
