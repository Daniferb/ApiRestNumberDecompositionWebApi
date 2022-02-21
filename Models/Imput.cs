using System.ComponentModel.DataAnnotations;

namespace ApiRestNumberDecompositionWebApi.Models
{
    public class Imput
    {
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public int Value { get; set; }
    }
}