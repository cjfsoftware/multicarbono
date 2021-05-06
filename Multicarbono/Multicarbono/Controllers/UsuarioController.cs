using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multicarbono.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Controllers
{
    public class UsuarioController : Controller
    {

        private UsuarioRepository _usuarioRepo;
        
        public UsuarioController(UsuarioRepository usuarioRepo)
        {
            _usuarioRepo = usuarioRepo;
        }

        // GET: UsuarioController
        public ActionResult Index()
        {
            var model = _usuarioRepo.ListUsuario();
            return PartialView("~/Views/Usuario/Index.cshtml", model);
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuarioController/Create
        public ActionResult CadastroUsuario()
        {
            //return PartialView("CadastroUsuario");
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
