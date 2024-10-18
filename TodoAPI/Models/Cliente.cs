

using System.ComponentModel.DataAnnotations;

namespace TodoAPI.Models
{
      public class Cliente
    {
        [Key]
        public Guid id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string PaisOrigen { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Cliente()
        {
            // IsComplete = false;
        }
    }
}