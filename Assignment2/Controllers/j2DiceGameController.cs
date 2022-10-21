using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2DiceGameController : ApiController
    {


        /// <summary>
        /// This program will compute the number of ways to add up to ten using two dice
        /// </summary>
        /// <returns>
        /// This code returns a string "there are {num} ways to get the sum"
        /// </returns>
        // GET api/J2/DiceGame/1/2

        [HttpGet]
        [Route("api/J2DiceGame/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int counter = 0;
                for (int i = 1; i <= m; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (i + j == 10)
                        {
                            counter++;
                        }
                    }
                }
            return "There are " + counter + " ways to get the sum 10";             
        }
    }
}
