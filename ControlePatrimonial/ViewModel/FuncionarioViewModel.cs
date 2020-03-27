using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlePatrimonial.Models;

namespace ControlePatrimonial.ViewModel
{
    public class FuncionarioViewModel
    {
        public IEnumerable<Funcionario> Funcionairos { get; set; }
        public IEnumerable<Setor> Setores { get; set; }
    }
}
