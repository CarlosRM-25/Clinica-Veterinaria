using Clínica_Veterinaria.Models;
using System.Collections.Generic;
using System.Linq;

namespace Clínica_Veterinaria.Data
{
    public class MascotasRepo
    {
        private static readonly List<Mascota> _mascotas = new();
        private static int _nextId = 1;

        public static IReadOnlyList<Mascota> ObtenerTodos() => _mascotas.AsReadOnly();

        public void AgregarMascota(Mascota m)
        {
            m.Id = _nextId++;
            _mascotas.Add(m);
        }

        public IEnumerable<Mascota> ObtenerMascotas()
        {
            // devolver copia para evitar modificaciones externas
            return _mascotas.ToList();
        }
    }
}
