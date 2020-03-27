using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ControlePatrimonial.Repositories;
using ControlePatrimonial.ViewModel;
using ControlePatrimonial.Models;

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
            //var empresas = _empresaRepository.Empresas;
            var empresaViewModel = new EmpresaViewModel();
            empresaViewModel.Empresas = _empresaRepository.Empresas;

            return View(empresaViewModel);
        }
                
        public IActionResult Empresa_Detalhes(int idEmpresa)
        {
            var empresa = _empresaRepository.Empresas.FirstOrDefault(e => e.IdEmpresa == idEmpresa);

            if (empresa == null)
            {
                return View("~/Views/Shared/Error.cshtml");
            }

            return View(empresa);
        }

        public IActionResult Empresa_Cadastro()
        {
            var empresaViewModel = new EmpresaViewModel();
            empresaViewModel.empresa = _empresaRepository.criarEmpresa();

            return View();
        }

        [HttpPost]
        public IActionResult Empresa_Salvar(Models.Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                _empresaRepository.salvarEmpresa(empresa);
                return RedirectToAction("Empresa_Lista"); 
            }


            return View("~/Views/Empresa/Empresa_Lista.cshtml");
        }

    }
}
