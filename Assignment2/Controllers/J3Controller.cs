using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// This method is used to crack the code to get the formula, this is done by using the inputed numbers and decoding them to recive the formula
        /// </summary>
        /// <results>
        /// the output will be a sring of texts that that define a direction and the number of steps to take in that direction
        /// </results>
        /// <output>
        /// right 158
        /// left 225
        /// right 100
        /// </output>
        // GET api/J3/SecretInstructions/12345/12345/12345/12345/99999

        [HttpGet]
        [Route("api/J3/SecretInstructions/{a}/{b}/{c}/{d}/{e}")]
        public string SecretInstructions(int a, int b, int c, int d, int e)
        
        {        
            /* 
            Step 1: Get first two numbers of int a
            Step 2: Add first and second numbers together
            Step 3: Compute the first and second numbers and determine if they are odd or even numbers or if they are a 0 
            Step 4: If they are even then output "Right"
            Step 5: If they are odd then output "Left"
            Step 6: If they are 0 then output the same output as last
            Step 7: If all inputs are 99999 then stop the program
            if thoes = even , output right and the other three nums
            */


            // add all the imputs into an array

            int[] inputs = { a, b, c, d, e };

          
            //create a list that holds the last three numbers from each input
            List<string> totalSteps = new List<string>();
            //create a list that holds the first two numbers added together 
            List<int> totalNum = new List<int>();
            
            // these two variables hold the first and second numbers of the inputs to be sent to the list above
            int first=0;

            int second = 0;
            // the for loop goes through and saves the numbers needed to the variables and list
            for (int i = 0; i < inputs.Length; i++)
            {
                 first = Convert.ToInt32(inputs[i].ToString().Substring(0, 1));

                 second = Convert.ToInt32(inputs[i].ToString().Substring(1, 1));

                string steps = (inputs[i].ToString().Substring(2, 3));

                int num = first + second;

                totalSteps.Add(steps);
                totalNum.Add(num);
            }
            //return first;
            //return totalNum[0];


            // this variable is a counter for the loop below so that it can be used outside of its scope
            int j = 0;

            // this is a list of the directons to be stored for later

            List<string> directions = new List<string> ();

            string direction = "";

            // this loop determines if the first two numbers of the input are equal or odd once added and it adds them to the list above
            for (j = 0; j < totalNum.Count; j++)
            {
                if (totalNum[j] % 2 == 0)
                {
                    direction = "right" + " " + totalSteps[j];
                }
                else if (totalNum[j] == 0)
                {
                    // this is ment to return the last direction that was given but the current totalSteps
                    return direction + totalSteps[j];
                }
                else
                {
                    direction = "left" + " " + totalSteps[j];
                }
                directions.Add(direction);
                return directions[j];
            }
                // finally the correct output will be returned as a string....hopefully
                /* Ive created this controller 5 times in diffrent projects tying diffrent ways to make it work and on one 
                   I got everything to work but when the first inputs are 00 but this is the most thought out attempt i have got */
        }
    }
}
