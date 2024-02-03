using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_APIs_n01543896.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Returns the square  of the input number
        /// </summary>
        /// <param name="numb">The input number</param>
        /// <returns>int -> The square of the integer input</returns>
        /// <example>
        ///     GET /api/Square/4 -> 16
        /// </example>
        /// <example>
        ///     GET /api/Square/10 -> 100
        /// </example>
        [Route("api/Square/{numb}")]
        public int Get(int numb) {
            int square = numb * numb;

            return square;
        }
    }
}
