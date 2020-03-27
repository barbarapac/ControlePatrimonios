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
            var funcionarioListaViewModel = new FuncionarioListaViewModel();
            funcionarioListaViewModel.Funcionairos = _funcionarioRepository.Funcionarios;
            funcionarioListaViewModel.Setores = _setorRepository.Setores;

            return View(funcionarioListaViewModel);
        }

        public ActionResult Funcionario_Cadastro()
        {
            return View();
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
    }
}