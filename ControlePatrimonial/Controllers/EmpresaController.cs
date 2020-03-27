using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ControlePatrimonial.Repositories;
using ControlePatrimonial.ViewModel;

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
            var empresaListaViewModel = new EmpresaListaViewModel();
            empresaListaViewModel.Empresas = _empresaRepository.Empresas;

            return View(empresaListaViewModel);
        }
                
        public IActionResult Empresa_Cadastro(int idEmpresa, bool isEdicao)
        {
                var empresa = _empresaRepository.Empresas.FirstOrDefault(e => e.IdEmpresa == idEmpresa);

               /* if (empresa == null)
                {
                    return View("~/Views/Shared/Error.cshtml");
                }*/
            return View(empresa);
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
    }
}
