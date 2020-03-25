using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ControlePatrimonial.Models
{
    public class Funcionario
    {
        [Key]
        public int IdFuncionario { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(20)]
        public string Cep { get; set; }
        [StringLength(10)]
        public string TipoUsuario { get; set; }
        [StringLength(15)]
        public string Telefone { get; set; }
        [StringLength(50)]
        public string Rua { get; set; }
        [StringLength(50)]
        public string Bairro { get; set; }
        [StringLength(50)]
        public string Cidade { get; set; }
        [StringLength(100)]
        public string Complemento { get; set; }
        [StringLength(14)]
        public string CnpjCpf { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
