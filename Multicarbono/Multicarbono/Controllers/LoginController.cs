using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multicarbono.Exceptions;
using Multicarbono.Models.Login;
using Multicarbono.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Controllers
{
    public class LoginController : Controller
    {
        private LoginRepository _login;
        private UsuarioRepository _usuarioRepository;

        public LoginController(LoginRepository login, UsuarioRepository usuarioRepository) {
            _login = login;
            _usuarioRepository = usuarioRepository;
    }
        
        // GET: LoginController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
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

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
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

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
        [HttpPost]
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


        [HttpPost]
        [AllowAnonymous]
        public ActionResult DoLogin(LoginViewModel loginModel)
        {
            string login = _login.ValidarLogin(loginModel.User, loginModel.Password);
            try
            {
                Usuario usuario = _usuarioRepository.UsuarioByLogin(loginModel.User);

                if (login == "OK")
                {
                    HttpContext.Session.SetString("user_id", usuario.IdUsuario.ToString());
                    HttpContext.Session.SetString("access_grant_type", usuario.NivelAcesso.ToString());

                    return View("Base");
                }
                else
                    return PartialView("ModalLoginError");
            }
            catch (ResourceNotFoundException)
            {
                return PartialView("ModalLoginError");
            }
        }
    }
}
