using System.ComponentModel.DataAnnotations;

namespace Actividad4LengProg3.Models
{
    public class EstudianteViewModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La matrícula es obligatoria")]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "El máximo de caracteres para la matrícula es 15 y el mínimo 6 caracteres")]
        [Display(Name = "Matrícula")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "La carrera es obligatoria")]
        public string Carrera { get; set; }

        [Required(ErrorMessage = "El recinto es obligatorio")]
        public string Recinto { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Correo electrónico no válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El celular es obligatorio")]
        [Phone(ErrorMessage = "Celular no válido")]
        [MinLength(10)]
        public string Celular { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [Phone(ErrorMessage = "Teléfono no válido")]
        [MinLength(10)]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La dirección es obligatoria")]
        [StringLength(200, ErrorMessage = "Máximo 200 caracteres")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        [DataType(DataType.Date)]
        public string Fecha_de_Nacimiento { get; set; }

        [Required(ErrorMessage = "El género es obligatorio")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "El turno es obligatorio")]
        public string Turno { get; set; }

        [Range(0, 100, ErrorMessage = "Debe indicar un porcentaje de beca válido")]
        public int PorcentajeBeca { get; set; }
    }
}