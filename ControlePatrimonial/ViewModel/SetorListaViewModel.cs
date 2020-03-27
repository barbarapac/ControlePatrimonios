using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlePatrimonial.Models;

namespace ControlePatrimonial.ViewModel
{
    public class SetorListaViewModel
    {
        public IEnumerable<Setor> Setores { get; set; }
        public IEnumerable<Empresa> Empresas { get; set; }
    }
}
