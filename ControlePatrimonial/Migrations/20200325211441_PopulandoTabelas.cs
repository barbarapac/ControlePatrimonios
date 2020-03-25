using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlePatrimonial.Migrations
{
    public partial class PopulandoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Empresa (NomeFantasia, CnpjCpf, Endereco, RazaoSocial, Telefone, Rua, Bairro, Cidade, Numero, Complemento, Tipo, DataCadastro)" +
                                "VALUES ('Empresa 01','12345678912345','Endereco tal','Empresa 0101','46999229846','rua tal','bairro tsl', 'Francisco Beltrão','123','ap 32','FORNECEDOR','20120618 10:34:09 AM')");
            migrationBuilder.Sql("INSERT INTO Empresa (NomeFantasia, CnpjCpf, Endereco, RazaoSocial, Telefone, Rua, Bairro, Cidade, Numero, Complemento, Tipo,DataCadastro)" +
                               "VALUES ('Empresa 02','12345678912345','Endereco tal 02','Empresa  razao 02','46999229846','rua tal','bairro tal 02','Francisco Beltrão','123','ap 32','FILIAL','20120618 10:34:09 AM')");
            migrationBuilder.Sql("INSERT INTO Empresa (NomeFantasia, CnpjCpf, Endereco, RazaoSocial, Telefone, Rua, Bairro, Cidade, Numero, Complemento, Tipo,DataCadastro)" +
                                           "VALUES ('Empresa 03','12345678912345','Endereco tal 03','Empresa razao 03','46999229846','rua tal','bairro tal 03','Francisco Beltrão','123','ap 32','FILIAL','20120618 10:34:09 AM')");



            migrationBuilder.Sql("INSERT INTO Setor (Nome, Localizacao, EmpresaIdEmpresa, DataCadastro) " +
                                " VALUES  ('SETOR1', 'FABRICA 01', 1,'20120618 10:34:09 AM')");
            migrationBuilder.Sql("INSERT INTO Setor (Nome, Localizacao, EmpresaIdEmpresa, DataCadastro) " +
                    " VALUES  ('SETOR2', 'ABATE 10', 2,'20120618 10:34:09 AM')");
            migrationBuilder.Sql("INSERT INTO Setor (Nome, Localizacao, EmpresaIdEmpresa, DataCadastro) " +
                    " VALUES  ('SETOR3', 'FABRICA 02', 3,'20120618 10:34:09 AM')");


            migrationBuilder.Sql("INSERT INTO Funcionario (Email, Endereco, TipoUsuario, Telefone, Rua, Bairro, Cidade, Complemento, CnpjCpf, EmpresaIdEmpresa, SetorIdSetor, DataCadastro)" +
                                " VALUES  ('barbara@gmail.com', 'Endereco tal','ADMIN','46999229846','Rua tal mm','bairro tal','Francisco Beltrão','ap 02','08692354945', 1, 1,'20120618 10:34:09 AM')");
            migrationBuilder.Sql("INSERT INTO Funcionario (Email, Endereco, TipoUsuario, Telefone, Rua, Bairro, Cidade, Complemento, CnpjCpf, EmpresaIdEmpresa, SetorIdSetor, DataCadastro)" +
                                " VALUES  ('MICHEL@gmail.com', 'Endereco tal michel','GEREN','46999229846','Rua tal mm','bairro tal','Francisco Beltrão','complementooo','08692354945', 3, 3,'20120618 10:34:09 AM')");
            migrationBuilder.Sql("INSERT INTO Funcionario (Email, Endereco, TipoUsuario, Telefone, Rua, Bairro, Cidade, Complemento, CnpjCpf, EmpresaIdEmpresa, SetorIdSetor, DataCadastro)" +
                                " VALUES  ('SARA@gmail.com', 'Endereco tal sara','FUNC','46999229846','Rua tal mm','são francisco','Francisco Beltrão','casa dos fundos','08692354945', 2, 2,'20120618 10:34:09 AM')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Empresa");
            migrationBuilder.Sql("DELETE FROM Setor");
            migrationBuilder.Sql("DELETE FROM Funcionario");
        }
    }
}
