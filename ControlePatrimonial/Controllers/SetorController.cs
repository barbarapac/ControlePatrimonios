﻿using System;
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
            try
            {
                ViewBag.Setor = "Setor";
                ViewData["Empresa"] = "Empresa";

                //var setores = _setorRepository.Setores;
                var setorViewModel = new SetorViewModel();
                setorViewModel.Setores = _setorRepository.Setores;
                setorViewModel.Empresas = _empresaRepository.Empresas;

                return View(setorViewModel);
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        public ActionResult Setor_Cadastro()
        {
            try
            {
                ViewBag.Setor = "Setor";
                ViewBag.Empresas = _empresaRepository.Empresas.Select(e => new SelectListItem() { Text = e.RazaoSocial, Value=e.IdEmpresa.ToString() }).ToList();

                var setorViewModel = new SetorViewModel();
                setorViewModel.setor = _setorRepository.criarSetor();

                return View();

            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        [HttpPost]
        public IActionResult Setor_Salvar(Models.Setor setor)
        {
            try
            {
                _setorRepository.salvarSetor(setor, false);
                return RedirectToAction("Setor_Lista");
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            
        }

        public IActionResult Setor_Detalhes(int idSetor)
        {
            try
            {                
                var setor = _setorRepository.Setores.FirstOrDefault(s => s.IdSetor == idSetor);

                return View(setor);
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        public IActionResult Setor_Excluir(int idSetor)
        {
            try
            {
                Models.Setor setor = _setorRepository.GetSetorById(idSetor);

                _setorRepository.excluirSetor(setor);
                return RedirectToAction("Setor_Lista");

            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }

        }
        public IActionResult Setor_Edicao(int idSetor)
        {
            try
            {
                var setorViewModel = new SetorViewModel();
                ViewBag.Setor = "Setor";
                ViewBag.Empresas = _empresaRepository.Empresas.Select(e => new SelectListItem() { Text = e.RazaoSocial, Value = e.IdEmpresa.ToString() }).ToList();

                Models.Setor setor = _setorRepository.GetSetorById(idSetor);
                setorViewModel.setor = setor;
                setorViewModel.Empresas = _empresaRepository.Empresas;

                return View(setorViewModel);
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        [HttpPost]
        public IActionResult Setor_SalvarEdicao(SetorViewModel setorViewMode)
        {
            try
            {
                Models.Setor setor = setorViewMode.setor;
                _setorRepository.salvarSetor(setor, true);
                return RedirectToAction("Setor_Lista");
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }
    }
}