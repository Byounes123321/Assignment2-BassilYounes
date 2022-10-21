using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {

        /// <summary>
        /// This program recives the total number of calories from the items that were ordered
        /// </summary>
        /// <returns>
        /// This code returns the an interger of the amount of calories
        /// </returns>
        // GET api/j1/Menu/1/2/3/4

        [HttpGet]
        [Route("api/j1/Menu/{burger}/{drink}/{side}/{desert}")]
        public int Menu(int burger, int drink, int side, int desert)
        {
            int totalCalories = 0;
            if (burger == 1)
            {
               totalCalories += 461;

            }
            else if  (burger == 2)
            {
                 totalCalories += 431;
            }
            else if  (burger == 3)
            {
                totalCalories +=  420;

            }
             else if (burger == 4)
            {
                 totalCalories  += 0;
            }
            if  (drink == 1) 
            {
               totalCalories += 130;
            }
            else if (drink == 2 )
            {
                totalCalories += 160 ;
            }
            else if  (drink == 3)
            {
               totalCalories +=  118;
            }
            else if  (drink == 4)
            {
                totalCalories  += 0;
            }
            if ( side == 1)
            {
                totalCalories  += 100;
            }
            else  if (side == 2)
            {
                  totalCalories += 57;
            }
            else if (side ==  3)
            {
              totalCalories +=  70;
            }
            else if (side == 4)
            {
                  totalCalories += 0;
            }
            if (desert ==  1)
            {
                totalCalories +=  167;
            }
            else if (desert == 2)
            {
                 totalCalories += 266;
            }
            else if (desert == 3)
            {
                totalCalories += 75;
            }
            else if  ( desert == 4)
            {
                totalCalories +=  0;
            }
            return  totalCalories;
        }
    }
}
