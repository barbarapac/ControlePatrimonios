using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ControlePatrimonial.Repositories;

namespace ControlePatrimonial.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioController(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public IActionResult Funcionario_Lista()
        {
            var funcionarios = _funcionarioRepository.Funcionarios;
            return View(funcionarios);
        }

        public ActionResult Funcionario_Cadastro()
        {
            return View();
        }
       
    }
}