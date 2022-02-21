using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApiRestNumberDecompositionWebApi.Models
{
    public class Output
    {
        [JsonPropertyName("Número de Entrada")]
        public Imput Imput { get; set; }

        [JsonPropertyName("Números divisores")]
        public List<int> Divisors { get; set; }

        [JsonPropertyName("Divisores Primos")]
        public List<int> PrimeDivisor { get; set; }

    }
}