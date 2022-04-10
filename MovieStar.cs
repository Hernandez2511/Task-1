using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Ejercicio_1
{

    //MoviStar class
    public class MovieStar
    {
        //variables to store data
       
       
        public DateTime dateofbirth { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string sex { get; set; }
        public string nationality { get; set; }

       
        /// Calculate Age 
            public int calcAge() 
       {
          
            int daynow = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(dateofbirth.ToString("yyyyMMdd"));

            int ans= (daynow - dob) / 10000;
            return ans;

        }



    }
}
