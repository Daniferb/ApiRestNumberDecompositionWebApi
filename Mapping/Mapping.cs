using ApiRestNumberDecompositionWebApi.Models;
using System.Collections.Generic;

namespace ApiRestNumberDecompositionWebApi.Mapping
{
    public static class Mapper
    {
        public static Output Map(Imput imput, List<int> divisors, List<int> primeDivisors)
        {
            return new Output
            {
                Imput = imput,
                Divisors = divisors,
                PrimeDivisor = primeDivisors
            };
        }
    }
}