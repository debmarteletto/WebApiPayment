using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiPayment.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    paymentId = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    cardOwnerName = table.Column<string>(type: "varchar(100)", nullable: false),
                    cardNumber = table.Column<string>(type: "varchar(16)", nullable: false),
                    expirationDate = table.Column<string>(type: "varchar(5)", nullable: false),
                    CVV = table.Column<string>(type: "varchar(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.paymentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "payments");
        }
    }
}
