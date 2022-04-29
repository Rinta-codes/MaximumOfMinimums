using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumLibrary
{
    public record Element(int Index, int Value);

    public static class Calculate
    {
        /// <summary>
        /// My own implementation of an algorithm described at:
        /// https://www.geeksforgeeks.org/find-the-maximum-of-minimums-for-every-window-size-in-a-given-array/
        /// </summary>

        public static int[] MaximumOfMinimumsPerWindowSize(int length, int[] input)
        {
            int[] result = new int[length + 1];

            int[] nextSmallerValueIndex = NextSmallerValueIndex(length, input);
            int[] previousSmallerValueIndex = PreviousSmallerValueIndex(length, input);
            int[] maxWindowSizeWhereElementIsMin = new int[length];

            for (int i = 0; i < length; i++)
            {
                maxWindowSizeWhereElementIsMin[i] = nextSmallerValueIndex[i] - previousSmallerValueIndex[i] - 1;
            }

            for (int j = 0; j < length; j++)
            {
                int maxWindowForJ = maxWindowSizeWhereElementIsMin[j];
                result[maxWindowForJ] = Math.Max(result[maxWindowForJ], input[j]);
            }

            for (int k = length - 1; k > 0; k--)
            {
                result[k] = Math.Max(result[k], result[k + 1]);
            }

            return result;
        }

        public static int[] NextSmallerValueIndex(int length, int[] input)
        {
            int[] result = new int[length];

            Stack<Element> stack = new();
            stack.Push(new Element(-1, 0));

            Element nextElement;
            Element lastElement;

            for (int i = 0; i < length; i++)
            {
                nextElement = new Element(i, input[i]);

                while (stack.TryPop(out lastElement) && lastElement.Value > nextElement.Value)
                {
                    result[lastElement.Index] = nextElement.Index;
                }

                stack.Push(lastElement);
                stack.Push(nextElement);
            }

            while (stack.TryPop(out lastElement) && lastElement.Index > -1)
            {
                result[lastElement.Index] = length;
            }

            return result;
        }

        public static int[] PreviousSmallerValueIndex(int length, int[] input)
        {
            int[] result = new int[length];

            Stack<Element> stack = new();
            stack.Push(new Element(length, 0));

            Element nextElement;
            Element lastElement;

            for (int i = length - 1; i > -1; i--)
            {
                nextElement = new Element(i, input[i]);

                while (stack.TryPop(out lastElement) && lastElement.Value > nextElement.Value)
                {
                    result[lastElement.Index] = nextElement.Index;
                }

                stack.Push(lastElement);
                stack.Push(nextElement);
            }

            while (stack.TryPop(out lastElement) && lastElement.Index < length)
            {
                result[lastElement.Index] = -1;
            }

            return result;
        }


        /// Andi's code for straightforward implementation (slower)

        public static int CalculateMaxOfSegmentMins1(int[] listOfNumbers, int segmentLength)
        {
            var maxOfSegmentMins = listOfNumbers.Take(segmentLength).Min();

            for (int i = 1; i <= listOfNumbers.Length - segmentLength; i++)
            {
                var segmentMin = listOfNumbers.Skip(i).Take(segmentLength).Min();
                if (segmentMin > maxOfSegmentMins)
                    maxOfSegmentMins = segmentMin;
            }

            return maxOfSegmentMins;
        }

        public static int CalculateMaxOfSegmentMins2(int[] listOfNumbers, int segmentLength)
        {
            var currentSegment = new Queue<int>(listOfNumbers.Take(segmentLength));

            var maxOfSegmentMins = currentSegment.Min();

            for (int i = segmentLength; i < listOfNumbers.Length; i++)
            {
                currentSegment.Dequeue();
                currentSegment.Enqueue(listOfNumbers[i]);

                var segmentMin = currentSegment.Min();
                if (segmentMin > maxOfSegmentMins)
                    maxOfSegmentMins = segmentMin;
            }

            return maxOfSegmentMins;
        }

        public static int[] CreateListOfNumbers(int length, int randomiserMin, int randomiserMax)
        {
            var random = new Random();

            var listOfNumbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                listOfNumbers[i] = random.Next(randomiserMin, randomiserMax);
            }

            return listOfNumbers;
        }
    }
}
