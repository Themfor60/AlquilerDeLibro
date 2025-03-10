using AlquilerDeLibro.Data;
using AlquilerDeLibro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AlquilerDeLibro.Controllers
{
    public class InicioController : Controller
    {
        
        private readonly AppDbContext _contex;
        //Constructor de Inyeccion de dependencia 
        public  InicioController(AppDbContext contex)
        {
            _contex = contex;
        }

        //Metodo para que el Usuario pueda ver el index
        [HttpGet]
        public  IActionResult Index()
        {
            return View();
        }


        //metodo para iniciar secion
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string Correo, string Contrasena)
        {
            var usuario = _contex.Usuarios
                .FirstOrDefault(u => u.Correo == Correo && u.Contrasena == Contrasena);

            if (usuario != null)
            {
                HttpContext.Session.SetString("UsuarioId", usuario.id_usuario.ToString());
                HttpContext.Session.SetString("UsuarioNombre", usuario.Nombre);
                return RedirectToAction(nameof(Dashboard));
            }
            else
            {
                ViewBag.ErrorMessage = "Usuario o contraseña incorrectos.";
                return View(nameof(Index));
            }
        }
        //Metodo para cerrar la seccion 
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(Index));
        }




        //Metodo para que desde la opcion quieres registrarse lo lleve al formulario de registrar
        [HttpGet]
        public IActionResult Registrarse() 
        {
            return View();
        }

        //Metodo para enviar el formulario de registro a la base de datos
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Registrarse(Usuario usuario)
        {
            if (ModelState.IsValid) 
            {
                _contex.Usuarios.Add(usuario);
                await _contex.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }


        //Metodo para ver el Dashboard
        [HttpGet]
        public IActionResult Dashboard() 
        {
            ViewBag.OcultarMenu = true;
            return View();  
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
