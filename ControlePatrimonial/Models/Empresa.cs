using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ControlePatrimonial.Models
{
    public class Empresa
    {
        [Key]
        public int IdEmpresa { get; set; }
        [StringLength(100)]
        public string NomeFantasia { get; set; }
        [StringLength(14)]
        public string CnpjCpf { get; set; }
        [StringLength(20)]
        public string Cep { get; set; }
        [StringLength(100)]
        public string RazaoSocial { get; set; }
        [StringLength(15)]
        public string Telefone { get; set; }
        [StringLength(50)]
        public string Rua { get; set; }
        [StringLength(50)]
        public string Bairro { get; set; }
        [StringLength(50)]
        public string Cidade { get; set; }
        [StringLength(10)]
        public string Numero { get; set; }
        [StringLength(100)]
        public string Complemento { get; set; }
        [StringLength(10)]
        public char Tipo { get; set; }
        public DateTime DataCadastro { get; set; }        
        public List<Setor> Setores { get; set; }
    }
}
