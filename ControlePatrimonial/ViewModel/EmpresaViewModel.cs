using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlePatrimonial.Models;

namespace ControlePatrimonial.ViewModel
{
    public class EmpresaViewModel
    {
        public IEnumerable<Empresa> Empresas { get; set; }
        public Empresa empresa { get; set; }

    }
}
