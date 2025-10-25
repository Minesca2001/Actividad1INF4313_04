using System.ComponentModel.DataAnnotations;

namespace Actividad4LengProg3.Models
{
    public class RecintoViewModel
    {
        [Required(ErrorMessage = "El código es obligatorio.")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no debe exceder los 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La dirección es obligatoria.")]
        [StringLength(100, ErrorMessage = "La dirección no debe exceder los 100 caracteres.")]
        public string Direccion { get; set; }
    }
}