using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace MackBMCValidation.Services
{
    public class MCNineServices
    {
        public int numToGuess = 0;
        public int maxNum = 0;
        public string RandomizeNumber(int number)
        { 
            Random random = new Random();
            numToGuess = random.Next(1, maxNum);

            if (number > numToGuess)
            {   
                return $"Try again a bit too high! The number was actually {numToGuess}.";
                
            }
            else if (number < numToGuess)
            { return $"Try again a bit too low! The number was actually {numToGuess}."; }
            else
            {   numToGuess = 0;
                return $"Would you look at that, you got it! The number was {numToGuess}.";

            }
        }
    }
}