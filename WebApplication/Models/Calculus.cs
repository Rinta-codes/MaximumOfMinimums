using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaximumLibrary;

namespace WebApplication.Models
{
    public class Calculus
    {
        public int WindowSize { get; set; }
        public string ListOfNumbers { get; set; }

        public int Calculate()
        { 
            return MaximumLibrary.Calculate.CalculateMaxOfSegmentMins1(ListOfNumbers.Split(" ").Select(x => Convert.ToInt32(x)).ToArray(), WindowSize);
        }

    }
}
