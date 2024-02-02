using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_APIs_n01543896.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Returns the input number plus 10
        /// </summary>
        /// <param name="numb">The input number</param>
        /// <returns>The input with 10 added</returns>
        /// <example>
        ///     GET /api/AddTen/10 -> 20
        /// </example>
        /// <example>
        ///     GET /api/AddTen/40 -> 50
        /// </example>
        [Route("api/AddTen/{numb}")]
        public int Get(int numb) {
            int result = numb + 10;

            return result;
        }
    }

}
