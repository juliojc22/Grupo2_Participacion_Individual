using System.ComponentModel.DataAnnotations;

namespace Grupo2.Models
{
    public class Facultad
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la facultad es obligatorio.")]
        [StringLength(30, ErrorMessage = "El nombre no puede superar los 30 caracteres.")]
        [Display(Name = "Nombre de la facultad")]
        public string Nombre { get; set; } = "";

        public ICollection<Carrera> Carreras { get; set; } = new List<Carrera>();

    }
}



