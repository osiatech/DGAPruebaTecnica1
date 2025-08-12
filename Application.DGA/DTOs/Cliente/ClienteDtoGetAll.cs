

using System.ComponentModel.DataAnnotations;

namespace Application.DGA.DTOs.Cliente
{
    public class ClienteDtoGetAll
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
