using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace HNG12StageOne.Controllers
{
    [ApiController]
    [Route("api/classify-number")]
    public class StageOneController : Controller
    {
        [HttpGet]
        public IActionResult GetStageOne([FromQuery] string number)
        {
            int output;
            if (!int.TryParse(number, out output) || number.Contains('.'))
            {
                var errorInput = new
                {
                    number = "alphabet",
                    error = true
                };

                return BadRequest(errorInput);
            }

            HttpClient client = new HttpClient();
            var response = client.GetStringAsync($@"http://numbersapi.com/{output}/math").Result;

            var data = new
            {
                number = output,
                is_prime = output.IsPrimeNumber(),
                is_perfect = output.IsPerfectNumber(),
                properties = output.GetProperties(),
                digit_sum = output.SumOfDigits(),
                fun_fact = response
            };

            return Ok(data);
        }
    }
}
