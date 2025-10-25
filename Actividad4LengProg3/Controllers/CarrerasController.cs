using Actividad4LengProg3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad4LengProg3.Controllers
{
    public class CarrerasController : Controller
    {
        private static List<CarreraViewModel> listaCarreras = new List<CarreraViewModel>();

        public ActionResult Index()
        {
            return View(listaCarreras);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarreraViewModel model)
        {
            if (ModelState.IsValid)
            {
                listaCarreras.Add(model);
                TempData["Mensaje"] = "Carrera agregada correctamente.";
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var carrera = listaCarreras.FirstOrDefault(c => c.Codigo == id);
            if (carrera == null)
                return NotFound();

            return View(carrera);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CarreraViewModel model)
        {
            if (ModelState.IsValid)
            {
                var carrera = listaCarreras.FirstOrDefault(c => c.Codigo == model.Codigo);
                if (carrera != null)
                {
                    carrera.Nombre = model.Nombre;
                    carrera.CantidadCreditos = model.CantidadCreditos;
                    carrera.CantidadMaterias = model.CantidadMaterias;
                    TempData["Mensaje"] = "Carrera actualizada correctamente.";
                }
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var carrera = listaCarreras.FirstOrDefault(c => c.Codigo == id);
            if (carrera == null)
                return NotFound();

            listaCarreras.Remove(carrera);
            TempData["Mensaje"] = "Carrera eliminada correctamente.";

            return RedirectToAction("Index");
        }
    }
}