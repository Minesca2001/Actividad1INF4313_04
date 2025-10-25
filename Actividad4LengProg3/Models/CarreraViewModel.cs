using System.ComponentModel.DataAnnotations;

namespace Actividad4LengProg3.Models
{
    public class CarreraViewModel
    {
        [Required(ErrorMessage = "El código es obligatorio.")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La cantidad de créditos es obligatoria.")]
        public int CantidadCreditos { get; set; }

        [Required(ErrorMessage = "La cantidad de materias es obligatoria.")]
        public int CantidadMaterias { get; set; }
    }
}
