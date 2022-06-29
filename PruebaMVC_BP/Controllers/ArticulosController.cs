using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

using ORM;
using ORM.Entities;

namespace PruebaMVC_BP.Controllers
{
    public class ArticulosController : Controller
    {
        // Get para listar la informacion en la vista
        public ActionResult Index()
        {
            try
            {
                using (BusinessProDBContext ctx = new BusinessProDBContext())
                {
                    ViewBag.Articulos = ctx.Articulos.Include("IdProveedorNavigation").ToList();
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
            using (BusinessProDBContext ctx = new BusinessProDBContext())
            {
                ViewBag.Proveedores = ctx.Proveedores.ToList();
            }

            return View();
        }

        // Post para enviar a guardar los registros
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Articulos arti)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                using (BusinessProDBContext ctx = new BusinessProDBContext())
                {

                    ctx.Articulos.Add(arti);
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
        public ActionResult Edit(int IdArticulo)
        {
            Articulos articulo = new Articulos();

            BusinessProDBContext ctx = new BusinessProDBContext();

            ViewBag.Proveedores = ctx.Proveedores.ToList(); // cargara la lista al combobox

            articulo = ctx.Articulos.ToList()
                .FirstOrDefault(a => a.IdArticulo == IdArticulo);

            if (articulo == null)
            {
                return NotFound();
            }
            else
            {
                return View(articulo);
            }
        }

        // Post para enviar a guardar los datos modificados
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Articulos arti)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                using (BusinessProDBContext ctx = new BusinessProDBContext())
                {
                    ctx.actualizarArticulos(arti);
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
            Articulos articulo = new Articulos();
            BusinessProDBContext ctx = new BusinessProDBContext();

            articulo = ctx.Articulos.ToList()
                .FirstOrDefault(a => a.IdArticulo == Id);

            if (articulo == null)
            {
                return NotFound();
            }
            else
            {
                ctx.Articulos.Remove(articulo);
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
