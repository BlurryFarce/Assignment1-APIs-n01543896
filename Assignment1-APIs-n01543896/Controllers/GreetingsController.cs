using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_APIs_n01543896.Controllers
{
    public class GreetingsController : ApiController
    {
        /// <summary>
        /// prints "Hello World!"
        /// </summary>
        /// <returns> string -> "Hello World"</returns>
        /// <example>
        ///     GET /api/Greetings/
        /// </example>
        public string Get() {
            string printTxt = "Hello World!";

            return printTxt;
        }
    }
}
