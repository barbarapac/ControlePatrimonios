﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ControlePatrimonial.Models
{
    public class Setor
    {
        [Key]
        public int IdSetor { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(50)]
        public string Localizacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual List<Funcionario> Funcionario { get; set; }
    }
}
