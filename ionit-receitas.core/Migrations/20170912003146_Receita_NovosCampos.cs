using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ionit.receitas.core.Migrations
{
    public partial class Receita_NovosCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ingredientes",
                table: "Receita",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModoPreparo",
                table: "Receita",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TempoPreparo",
                table: "Receita",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ingredientes",
                table: "Receita");

            migrationBuilder.DropColumn(
                name: "ModoPreparo",
                table: "Receita");

            migrationBuilder.DropColumn(
                name: "TempoPreparo",
                table: "Receita");
        }
    }
}
