using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ControlePatrimonial.Models
{
    public class Setor
    {
        [Key]
        public int IdSetor { get; set; }
        [StringLength(100)]

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe o nome do setor")]
        public string Nome { get; set; }
        [StringLength(50)]

        [Display(Name = "Localizacao")]
        [Required(ErrorMessage = "Informe a localização do setor")]
        public string Localizacao { get; set; }

        [Display(Name = "DataCadastro")]
        [Required(ErrorMessage = "Informe a data de cadastro")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "EmpresaId")]
        [Required(ErrorMessage = "Informe a empresa do setor")]
        public int EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
        public List<Funcionario> Funcionario { get; set; }
    }
}
