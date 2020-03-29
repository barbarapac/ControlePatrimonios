using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlePatrimonial.Migrations
{
    public partial class PolulandoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Empresa (NomeFantasia, CnpjCpf, Cep, RazaoSocial, Telefone, Rua, Bairro, Cidade, Numero, Complemento, Tipo, DataCadastro)" +
                                          "VALUES ('Empresa 01','12345678912345','85660000','Empresa 0101','46999229846','rua tal','bairro tsl', 'Francisco Beltrão','123','ap 32','FORNECEDOR','20120618 10:34:09 AM')");
            migrationBuilder.Sql("INSERT INTO Empresa (NomeFantasia, CnpjCpf, Cep, RazaoSocial, Telefone, Rua, Bairro, Cidade, Numero, Complemento, Tipo,DataCadastro)" +
                               "VALUES ('Empresa 02','12345678912345','85660000','Empresa  razao 02','46999229846','rua tal','bairro tal 02','Francisco Beltrão','123','ap 32','FILIAL','20120618 10:34:09 AM')");
            migrationBuilder.Sql("INSERT INTO Empresa (NomeFantasia, CnpjCpf, Cep, RazaoSocial, Telefone, Rua, Bairro, Cidade, Numero, Complemento, Tipo,DataCadastro)" +
                                           "VALUES ('Empresa 03','12345678912345','85660000','Empresa razao 03','46999229846','rua tal','bairro tal 03','Francisco Beltrão','123','ap 32','FILIAL','20120618 10:34:09 AM')");

            migrationBuilder.Sql("INSERT INTO Setor (Nome, Localizacao, EmpresaId, DataCadastro) " +
                                " VALUES  ('SETOR1', 'FABRICA 01', 1,'20120618 10:34:09 AM')");
            migrationBuilder.Sql("INSERT INTO Setor (Nome, Localizacao, EmpresaId, DataCadastro) " +
                    " VALUES  ('SETOR2', 'ABATE 10', 2,'20120618 10:34:09 AM')");
            migrationBuilder.Sql("INSERT INTO Setor (Nome, Localizacao, EmpresaId, DataCadastro) " +
                    " VALUES  ('SETOR3', 'FABRICA 02', 3,'20120618 10:34:09 AM')");

            migrationBuilder.Sql("INSERT INTO Funcionario (Nome, Email, Cep, TipoUsuario, Telefone, Rua, Bairro, Cidade, Complemento, CnpjCpf, SetorId, DataCadastro)" +
                                " VALUES  ('Bárbara Pacheco','barbara@gmail.com', '85660000','ADMIN','46999229846','Rua tal mm','bairro tal','Francisco Beltrão','ap 02','08692354945', 1,'20120618 10:34:09 AM')");
            migrationBuilder.Sql("INSERT INTO Funcionario (Nome, Email, Cep, TipoUsuario, Telefone, Rua, Bairro, Cidade, Complemento, CnpjCpf, SetorId, DataCadastro)" +
                                " VALUES  ('Sara Vendramini','MICHEL@gmail.com', '8566000','GEREN','46999229846','Rua tal mm','bairro tal','Francisco Beltrão','complementooo','08692354945', 3,'20120618 10:34:09 AM')");
            migrationBuilder.Sql("INSERT INTO Funcionario (Nome, Email, Cep, TipoUsuario, Telefone, Rua, Bairro, Cidade, Complemento, CnpjCpf, SetorId, DataCadastro)" +
                                " VALUES  ('Michel','SARA@gmail.com', '8566000','FUNC','46999229846','Rua tal mm','são francisco','Francisco Beltrão','casa dos fundos','08692354945', 2,'20120618 10:34:09 AM')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM EMPRESA");
            migrationBuilder.Sql("DELETE FROM SETOR");
            migrationBuilder.Sql("DELETE FROM FUNCIONARIO");

        }
    }
}
