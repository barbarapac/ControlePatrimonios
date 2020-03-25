using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ControlePatrimonial.Repositories;

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
            var setores = _setorRepository.Setores;
            return View(setores);
        }

        public ActionResult Setor_Cadastro()
        {
            return View();
        }

    }
}