using ControlePatrimonial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlePatrimonial.Context;
using Microsoft.EntityFrameworkCore;

namespace ControlePatrimonial.Repositories
{
    public class SetorRepository : ISetorRepository
    {
        private readonly AppDBContext _context;

        public SetorRepository(AppDBContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Setor> Setores => _context.Setor.Include(e => e.Empresa);

        public Setor GetSetorById(int setorId)
        {
            return _context.Setor.FirstOrDefault(s => s.IdSetor == setorId);
        }
        public Setor criarSetor()
        {
            Setor setor = new Setor();
            return setor;
        }

        public void salvarSetor(Setor setor)
        {
            _context.Setor.Add(setor);
            _context.SaveChanges();
        }

        public void excluirSetor(Setor setor)
        {
            _context.Setor.Remove(setor);
            _context.SaveChanges();
        }
    }
}
