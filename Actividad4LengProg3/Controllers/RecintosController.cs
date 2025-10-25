using Actividad4LengProg3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad4LengProg3.Controllers
{
    public class RecintosController : Controller
    {
        private static List<RecintoViewModel> listaRecintos = new List<RecintoViewModel>();

        public ActionResult Index()
        {
            return View(listaRecintos);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RecintoViewModel model)
        {
            if (ModelState.IsValid)
            {
                listaRecintos.Add(model);
                TempData["Mensaje"] = "Recinto agregado correctamente.";
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var recinto = listaRecintos.FirstOrDefault(r => r.Codigo == id);
            if (recinto == null)
                return NotFound();

            return View(recinto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RecintoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var recinto = listaRecintos.FirstOrDefault(r => r.Codigo == model.Codigo);
                if (recinto != null)
                {
                    recinto.Nombre = model.Nombre;
                    recinto.Direccion = model.Direccion;
                    TempData["Mensaje"] = "Recinto actualizado correctamente.";
                }
                return RedirectToAction("Index");
            }

            return View(model);
        }
        public ActionResult Delete(int id)
        {
            var recinto = listaRecintos.FirstOrDefault(r => r.Codigo == id);
            if (recinto == null)
                return NotFound();

            listaRecintos.Remove(recinto);
            TempData["Mensaje"] = "Recinto eliminado correctamente.";

            return RedirectToAction("Index");
        }
    }
}