using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_APIs_n01543896.Controllers
{
    public class HostingCostController : ApiController {
        /// <summary>
        /// Calculates the cost of hosting based on number of days stayed
        /// </summary>
        /// <param name="days">Number of days stayed</param>
        /// <returns>String -> that print the message with appropriate calculation</returns>
        /// <example>
        ///     GET /api/HostingCost/3 ->   “2 fortnights at $5.50/FN = $11.00 CAD”
        ///                                 “HST 13% = $1.43 CAD”
        ///                                 “Total = $12.43 CAD”
        /// </example>
        /// <example>
        ///     GET /api/HostingCost/3 ->   “2 fortnights at $5.50/FN = $11.00 CAD”
        ///                                 “HST 13% = $1.43 CAD”
        ///                                 “Total = $12.43 CAD”
        /// </example>
        [Route("api/HostingCost/{days}")]
        public string Get(int days) {
            int fortnights = (days / 14) + 1;
            double hostingCost = fortnights * 5.50;
            double hst = hostingCost * 0.13;
            double totalCost = hostingCost + hst;

            //had to use other resource for the precision
            string fortnightCostString =$"-- {fortnights} fortnights at $5.50/FN = {hostingCost:f2} CAD -- ";
            string taxString = $"-- HST 13% =  {hst:f2}   CAD -- ";
            string totalCostString = $"-- Total = {totalCost:f2}  CAD --";

            string response =  fortnightCostString + taxString + totalCostString;
            return response;
        }
    }
}
