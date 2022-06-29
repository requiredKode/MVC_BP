using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Microsoft.AspNetCore.Http;

using ORM;
using ORM.Entities;

namespace PruebaMVC_BP.Controllers
{
    public class ProveedoresController : Controller
    {
        // Get para listar la informacion en la vista
        public ActionResult Index()
        {
            try
            {
                using (BusinessProDBContext ctx = new BusinessProDBContext())
                {
                    ViewBag.Proveedores = ctx.Proveedores.ToList();
                    return View();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // Get de la vista de creacion de nuevo registro
        public ActionResult Create()
        {
            return View();
        }

        // Post para enviar a guardar los registros
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Proveedores prov)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                using (BusinessProDBContext ctx = new BusinessProDBContext())
                {
                    ctx.Proveedores.Add(prov);
                    ctx.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Get para obtener los datos a editar y cargarlos en la vista
        [HttpGet]
        public ActionResult Edit(int IdProveedor)
        {
            Proveedores proveedor = new Proveedores();

            BusinessProDBContext ctx = new BusinessProDBContext();

            proveedor = ctx.Proveedores.ToList()
                .FirstOrDefault(a => a.IdProveedor == IdProveedor);

            if (proveedor == null)
            {
                return NotFound();
            }
            else
            {
                return View(proveedor);
            }
        }

        // Post para enviar a guardar los datos modificados
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Proveedores provee)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                using (BusinessProDBContext ctx = new BusinessProDBContext())
                {
                    ctx.actualizarProveedores(provee);
                    ctx.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Get para obtener el id del registro a eliminar
        public ActionResult Delete(int Id)
        {
            Proveedores proveedor = new Proveedores();
            BusinessProDBContext ctx = new BusinessProDBContext();

            proveedor = ctx.Proveedores.ToList()
                .FirstOrDefault(a => a.IdProveedor == Id);

            if (proveedor == null)
            {
                return NotFound();
            }
            else
            {
                ctx.Proveedores.Remove(proveedor);
                ctx.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
        }

        // Post que efectua los cambios al eliminar el dato
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
