using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Assignment_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Assignment01Controller : ControllerBase
    {
        /// <summary>
        /// To Welcome user to a course code
        /// </summary>
        /// <returns> 
        /// A Welcome message to the course is displayed on the screen.
        /// </returns>
        ///<example>
        ///GET: https://localhost:7221/api/q1/welcome-> "Welcome to 5125!"
        ///</example>
        [HttpGet(template:"/api/q1/welcome")]
        public string WelcomeMessage() 
        {
            return "Welcome to 5125!";
        }

        /// <summary>
        /// Takes the user name as input and greets the user with his/her name.
        /// </summary>
        /// <param name="username">
        /// Receives the user name.
        /// </param>
        /// <returns> 
        /// A message is displayed greeting the user with his/her name on the screen with the given input.
        /// </returns>
        ///<example>
        ///GET: https://localhost:7221/api/q2/greeting?username=Gary"-> "Hi Gary!"
        ///</example>
        ////<example>
        ///GET: https://localhost:7221/api/q2/greeting?username=Ren%C3%A9e"-> "Hi Renée!"
        ///</example>
        [HttpGet(template:"/api/q2/greeting/{username}")]
        public string GreetUser(string username)
        {
            return "Hi " + username + "!";
        }

        /// <summary>
        /// Takes the base number as input and return cube of the given number.
        /// </summary>
        /// <param name="basenumber">
        /// Receives the number as input.
        /// </param>
        /// <returns> 
        /// A number is displayed on the screen, according to the input and the cube of that number is evaluated..
        /// </returns>
        ///<example>
        ///GET: https://localhost:7221//api/q3/cube/{basenumber}"-> cube root of number
        ///</example>
        ///<example>
        ///GET: https://localhost:7221//api/q3/cube/{4}"-> 64
        ///</example>
        ///<example>
        ///GET: https://localhost:7221//api/q3/cube/{-4}"-> 64
        ///</example>
        ///<example>
        ///GET: https://localhost:7221//api/q3/cube/{10}"-> 100
        ///</example>
        [HttpGet(template:"/api/q3/cube/{basenumber}")]
        public int Cube(int basenumber)
        {
            return basenumber*basenumber*basenumber;
        }
        /// <summary>
        /// It's a POST request without response body and returns knock knock joke.
        /// </summary>
        /// <returns> 
        /// It returns the default return statement provided.
        /// </returns>
        /// <example>
        ///POST: https://localhost:7221//api/q4/knockknock"-> "Who's there?"
        ///</example>
        [HttpPost(template:"/api/q4/knockknock")]
        public string Knockknock()
        {
            return "Who's there?";
        }
        /// <summary>
        /// Takes the secret number as a input from the body in a POST request and returns that input on the screen.
        /// </summary>
        /// <param name="secret">
        /// Receives the secret number as input.
        /// </param>
        /// <returns> 
        /// A secret number is taken as input and returns that number as a secret on the screen.
        /// </returns>
        /// <example>
        ///POST: https://localhost:7221//api/q3/secret"-> "Shh.. the secret is {secret}"
        ///HEADER: Content-Type: application/json
        ///FORM DATA/REQUEST BODY: 5
        ///"Shh.. the secret number is 5".
        ///</example>
        /// <example>
        ///POST: https://localhost:7221//api/q3/secret"-> "Shh.. the secret is {secret}"
        ///HEADER: "Content-Type: application/json"
        ///FORM DATA/REQUEST BODY: -200
        ///"Shh.. the secret number is -200".
        ///</example>
        [HttpPost(template:"/api/q5/secret")]
        public string Post([FromBody] int secret)
        {
            return "Shh.. the secret is " + secret;
        }
        /// <summary>
        /// Takes the side value from user to calculate area of a hexagon.
        /// </summary>
        /// <param name="side">
        /// Receives the value of a side.
        /// </param>
        /// <returns> 
        /// Returns the area of a hexagon using the formula provided in the area variable.
        /// </returns>
        ///<example>
        ///GET: https://localhost:7221/api/q6/hexagon?side=1"-> 2.598076211353316
        ///</example>
        //////<example>
        ///GET: https://localhost:7221/api/q6/hexagon?side=1.5"-> 5.845671475544961
        ///</example>
        //////<example>
        ///GET: https://localhost:7221/api/q6/hexagon?side=20"-> 1039.2304845413264
        ///</example>
        [HttpGet(template:"/api/q6/hexagon/{side}")]
        public double AreaHex(double side)
        {
            double area = ((3 * Math.Sqrt(3)) / 2) * Math.Pow(side,2);
            return area;
        }
        /// <summary>
        /// It takes the number of days to add or subtract from the given date and gives the expected date to the user.
        /// </summary>
        /// <param name="days">
        /// Receives the number of days either a positive or a negative value.
        /// </param>
        /// <returns> 
        /// Returns  a date to the user
        /// </returns>
        ///<example>
        ///GET: https://localhost:7221/api/q7/timemachine?days=1"-> 2000-01-02
        ///</example>
        //////<example>
        ///GET: https://localhost:7221/api/q7/timemachine?days=-1"-> 1999-12-31
        ///</example>
        [HttpGet(template: "/api/q7/timemachine/{days}")]
        public String TimeMachine(double days)
        {
            DateTime date = new DateTime(2000, 01, 01);
            date = date.Date;
            date=date.AddDays(days);
            String expectedDate = date.ToString("yyyy/MM/dd");
            return expectedDate;
        }
        /// <summary>
        /// Takes the small and large quantity number as a input from the body in a POST request and returns the calculated total for the order on the screen.
        /// </summary>
        /// <param name="Small">
        /// Receives the secret Small quantity value as input.
        /// </param>
        /// <param name="Large">
        /// Receives the secret Large quantity value as input.
        /// </param>
        /// <returns> 
        /// Return the calculated total of order for SquashFellows online site.
        /// </returns>
        /// <example>
        ///POST: https://localhost:7221//api/q8/squashfellows/{Small}&{Large}"-> "total value"
        ///HEADER: Content-Type: application/json
        ///FORM DATA/REQUEST BODY: Small=1&Large=1&Tax=8.58
        ///"Total = $74.58"
        ///</example>
        /// <example>
        ///POST: https://localhost:7221//api/q8/squashfellows/{Small}&{Large}"-> "total value"
        ///HEADER: Content-Type: application/json
        ///FORM DATA/REQUEST BODY: Small=2&Large=1&Tax=11.90
        ///"Total = $103.40"
        ///</example>
        /// /// <example>
        ///POST: https://localhost:7221//api/q8/squashfellows/{Small}&{Large}"-> "total value"
        ///HEADER: Content-Type: application/x-www-form-urlencoded
        ///FORM DATA/REQUEST BODY: Small=100&Large=100&Tax=858.00
        ///"Total =$7458.00"
        ///</example>
        [HttpPost(template:"/api/q8/squashfellows")]
        [Consumes("application/x-www-form-urlencoded")]
        public String SquashFellows([FromForm] double Small,[FromForm] double Large, [FromForm] double Tax)
        {
            double smallPrice = 25.50;
            String finalSmallPrice = smallPrice.ToString("F", CultureInfo.InvariantCulture);
            double largePrice = 40.50;
            String finalLargePrice = largePrice.ToString("F", CultureInfo.InvariantCulture);
            String finalTax = Tax.ToString("F", CultureInfo.InvariantCulture);
            double total = Small * smallPrice + Large * largePrice + Tax;
            String finalTotal = total.ToString("F", CultureInfo.InvariantCulture);
            return +Small+" Small @ $25.50 = "+ finalSmallPrice + " ; " +Large+ " Large @ $40.50 = "+ finalLargePrice + " ; Tax = "+ finalTax + " HST; Total = $" + finalTotal;
        }
    }
}
