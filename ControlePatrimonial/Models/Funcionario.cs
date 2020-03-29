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
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe o nome fantasia da empresa")]
        public string Nome { get; set; }

        [StringLength(100)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Informe o e-mail do funcionário")]
        public string Email { get; set; }

        [StringLength(20)]
        [Display(Name = "Cep")]
        [Required(ErrorMessage = "Informe o CEP do funcionário")]
        public string Cep { get; set; }

        [StringLength(15)]
        [Display(Name = "TipoUsuario")]
        [Required(ErrorMessage = "Informe o tipo do funcionário")]
        public string TipoUsuario { get; set; }

        [StringLength(15)]
        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Informe o telefone do funcionário")]
        public string Telefone { get; set; }

        [StringLength(50)]
        [Display(Name = "Rua")]
        [Required(ErrorMessage = "Informe a rua do funcionário")]
        public string Rua { get; set; }

        [StringLength(50)]
        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "Informe o barrio do funcionário")]
        public string Bairro { get; set; }

        [StringLength(50)]
        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "Informe a cidade do funcionário")]
        public string Cidade { get; set; }

        [StringLength(100)]
        public string Complemento { get; set; }

        [StringLength(14)]
        [Display(Name = "CnpjCpf")]
        [Required(ErrorMessage = "Informe o CPF do funcionário")]
        public string CnpjCpf { get; set; }

        [Display(Name = "CnpjCpf")]
        [Required(ErrorMessage = "Informe a data de cadastro")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "SetorId")]
        [Required(ErrorMessage = "Informe o setor do funcionário")]
        public int SetorId { get; set; }

        public virtual Setor Setor { get; set; }
    }
}
