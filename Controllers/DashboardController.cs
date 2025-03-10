using AlquilerDeLibro.Data;
using AlquilerDeLibro.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace AlquilerDeLibro.Controllers
{
    public class DashboardController : Controller
    {
        private readonly AppDbContext _contex;
        //Constructor de Inyeccion de dependencia 
        public DashboardController(AppDbContext contex)
        {
            _contex = contex;
        }




        
        public async Task  <IActionResult> ListLibro()
        {
            ViewBag.OcultarMenu = true;
            return View(await _contex.Libros.ToListAsync());
            
        }

        //ver los libros alquilados
        public async Task<IActionResult> AlquiladoLibro()
        {
            ViewBag.OcultarMenu = true;
            return View(_contex.Alquileres);
        }



     



            //// GET: DashboardController/Details/5
            //public ActionResult Details(int id)
            //{
            //    return View();
            //}

            //// GET: DashboardController/Create
            //public ActionResult Create()
            //{
            //    return View();
            //}

            //// POST: DashboardController/Create
            //[HttpPost]
            //[ValidateAntiForgeryToken]
            //public ActionResult Create(IFormCollection collection)
            //{
            //    try
            //    {
            //        return RedirectToAction(nameof(Index));
            //    }
            //    catch
            //    {
            //        return View();
            //    }
            //}

            //// GET: DashboardController/Edit/5
            //public ActionResult Edit(int id)
            //{
            //    return View();
            //}

            //// POST: DashboardController/Edit/5
            //[HttpPost]
            //[ValidateAntiForgeryToken]
            //public ActionResult Edit(int id, IFormCollection collection)
            //{
            //    try
            //    {
            //        return RedirectToAction(nameof(Index));
            //    }
            //    catch
            //    {
            //        return View();
            //    }
            //}

            //// GET: DashboardController/Delete/5
            //public ActionResult Delete(int id)
            //{
            //    return View();
            //}

            //// POST: DashboardController/Delete/5
            //[HttpPost]
            //[ValidateAntiForgeryToken]
            //public ActionResult Delete(int id, IFormCollection collection)
            //{
            //    try
            //    {
            //        return RedirectToAction(nameof(Index));
            //    }
            //    catch
            //    {
            //        return View();
            //    }
            //}
        }
}
