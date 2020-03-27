using ControlePatrimonial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlePatrimonial.Context;
using Microsoft.EntityFrameworkCore;

namespace ControlePatrimonial.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly AppDBContext _context;

        public FuncionarioRepository(AppDBContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Funcionario> Funcionarios => _context.Funcionario.Include(s => s.Setor) ;

        public Funcionario GetFuncionarioById(int FuncionarioId)
        {
            return _context.Funcionario.FirstOrDefault(f => f.IdFuncionario == FuncionarioId);
        }

        public Funcionario criarFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            return funcionario;
        }

        public void salvarFuncionario(Funcionario funcionario)
        {
            _context.Funcionario.Add(funcionario);
            _context.SaveChanges();
        }
        public void excluirFuncionario(Funcionario funcionario)
        {
            _context.Funcionario.Remove(funcionario);
            _context.SaveChanges();
        }
    }
}
