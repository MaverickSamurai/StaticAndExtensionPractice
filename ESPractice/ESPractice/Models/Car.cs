﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ESPractice.Models
{
   public  class Car
   {
        public static int Speed /*= 300*/;
        
        static  Car()
        {
            Speed = 500;
            Console.WriteLine(Speed);

        }

       //public static bool ShowSpeed()
       //{
       //     return true;
       //}
    }
}
