using System.ComponentModel.DataAnnotations;

namespace WebApiOne.Models
{
    public class Usuario
    {
        /*Las propiedades deben tener el mismo nombre que las columnas de la tabla*/
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Edad { get; set; }
        public string? CorreoElectronico { get; set; }
    }
}
