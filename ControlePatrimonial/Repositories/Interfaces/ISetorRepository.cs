using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlePatrimonial.Models;

namespace ControlePatrimonial.Repositories
{
    public interface ISetorRepository
    {
        IEnumerable <Setor> Setores { get; }
        Setor GetSetorById(int setorId);
        public Setor criarSetor();
        public void salvarSetor(Setor setor);
        void excluirSetor(Setor setor);
    }
}
