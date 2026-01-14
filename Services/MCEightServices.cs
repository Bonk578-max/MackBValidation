using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.VisualBasic;


namespace MackBMCValidation.Services
{
    public class MCEightServices
    {
        public string RandomAnswer(string question)
        {
           if (question.Contains("?"))
           { Random random = new Random();
            int rndNumber = random.Next(1, 9);

            switch (rndNumber)
            {
                case 1: return "Possibly";
                case 2: return "Maybe.";
                case 3: return "Try again later.";
                case 4: return "Most likely.";
                case 5: return "Nah";
                case 6: return "without a doubt.";
                case 7: return "Signs point to yes.";
                case 8: return "Not gonna happen.";
                default: 
                return "Unknown";
            }
           }

           else
            {
                return "Please enter a valid question.";
            }
        }
    }
}