using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControlePatrimonial.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult CadFuncionario()
        {
            return View();
        }

        // GET: Funcionario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Funcionario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funcionario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(CadFuncionario));
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Funcionario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(CadFuncionario));
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Funcionario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(CadFuncionario));
            }
            catch
            {
                return View();
            }
        }
    }
}