using System.ComponentModel.DataAnnotations;

namespace Clínica_Veterinaria.Models
{
    public class NotFutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null) return true; // [Required] se encarga si es nulo
            if (value is DateTime date)
            {
                return date.Date <= DateTime.Now.Date;
            }
            return false;
        }
    }
}
