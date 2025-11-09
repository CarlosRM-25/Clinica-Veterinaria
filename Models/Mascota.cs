using System.ComponentModel.DataAnnotations;

namespace Clínica_Veterinaria.Models
{
    public enum Especie
    {
        [Display(Name = "Seleccione...")]
        None = 0,
        Perro,
        Gato,
        Ave,
        Otro
    }

    public class Mascota
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la mascota es obligatorio.")]
        [MinLength(2, ErrorMessage = "El nombre debe tener al menos 2 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Seleccione la especie.")]
        [EnumDataType(typeof(Especie), ErrorMessage = "Especie inválida.")]
        [Range(1, int.MaxValue, ErrorMessage = "Seleccione una especie válida.")]
        public Especie Especie { get; set; }

        [Required(ErrorMessage = "La raza es obligatoria.")]
        public string Raza { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria.")]
        [Range(0, 25, ErrorMessage = "La edad debe estar entre 0 y 25 años.")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El nombre del dueño es obligatorio.")]
        [MinLength(3, ErrorMessage = "El nombre del dueño debe tener al menos 3 caracteres.")]
        public string Nombre_Dueño { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "El teléfono debe tener el formato 809-555-1234.")]
        public string Telefono_Dueño { get; set; }

        [Required(ErrorMessage = "La fecha de ingreso es obligatoria.")]
        [DataType(DataType.Date)]
        [NotFutureDate(ErrorMessage = "La fecha de ingreso no puede ser futura.")]
        public DateTime Fecha_Ingreso { get; set; }
    }
}
