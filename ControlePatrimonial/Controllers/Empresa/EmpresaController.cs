using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ControlePatrimonial.Controllers.Empresa
{
    public class EmpresaController : Controller
    {
        
        public EmpresaController()
        {
            // cria conexão banco
            //db = new ProdutoDbContext()
        }

        // GET: /<controller>/
        public IActionResult CadEmpresa()
        {
            //var empresas = db.Empresas.ToList();

            return View();
        }
    }
}
