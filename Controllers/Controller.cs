using ApiRestNumberDecompositionWebApi.Models;
using ApiRestNumberDecompositionWebApi.Mapping;
using ApiRestNumberDecompositionWebApi.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiRestNumberDecompositionWebApi.Controllers
{
    
    [ApiController]
    [Route("v1/controller")]
    public class Controller : ControllerBase
    {
        [HttpPost("")]
        public Output GetDividingNumbers([FromBody] Imput imput)
        {
            if (imput.Value.Equals(default(int)))
                throw new System.Exception("O número digitado é uma indeterminação!");

            List<int> divisors = ServiceNumberDecomposition.FindDividingNumbers(imput);
            List<int> primeDivisors = ServiceNumberDecomposition.FindPrimeDivisorsNumber(imput);

            Output output = Mapper.Map(imput, divisors, primeDivisors);

            return output;    
        }
    }
}