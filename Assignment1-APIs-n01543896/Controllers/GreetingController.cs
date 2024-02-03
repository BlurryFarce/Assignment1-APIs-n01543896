using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_APIs_n01543896.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// prints a greeting based on the number of people entered
        /// </summary>
        /// <param name="people">Number of people to greet</param>
        /// <returns>string -> with the input that is the number of people</returns>
        /// <example>
        ///     GET /api/Greeting/4 -> Greetings to 4 people!
        /// </example>
        /// <example>
        ///     GET /api/Greeting/10 -> Greetings to 10 people!
        /// </example>
        [Route("api/Greeting/{people}")]
        public string Get(int people) {
            string response = "Greetings to "+ people + " people!";

            return response;
        }
    }
}
