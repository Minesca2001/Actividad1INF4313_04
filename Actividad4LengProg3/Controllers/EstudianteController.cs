using Actividad4LengProg3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad4LengProg3.Controllers
{
    public class EstudianteController : Controller
    {
        private static List<EstudianteViewModel> estudiantes = new List<EstudianteViewModel>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(EstudianteViewModel estudiante)
        {
            if (!ModelState.IsValid)
                return View("Index", estudiante);

            if (estudiantes.Any(e => e.Matricula == estudiante.Matricula))
            {
                ViewBag.Mensaje = "La matrícula ya existe.";
                return View("Index", estudiante);
            }

            estudiantes.Add(estudiante);
            ViewBag.Mensaje = "Estudiante registrado correctamente.";
            return RedirectToAction("Lista");
        }

        public IActionResult Lista()
        {
            return View(estudiantes);
        }

        public IActionResult Editar(string matricula)
        {
            var estudiante = estudiantes.FirstOrDefault(e => e.Matricula == matricula);
            if (estudiante == null)
                return NotFound();

            return View(estudiante);
        }

        [HttpPost]
        public IActionResult Editar(EstudianteViewModel estudiante)
        {
            var existente = estudiantes.FirstOrDefault(e => e.Matricula == estudiante.Matricula);
            if (existente == null)
                return NotFound();

            if (!ModelState.IsValid)
                return View(estudiante);

            estudiantes.Remove(existente);
            estudiantes.Add(estudiante);
            return RedirectToAction("Lista");
        }

        public IActionResult Eliminar(string matricula)
        {
            var estudiante = estudiantes.FirstOrDefault(e => e.Matricula == matricula);
            if (estudiante != null)
                estudiantes.Remove(estudiante);

            return RedirectToAction("Lista");
        }
    }
}
