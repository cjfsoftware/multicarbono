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
            //var model = _usuarioRepo.ListUsuario();
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroUsuario(Usuario usuario)
        {
            _usuarioRepo.IncludeUsuario(usuario);
            return RedirectToAction("Index");
        }


        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int idUsuario)
        {

            var model = _usuarioRepo.UsuarioById(idUsuario);
            return PartialView("AlterarUsuario", model);
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idUsuario, Usuario usuario)
        {
            try
            {
                _usuarioRepo.UpdateUsuario(usuario);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //return View();
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int idUsuario)
        {
            var model = _usuarioRepo.UsuarioById(idUsuario);
            return PartialView("modalConfirmDelete", model);
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Usuario usuario)
        {
            try
            {
                _usuarioRepo.DeleteUsuario(usuario.IdUsuario);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
