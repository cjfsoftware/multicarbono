﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multicarbono.Models.ItemNota;
using Multicarbono.Models.ItemPedido;
using Multicarbono.Models.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Multicarbono.Controllers
{
    public class ItemNotaController : Controller
    {
        private ItemNotaRepository _itemNotaRepo;

        public ItemNotaController(ItemNotaRepository itemNotaRepo)
        {
            _itemNotaRepo = itemNotaRepo;
        }

        public ActionResult CadastroItemNota()
        {
            return PartialView("_cadastroItemNotaPartial");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroItemNota(ItemNota itemNota)
        {
            _itemNotaRepo.IncludeItemNota(itemNota);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int idItemNota)
        {
            var model = _itemNotaRepo.ItemNotaById(idItemNota);
            return PartialView("_alterarItemNotaPartial", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idItemNota, ItemNota itemNota)
        {
            try
            {
                _itemNotaRepo.UpdateItemNota(itemNota);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int idItemNota)
        {
            var model = _itemNotaRepo.ItemNotaById(idItemNota);
            return PartialView("modalConfirmDeleteItemNota", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int idItemNota, ItemNota itemNota)
        {
            try
            {
                _itemNotaRepo.DeleteItemNota(itemNota.IdItemNF);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}