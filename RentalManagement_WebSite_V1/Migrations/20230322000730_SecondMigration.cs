using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentalManagement_WebSite_V1.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_Buildings_BuildingId",
                table: "Apartment");

            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_Manager_ManagerId",
                table: "Apartment");

            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_Tenants_TenantId",
                table: "Apartment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manager",
                table: "Manager");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apartment",
                table: "Apartment");

            migrationBuilder.DropIndex(
                name: "IX_Apartment_TenantId",
                table: "Apartment");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Apartment");

            migrationBuilder.RenameTable(
                name: "Manager",
                newName: "Managers");

            migrationBuilder.RenameTable(
                name: "Apartment",
                newName: "Apartments");

            migrationBuilder.RenameIndex(
                name: "IX_Apartment_ManagerId",
                table: "Apartments",
                newName: "IX_Apartments_ManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_Apartment_BuildingId",
                table: "Apartments",
                newName: "IX_Apartments_BuildingId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Apartments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Managers",
                table: "Managers",
                column: "ManagerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apartments",
                table: "Apartments",
                column: "ApartmentId");

            migrationBuilder.CreateTable(
                name: "Tenants_Apts",
                columns: table => new
                {
                    ApartmentId = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants_Apts", x => new { x.TenantId, x.ApartmentId });
                    table.ForeignKey(
                        name: "FK_Tenants_Apts_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tenants_Apts_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_Apts_ApartmentId",
                table: "Tenants_Apts",
                column: "ApartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_Buildings_BuildingId",
                table: "Apartments",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "BuildingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_Managers_ManagerId",
                table: "Apartments",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "ManagerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_Buildings_BuildingId",
                table: "Apartments");

            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_Managers_ManagerId",
                table: "Apartments");

            migrationBuilder.DropTable(
                name: "Tenants_Apts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Managers",
                table: "Managers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apartments",
                table: "Apartments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Apartments");

            migrationBuilder.RenameTable(
                name: "Managers",
                newName: "Manager");

            migrationBuilder.RenameTable(
                name: "Apartments",
                newName: "Apartment");

            migrationBuilder.RenameIndex(
                name: "IX_Apartments_ManagerId",
                table: "Apartment",
                newName: "IX_Apartment_ManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_Apartments_BuildingId",
                table: "Apartment",
                newName: "IX_Apartment_BuildingId");

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "Apartment",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manager",
                table: "Manager",
                column: "ManagerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apartment",
                table: "Apartment",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_TenantId",
                table: "Apartment",
                column: "TenantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_Buildings_BuildingId",
                table: "Apartment",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "BuildingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_Manager_ManagerId",
                table: "Apartment",
                column: "ManagerId",
                principalTable: "Manager",
                principalColumn: "ManagerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_Tenants_TenantId",
                table: "Apartment",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "TenantId");
        }
    }
}
