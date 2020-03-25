using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControlePatrimonial.Controllers
{
    public class SetorController : Controller
    {
        // GET: Setor
        public ActionResult CadSetor()
        {
            return View();
        }

        // GET: Setor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Setor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Setor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(CadSetor));
            }
            catch
            {
                return View();
            }
        }

        // GET: Setor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Setor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(CadSetor));
            }
            catch
            {
                return View();
            }
        }

        // GET: Setor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Setor/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(CadSetor));
            }
            catch
            {
                return View();
            }
        }
    }
}