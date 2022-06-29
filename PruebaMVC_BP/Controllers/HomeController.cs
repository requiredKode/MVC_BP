using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaMVC_BP.Models;
using System.Diagnostics;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using ORM;
using ORM.Entities;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace PruebaMVC_BP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Get para listar la informacion en la vista
        public IActionResult Index()
        {
            try
            {
                using (BusinessProDBContext ctx = new BusinessProDBContext())
                {
                    var Estado = "Activo";
                    var procedurelist = ctx.sp_lista_articulos_activos.FromSqlRaw("sp_lista_articulos_activos @p0", Estado).ToList();
                    ViewBag.ListaCombinada = procedurelist;
                    return View(ViewBag.ListaCombinada);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
