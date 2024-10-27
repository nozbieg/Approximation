using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approximation
{
    internal static class Utils
    {

        public static int[] GenerateRandomArray(int length)
        {
            int[] array = new int[length];
            var r = new Random();
            for (int i = 0; i<length; i++)
            {
                array[i] = r.Next();
            }

            return array;
        }

        public static void PrintArray(int[] array, string letter)
        {
            Console.WriteLine($"Array{letter}");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

        }

    }
}
