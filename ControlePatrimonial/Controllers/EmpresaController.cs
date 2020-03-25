using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ControlePatrimonial.Repositories;

namespace ControlePatrimonial.Controllers.Empresa
{
    public class EmpresaController : Controller
    {
        private readonly IEmpresaRepository _empresaRepository;

        public EmpresaController(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public IActionResult Empresa_Lista()
        {
            var empresas = _empresaRepository.Empresas;
            return View(empresas);
        }
                
        public IActionResult Empresa_Cadastro()
        {
            //var empresas = db.Empresas.ToList();

            return View();
        }
    }
}
