using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tal_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PremiumController : ControllerBase
    {

        private readonly ILogger<PremiumController> _logger;

        public PremiumController(ILogger<PremiumController> logger)
        {
            _logger = logger;
        }
       
        [HttpGet]
        public double Get([FromBody]CalculatePremium calculatePremium)
        {
            double Rating = -1;
            switch(calculatePremium.Occupation)
            {
                case "Professional":
                    Rating = 1.0;
                    break;
                case "White Collar":
                    Rating = 1.25;
                    break;
                case "Light Manual":
                    Rating = 1.50;
                    break;
                case "Heavy Manual":
                    Rating = 1.75;
                    break;

            }
            


            var result = calculatePremium.DeathSum * Rating * calculatePremium.Age / (1000 * 2);

            return result;
        }

        [HttpPost]
        public double Post([FromBody] CalculatePremium calculatePremium)
        {
            double Rating = -1;
            switch (calculatePremium.Occupation)
            {
                case "Professional":
                    Rating = 1.0;
                    break;
                case "White Collar":
                    Rating = 1.25;
                    break;
                case "Light Manual":
                    Rating = 1.50;
                    break;
                case "Heavy Manual":
                    Rating = 1.75;
                    break;

            }



            var result = calculatePremium.DeathSum * Rating * calculatePremium.Age / (1000 * 2);

            return result;
        }


    }
}
