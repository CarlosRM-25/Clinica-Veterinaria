using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Clínica_Veterinaria.Data;
using Clínica_Veterinaria.Models;

namespace Clínica_Veterinaria.Controllers
{
    public class MacotasController1 : Controller
    {
        // GET: MacotasController1
        public IActionResult Index()
        {
            var mascotas = MascotasRepo.ObtenerTodos();
            return View(mascotas);
        }

        // GET: MacotasController1/Details/5
        public IActionResult Details(int id)
        {
            var mascota = MascotasRepo.ObtenerTodos().FirstOrDefault(m => m.Id == id);
            return View();
        }

        // GET: MacotasController1/Create
        public IActionResult Create()
        {

            return View(new Mascota());
        }

        // POST: MacotasController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
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

        // GET: MacotasController1/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: MacotasController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
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

        // GET: MacotasController1/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: MacotasController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
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
