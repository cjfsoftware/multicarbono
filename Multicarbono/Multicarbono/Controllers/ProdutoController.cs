using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Multicarbono.Models;
using Multicarbono.Models.Produto;

namespace Multicarbono.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoRepository _produtoRepo;

        public ProdutoController(ProdutoRepository produtoRepo)
        {
            _produtoRepo = produtoRepo;
        }

        // GET: UsuarioController
        public ActionResult Index()
        {
            var model = _produtoRepo.ListProduto();
            return PartialView("~/Views/Produto/Index.cshtml", model);
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuarioController/Create
        public ActionResult CadastroProduto()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroProduto(int idProduto, Produto produto)
        {
            _produtoRepo.IncludeProduto(produto);
            return RedirectToAction("Index");
        }


        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int idProduto)
        {

            var model = _produtoRepo.ProdutoById(idProduto);
            return PartialView("AlterarProduto", model);
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idProduto, Produto produto)
        {
            try
            {
                _produtoRepo.UpdateProduto(produto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //return View();
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int idProduto)
        {
            var model = _produtoRepo.ProdutoById(idProduto);
            return PartialView("modalConfirmDelete", model);
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int idProduto, Produto produto)
        {
            try
            {
                _produtoRepo.DeleteProduto(idProduto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
