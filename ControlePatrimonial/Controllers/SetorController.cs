using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ControlePatrimonial.Repositories;
using ControlePatrimonial.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            ViewBag.Setor = "Setor";
            ViewData["Empresa"] = "Empresa";

            //var setores = _setorRepository.Setores;
            var setorViewModel = new SetorViewModel();
            setorViewModel.Setores = _setorRepository.Setores;
            setorViewModel.Empresas = _empresaRepository.Empresas;

            return View(setorViewModel);
        }

        public ActionResult Setor_Cadastro()
        {
            ViewBag.Setor = "Setor";
            ViewBag.Empresas = _empresaRepository.Empresas.Select(e => new SelectListItem() { Text = e.RazaoSocial, Value=e.IdEmpresa.ToString() }).ToList();

            var setorViewModel = new SetorViewModel();
            setorViewModel.setor = _setorRepository.criarSetor();

            return View();
        }

        [HttpPost]
        public IActionResult Setor_Salvar(Models.Setor setor)
        {
            _setorRepository.salvarSetor(setor);
            return RedirectToAction("Setor_Lista");
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

        public IActionResult Setor_Excluir(int idSetor)
        {
            Models.Setor setor = _setorRepository.GetSetorById(idSetor);

            _setorRepository.excluirSetor(setor);
            return RedirectToAction("Setor_Lista");
        }

    }
}