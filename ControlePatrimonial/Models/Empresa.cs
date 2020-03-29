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
        [Display(Name = "NomeFantasia")]
        [Required(ErrorMessage ="Informe o nome fantasia da empresa")]
        public string NomeFantasia { get; set; }

        [StringLength(14)]
        [Display(Name = "CnpjCpf")]
        [Required(ErrorMessage = "Informe o CNPJ da empresa")]
        public string CnpjCpf { get; set; }

        [StringLength(20)]
        [Display(Name = "Cep")]
        [Required(ErrorMessage = "Informe o CEP da empresa")]
        public string Cep { get; set; }

        [StringLength(100)]
        [Display(Name = "RazaoSocial")]
        [Required(ErrorMessage = "Informe a razão social da empresa")]
        public string RazaoSocial { get; set; }

        [StringLength(15)]
        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Informe a telefone da empresa")]
        public string Telefone { get; set; }

        [StringLength(50)]
        [Display(Name = "Rua")]
        [Required(ErrorMessage = "Informe a rua  da empresa")]
        public string Rua { get; set; }

        [StringLength(50)]
        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "Informe o bairro da empresa")]
        public string Bairro { get; set; }

        [StringLength(50)]
        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "Informe a cidade da empresa")]
        public string Cidade { get; set; }

        [StringLength(10)]
        [Display(Name = "Numero")]
        [Required(ErrorMessage = "Informe número da empresa")]
        public string Numero { get; set; }

        [StringLength(100)]
        public string Complemento { get; set; }

        [StringLength(15)]
        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "Informe o tipo da empresa")]
        public string Tipo { get; set; }


        [Required(ErrorMessage = "Informe a data de cadastro empresa")]
        [Display(Name = "DataCadastro")]
        public DateTime DataCadastro { get; set; }

        public List<Setor> Setores { get; set; }
    }
}
