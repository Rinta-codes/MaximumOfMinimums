using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using MaximumLibrary;

namespace MaximumOfMinimums
{

    public record Element(int Index, int Value);

    public class MaximumOfMinimums
    {
        public static void Main()
        {
            int[] testArray = { 10, 20, 30, 50, 10, 70, 30 };
            int[] longTestArray = { 43, 40, 60, 4, 12, 84, 34, 60, 61, 75, 7, 74, 53, 16, 32, 64, 54, 40, 26,
                76, 45, 96, 96, 75, 60, 74, 54, 36, 0, 19, 52, 68, 12, 87, 5, 42, 24, 52, 96, 37, 47, 51,
                11, 41, 28, 49, 21, 1, 80, 80, 19, 65, 87, 5, 37, 47, 44, 85, 44, 38, 30, 97, 59, 42, 22,
                38, 61, 66, 11, 89, 39, 1, 43, 88, 28, 94, 84, 54, 46, 10, 53, 53, 56, 20, 0, 86, 81, 7,
                49, 57, 97, 38, 8, 57, 7, 49, 91, 69, 19, 89 };

            int windowSize = 3;
            var result = Calculate.MaximumOfMinimumsPerWindowSize(testArray.Length, testArray)[windowSize];
            // Console.WriteLine($"Max of Min values for Window Size = {windowSize} is: {result}\n\n");

            /// Andi's Code 

            var stopwatch = new Stopwatch();

            Console.WriteLine("Creating the list of numbers");
            var listOfNumbers = Calculate.CreateListOfNumbers(1000000, 0, 100);
            var randomSegment = new Random();
            var segmentLength = randomSegment.Next(1, 100);

            Trace.Assert(listOfNumbers.Length > 0, "The list of numbers should not be empty");
            Trace.Assert(segmentLength <= listOfNumbers.Length, "The segmenth length should not exceed the length of the list of numbers");

            GC.Collect();
            stopwatch.Restart();
            var maxOfSegmentMins1 = Calculate.CalculateMaxOfSegmentMins1(listOfNumbers, segmentLength);
            Console.WriteLine($"Max of segment mins calculated by algorithm 1 for Segment of {segmentLength}: {maxOfSegmentMins1}, calculation took {stopwatch.Elapsed}");

            GC.Collect();
            stopwatch.Restart();
            var maxOfSegmentMins2 = Calculate.CalculateMaxOfSegmentMins2(listOfNumbers, segmentLength);
            Console.WriteLine($"Max of segment mins calculated by algorithm 2 for Segment of {segmentLength}: {maxOfSegmentMins2}, calculation took {stopwatch.Elapsed}");

            GC.Collect();
            stopwatch.Restart();
            var maxOfSegmentMinsRinta = Calculate.MaximumOfMinimumsPerWindowSize(listOfNumbers.Length, listOfNumbers)[segmentLength];
            Console.WriteLine($"Max of segment mins calculated by Rinta's algorithm for Segment of {segmentLength}: {maxOfSegmentMinsRinta}, calculation took {stopwatch.Elapsed}");

            Console.Read();
        }

    }
}
