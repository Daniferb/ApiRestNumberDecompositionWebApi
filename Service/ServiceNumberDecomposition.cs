using ApiRestNumberDecompositionWebApi.Models;
using ApiRestNumberDecompositionWebApi.Models.Constants;
using System.Collections.Generic;

namespace ApiRestNumberDecompositionWebApi.Service
{
    public static class ServiceNumberDecomposition
    {        
        public static List<int> FindDividingNumbers(Imput imput)
        {
            int divider = Constants.divider;

            List<int> numbersDivisors = new List<int>();

            for (divider = 1; divider <= imput.Value; divider++)
            {
                if ((imput.Value % divider) == default(int))
                    numbersDivisors.Add(divider);
            }

            return numbersDivisors;
        }

        public static List<int> FindPrimeDivisorsNumber(Imput imput)
        {
            int primeDivider = Constants.divider;

            List<int> primeNumbersDivisors = new List<int>();

            for (primeDivider = 1; primeDivider <= imput.Value; primeDivider++)
            {
                int counter = 0;

                if ((imput.Value % primeDivider) == 0)
                {
                    for(int j = 1; j <= primeDivider; j++)
                    {
                        if ((primeDivider % j) == 0)
                            counter++;
                    }

                    if (counter == 2)
                        primeNumbersDivisors.Add(primeDivider);
                }                
            }

            return primeNumbersDivisors;
        }
    }
}