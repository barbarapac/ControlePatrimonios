using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlePatrimonial.Models;

namespace ControlePatrimonial.Repositories
{
    public interface IFuncionarioRepository
    {
        IEnumerable<Funcionario> Funcionarios { get; }
        Funcionario GetFuncionarioById(int FuncionarioId);
        public Funcionario criarFuncionario();
        public void salvarFuncionario(Funcionario funcionario);
    }
}
