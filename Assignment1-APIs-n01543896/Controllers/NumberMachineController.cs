using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_APIs_n01543896.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// takes a number from user and performs 4 mathematical and prints the result
        /// it multiplies the number with 3 then adds the input and 100, subtracts 10/2
        /// </summary>
        /// <param name="numb">Number to perform operations on</param>
        /// <returns> integer -> after peroforming the operations</returns>
        /// <example>
        ///     GET /api/NumberMachine/3 -> 107
        /// </example>
        /// <example>
        ///     GET /api/NumberMachine/6 -> 119
        /// </example>
        /// <example>
        ///     GET /api/NumberMachine/-5 -> 75
        /// </example>
        [Route("api/NumberMachine/{numb}")]
        public int Get(int numb) {
            int result = (numb * 3) + numb + 100 - (10 / 2); 

            return result;
        }
    }
}
