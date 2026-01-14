using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MackBMCValidation.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MackBMCValidation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MCNineController : ControllerBase
    {
        private readonly MCNineServices _mcNineServices;
        public MCNineController(MCNineServices mcNineServices)
        {
            _mcNineServices = mcNineServices;
        }

        [HttpPost("GuessANumber1-10/{number}")] 
        public string GuessEasyNumber(int number)
        {   _mcNineServices.maxNum = 11;
            return _mcNineServices.RandomizeNumber(number);
        }


        [HttpPost("GuessANumber1-50/{number}")] 
        public string GuessMediumNumber(int number)
        {   _mcNineServices.maxNum = 51;
            return _mcNineServices.RandomizeNumber(number);
        }

        [HttpPost("GuessANumber1-100/{number}")] 

        public string GuessHardNumber(int number)
        {    _mcNineServices.maxNum = 101;
            return _mcNineServices.RandomizeNumber(number);
        }
    }
}