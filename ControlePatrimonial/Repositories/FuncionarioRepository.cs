using ControlePatrimonial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlePatrimonial.Context;

namespace ControlePatrimonial.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly AppDBContext _context;

        public FuncionarioRepository(AppDBContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Funcionario> Funcionarios => _context.Funcionario;

        public Funcionario GetFuncionarioById(int FuncionarioId)
        {
            return _context.Funcionario.FirstOrDefault(f => f.IdFuncionario == FuncionarioId);
        }
    }
}
