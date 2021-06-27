using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using Newtonsoft.Json;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumToWordsController : ControllerBase
    {
        [HttpGet("{number}")]
        public ActionResult<string> ConvertToWords(string number)
        {
            var numberInwords = "";
            try
            {
                double valueToConvert = 0;
                bool isValidNumber = Double.TryParse(number, out valueToConvert);
                if(isValidNumber)
                {
                    numberInwords = Services.Essentials.NumberToWords(valueToConvert);
                }
                else
                {
                    numberInwords = "The value that has been provided is not a valid number.";
                }
            }
            catch(Exception e)
            {
                numberInwords = "There was an issue converting the number you have provided.";
                Console.Write(e.ToString());
            }

            Response httpResponse = new Response();

            httpResponse.numberInWords = numberInwords;

            string responseBody = JsonConvert.SerializeObject(httpResponse);

            return responseBody;
        }
    }
}