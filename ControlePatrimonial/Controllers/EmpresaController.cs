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
            try
            {
                var empresaViewModel = new EmpresaViewModel();
                empresaViewModel.Empresas = _empresaRepository.Empresas;

                return View(empresaViewModel);
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }
                
        public IActionResult Empresa_Detalhes(int idEmpresa)
        {
            try
            {
                var empresa = _empresaRepository.Empresas.FirstOrDefault(e => e.IdEmpresa == idEmpresa);
                return View(empresa);
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        public IActionResult Empresa_Cadastro()
        {
            try
            {
                var empresaViewModel = new EmpresaViewModel();
                empresaViewModel.empresa = _empresaRepository.criarEmpresa();

                return View();
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        [HttpPost]
        public IActionResult Empresa_Salvar(Models.Empresa empresa)
        {
            try
            {
                _empresaRepository.salvarEmpresa(empresa, false);
                return RedirectToAction("Empresa_Lista"); 
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        public IActionResult Empresa_Excluir(int idEmpresa)
        {
            try
            {
                Models.Empresa empresa = _empresaRepository.GetEmpresaById(idEmpresa);

                _empresaRepository.excluirEmpresa(empresa);
                return RedirectToAction("Empresa_Lista");
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        public IActionResult Empresa_Edicao(int idEmpresa)
        {
            try
            {
                var empresaViewModel = new EmpresaViewModel();
                Models.Empresa empresa = _empresaRepository.GetEmpresaById(idEmpresa);
                empresaViewModel.empresa = empresa;

                return View(empresaViewModel);
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        [HttpPost]
        public IActionResult Empresa_SalvarEdicao(EmpresaViewModel empresaViewMode)
        {
            try
            {
                Models.Empresa empresa = empresaViewMode.empresa;
                _empresaRepository.salvarEmpresa(empresa, true);
                return RedirectToAction("Empresa_Lista");
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }
    }
}
