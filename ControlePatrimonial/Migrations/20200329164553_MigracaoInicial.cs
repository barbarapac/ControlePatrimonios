﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlePatrimonial.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    IdEmpresa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFantasia = table.Column<string>(maxLength: 100, nullable: false),
                    CnpjCpf = table.Column<string>(maxLength: 14, nullable: false),
                    Cep = table.Column<string>(maxLength: 20, nullable: false),
                    RazaoSocial = table.Column<string>(maxLength: 100, nullable: false),
                    Telefone = table.Column<string>(maxLength: 15, nullable: false),
                    Rua = table.Column<string>(maxLength: 50, nullable: false),
                    Bairro = table.Column<string>(maxLength: 50, nullable: false),
                    Cidade = table.Column<string>(maxLength: 50, nullable: false),
                    Numero = table.Column<string>(maxLength: 10, nullable: false),
                    Complemento = table.Column<string>(maxLength: 100, nullable: true),
                    Tipo = table.Column<string>(maxLength: 15, nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.IdEmpresa);
                });

            migrationBuilder.CreateTable(
                name: "Setor",
                columns: table => new
                {
                    IdSetor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Localizacao = table.Column<string>(maxLength: 50, nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setor", x => x.IdSetor);
                    table.ForeignKey(
                        name: "FK_Setor_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    Cep = table.Column<string>(maxLength: 20, nullable: false),
                    TipoUsuario = table.Column<string>(maxLength: 15, nullable: false),
                    Telefone = table.Column<string>(maxLength: 15, nullable: false),
                    Rua = table.Column<string>(maxLength: 50, nullable: false),
                    Bairro = table.Column<string>(maxLength: 50, nullable: false),
                    Cidade = table.Column<string>(maxLength: 50, nullable: false),
                    Complemento = table.Column<string>(maxLength: 100, nullable: true),
                    CnpjCpf = table.Column<string>(maxLength: 14, nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    SetorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.IdFuncionario);
                    table.ForeignKey(
                        name: "FK_Funcionario_Setor_SetorId",
                        column: x => x.SetorId,
                        principalTable: "Setor",
                        principalColumn: "IdSetor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_SetorId",
                table: "Funcionario",
                column: "SetorId");

            migrationBuilder.CreateIndex(
                name: "IX_Setor_EmpresaId",
                table: "Setor",
                column: "EmpresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Setor");

            migrationBuilder.DropTable(
                name: "Empresa");
        }
    }
}
