using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MackBMCValidation.Services;

namespace MackBMCValidation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MCTenController : ControllerBase
    {
         private readonly MCTenServices _mcTenServices;

        public MCTenController(MCTenServices mcTenServices)
        {
            _mcTenServices = mcTenServices;
        }
            [HttpPost("TypeFancyFriedOrOldTimey/{foodcategory}")]
            public string RandomizedRestaurant(string foodcategory){
                return _mcTenServices.RandomizedRestaurant(foodcategory);
            }

    }
}