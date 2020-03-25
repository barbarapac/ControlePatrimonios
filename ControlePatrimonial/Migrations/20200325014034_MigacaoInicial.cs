using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlePatrimonial.Migrations
{
    public partial class MigacaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    IdEmpresa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFantasia = table.Column<string>(maxLength: 100, nullable: true),
                    CnpjCpf = table.Column<string>(maxLength: 14, nullable: true),
                    Endereco = table.Column<string>(maxLength: 100, nullable: true),
                    RazaoSocial = table.Column<string>(maxLength: 100, nullable: true),
                    Telefone = table.Column<string>(maxLength: 15, nullable: true),
                    Rua = table.Column<string>(maxLength: 50, nullable: true),
                    Bairro = table.Column<string>(maxLength: 50, nullable: true),
                    Cidade = table.Column<string>(maxLength: 50, nullable: true),
                    Numero = table.Column<string>(maxLength: 10, nullable: true),
                    Complemento = table.Column<string>(maxLength: 100, nullable: true),
                    Tipo = table.Column<string>(maxLength: 10, nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.IdEmpresa);
                });

            migrationBuilder.CreateTable(
                name: "Setor",
                columns: table => new
                {
                    IdSetor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 100, nullable: true),
                    Localizacao = table.Column<string>(maxLength: 50, nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    EmpresaIdEmpresa = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setor", x => x.IdSetor);
                    table.ForeignKey(
                        name: "FK_Setor_Empresas_EmpresaIdEmpresa",
                        column: x => x.EmpresaIdEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Endereco = table.Column<string>(maxLength: 100, nullable: true),
                    TipoUsuario = table.Column<string>(maxLength: 10, nullable: true),
                    Telefone = table.Column<string>(maxLength: 15, nullable: true),
                    Rua = table.Column<string>(maxLength: 50, nullable: true),
                    Bairro = table.Column<string>(maxLength: 50, nullable: true),
                    Cidade = table.Column<string>(maxLength: 50, nullable: true),
                    Complemento = table.Column<string>(maxLength: 100, nullable: true),
                    CnpjCpf = table.Column<string>(maxLength: 14, nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    EmpresaIdEmpresa = table.Column<int>(nullable: true),
                    SetorIdSetor = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.IdFuncionario);
                    table.ForeignKey(
                        name: "FK_Funcionario_Empresas_EmpresaIdEmpresa",
                        column: x => x.EmpresaIdEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionario_Setor_SetorIdSetor",
                        column: x => x.SetorIdSetor,
                        principalTable: "Setor",
                        principalColumn: "IdSetor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_EmpresaIdEmpresa",
                table: "Funcionario",
                column: "EmpresaIdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_SetorIdSetor",
                table: "Funcionario",
                column: "SetorIdSetor");

            migrationBuilder.CreateIndex(
                name: "IX_Setor_EmpresaIdEmpresa",
                table: "Setor",
                column: "EmpresaIdEmpresa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Setor");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
