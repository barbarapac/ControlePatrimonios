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
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly ISetorRepository _setorRepository;

        public FuncionarioController(IFuncionarioRepository funcionarioRepository, ISetorRepository setorRepository)
        {
            _funcionarioRepository = funcionarioRepository;
            _setorRepository = setorRepository;
        }

        public IActionResult Funcionario_Lista()
        {
            ViewBag.Funcionario = "Funcionario";
            ViewData["Setor"] = "Setor";

            //var funcionarios = _funcionarioRepository.Funcionarios;
            var funcionarioViewModel = new FuncionarioViewModel();
            funcionarioViewModel.Funcionairos = _funcionarioRepository.Funcionarios;
            funcionarioViewModel.Setores = _setorRepository.Setores;

            return View(funcionarioViewModel);
        }

        public IActionResult Funcionario_Detalhes(int idFuncionario)
        {
            var funcionario = _funcionarioRepository.Funcionarios.FirstOrDefault(e => e.IdFuncionario == idFuncionario);

            if (funcionario == null)
            {
                return View("~/Views/Shared/Error.cshtml");
            }

            return View(funcionario);
        }

        public ActionResult Funcionario_Cadastro()
        {
            ViewBag.Funcionario = "Funcionario";
            ViewBag.Setores = _setorRepository.Setores.Select(e => new SelectListItem() { Text = e.Nome, Value = e.IdSetor.ToString() }).ToList();


            var funcionarioViewModel = new FuncionarioViewModel();
            funcionarioViewModel.funcionario = _funcionarioRepository.criarFuncionario();
            funcionarioViewModel.Setores = _setorRepository.Setores;

            return View();
        }

        [HttpPost]
        public IActionResult Funcionario_Salvar(Models.Funcionario funcionario)
        {
            _funcionarioRepository.salvarFuncionario(funcionario);
            return RedirectToAction("Funcionario_Lista");
        }

        public IActionResult Funcionario_Excluir(int idFuncionairo)
        {
            Models.Funcionario funcionario = _funcionarioRepository.GetFuncionarioById(idFuncionairo);

            _funcionarioRepository.excluirFuncionario(funcionario);
            return RedirectToAction("Funcionario_Lista");
        }
    }
}