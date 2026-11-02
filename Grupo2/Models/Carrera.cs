using System.ComponentModel.DataAnnotations;

namespace Grupo2.Models
{
    public class Carrera
    {



        
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la carrera es obligatorio.")]
        [StringLength(25, ErrorMessage = "El nombre no puede superar los 25 caracteres.")]
        [Display(Name = "Nombre de la carrera")]
        public string Nombre { get; set; } = "";

        [Required(ErrorMessage = "La duración es obligatoria.")]
        [Range(1, 10, ErrorMessage = "La duración debe estar entre 1 y 10 semestres.")]
        [Display(Name = "Duración en semestres")]
        public int DuracionSemestres { get; set; }

        [Display(Name ="Facultad")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar una facultad.")]
        public int FacultadId { get; set; }

        public Facultad? Facultad { get; set; }

    }
}
