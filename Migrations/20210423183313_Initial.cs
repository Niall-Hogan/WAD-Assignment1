using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WAD_Assignment1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeID = table.Column<short>(type: "smallint", nullable: false),
                    Title = table.Column<string>(type: "varchar(46)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(46)", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CookingTime = table.Column<short>(type: "smallint", nullable: false),
                    Step1 = table.Column<string>(type: "varchar(489)", nullable: true),
                    Step2 = table.Column<string>(type: "varchar(529)", nullable: true),
                    Step3 = table.Column<string>(type: "varchar(437)", nullable: true),
                    Step4 = table.Column<string>(type: "varchar(167)", nullable: true),
                    Ingredient1 = table.Column<string>(type: "varchar(54)", nullable: true),
                    Ingredient2 = table.Column<string>(type: "varchar(45)", nullable: true),
                    Ingredient3 = table.Column<string>(type: "varchar(73)", nullable: true),
                    Ingredient4 = table.Column<string>(type: "varchar(49)", nullable: true),
                    Ingredient5 = table.Column<string>(type: "varchar(43)", nullable: true),
                    Ingredient6 = table.Column<string>(type: "varchar(50)", nullable: true),
                    Ingredient7 = table.Column<string>(type: "varchar(56)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
