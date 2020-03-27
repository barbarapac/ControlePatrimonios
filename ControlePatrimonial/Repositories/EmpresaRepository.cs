using ControlePatrimonial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlePatrimonial.Context;
using Microsoft.EntityFrameworkCore;

namespace ControlePatrimonial.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly AppDBContext _context;

        public EmpresaRepository(AppDBContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Empresa> Empresas => _context.Empresa;

        public Empresa GetEmpresaById(int EmpresaId)
        {
            return _context.Empresa.FirstOrDefault(e => e.IdEmpresa == EmpresaId);
        }

        public Empresa criarEmpresa()
        {
            Empresa empresa = new Empresa();
            empresa.DataCadastro = DateTime.Now;

            return empresa;
        }
        public void salvarEmpresa(Empresa empresa)
        {
            _context.Empresa.Add(empresa);
            _context.SaveChanges();
        }

        public void excluirEmpresa(Empresa empresa)
        {
            _context.Empresa.Remove(empresa);
            _context.SaveChanges();
        }
    }
}
