using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlePatrimonial.Models;

namespace ControlePatrimonial.Repositories
{
    public interface IEmpresaRepository
    {
        // Lista empresas;
        IEnumerable<Empresa> Empresas { get; }
        Empresa GetEmpresaById(int EmpresaId);
        void salvarEmpresa(Empresa empresa);
        void excluirEmpresa(Empresa empresa);
        Empresa criarEmpresa();
    }
}
