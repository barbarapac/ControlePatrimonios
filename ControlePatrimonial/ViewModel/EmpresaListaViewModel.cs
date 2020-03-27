using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlePatrimonial.Models;

namespace ControlePatrimonial.ViewModel
{
    public class EmpresaListaViewModel
    {
        public IEnumerable<Empresa> Empresas { get; set; }
    }
}
