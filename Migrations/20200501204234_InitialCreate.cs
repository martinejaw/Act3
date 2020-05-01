using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFGetStarted.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    matricula = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.matricula);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    dni = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(nullable: false),
                    apellido = table.Column<string>(nullable: false),
                    fechaNac = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.dni);
                });

            migrationBuilder.CreateTable(
                name: "Casos",
                columns: table => new
                {
                    CasoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    medicomatricula = table.Column<int>(nullable: false),
                    pacientedni = table.Column<int>(nullable: false),
                    estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casos", x => x.CasoId);
                    table.ForeignKey(
                        name: "FK_Casos_Medicos_medicomatricula",
                        column: x => x.medicomatricula,
                        principalTable: "Medicos",
                        principalColumn: "matricula",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Casos_Pacientes_pacientedni",
                        column: x => x.pacientedni,
                        principalTable: "Pacientes",
                        principalColumn: "dni",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    ConsultaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    pacientedni = table.Column<int>(nullable: false),
                    medicomatricula = table.Column<int>(nullable: false),
                    fecha = table.Column<DateTime>(nullable: false),
                    descripcionSintomas = table.Column<string>(nullable: true),
                    diagnostico = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.ConsultaId);
                    table.ForeignKey(
                        name: "FK_Consultas_Medicos_medicomatricula",
                        column: x => x.medicomatricula,
                        principalTable: "Medicos",
                        principalColumn: "matricula",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultas_Pacientes_pacientedni",
                        column: x => x.pacientedni,
                        principalTable: "Pacientes",
                        principalColumn: "dni",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pruebas",
                columns: table => new
                {
                    PruebaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    resultado = table.Column<bool>(nullable: false),
                    fecha = table.Column<DateTime>(nullable: false),
                    fechaResultado = table.Column<DateTime>(nullable: false),
                    CasoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pruebas", x => x.PruebaId);
                    table.ForeignKey(
                        name: "FK_Pruebas_Casos_CasoId",
                        column: x => x.CasoId,
                        principalTable: "Casos",
                        principalColumn: "CasoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Casos_medicomatricula",
                table: "Casos",
                column: "medicomatricula");

            migrationBuilder.CreateIndex(
                name: "IX_Casos_pacientedni",
                table: "Casos",
                column: "pacientedni");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_medicomatricula",
                table: "Consultas",
                column: "medicomatricula");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_pacientedni",
                table: "Consultas",
                column: "pacientedni");

            migrationBuilder.CreateIndex(
                name: "IX_Pruebas_CasoId",
                table: "Pruebas",
                column: "CasoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consultas");

            migrationBuilder.DropTable(
                name: "Pruebas");

            migrationBuilder.DropTable(
                name: "Casos");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}
