using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ControlePatrimonial.Repositories;
using ControlePatrimonial.ViewModel;

namespace ControlePatrimonial.Controllers
{
    public class SetorController : Controller
    {
        private readonly ISetorRepository _setorRepository;
        private IEmpresaRepository _empresaRepository;

        public SetorController(ISetorRepository setorRepository, IEmpresaRepository empresaRepository)
        {
            _setorRepository = setorRepository;
            _empresaRepository = empresaRepository;
        }

        public IActionResult Setor_Lista()
        {
            ViewBag.Funcionario = "Setor";
            ViewData["Empresa"] = "Empresa";

            //var setores = _setorRepository.Setores;
            var setorListaViewModel = new SetorListaViewModel();
            setorListaViewModel.Setores = _setorRepository.Setores;
            setorListaViewModel.Empresas = _empresaRepository.Empresas;

            return View(setorListaViewModel);
        }

        public ActionResult Setor_Cadastro()
        {
            return View();
        }

        public IActionResult Setor_Detalhes(int idSetor)
        {
            var setor = _setorRepository.Setores.FirstOrDefault(s => s.IdSetor == idSetor);

            if (setor == null)
            {
                return View("~/Views/Shared/Error.cshtml");
            }

            return View(setor);
        }

    }
}