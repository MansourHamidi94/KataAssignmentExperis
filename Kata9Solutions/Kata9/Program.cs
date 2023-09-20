using System;
using System.Collections.Generic;

namespace ArrayShufflingAndFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the sorted array.
            List<int> sortedArray = new List<int>() { 65, 22, 13, 1, 0, 0, -1, -17, -101, -114, -114 };

            // Display the sorted array.
            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(", ", sortedArray));

            // Shuffle the array.
            Shuffle(sortedArray);

            // Display the shuffled array.
            Console.WriteLine("After Shuffling:");
            Console.WriteLine(string.Join(" ", sortedArray));

            // Find and display the frequency of each element.
            Dictionary<int, int> frequency = FindFrequency(sortedArray);

            Console.WriteLine("The number and the frequency are:");
            foreach (var item in frequency)
            {
                Console.WriteLine($"Number {item.Key} appears {item.Value} times");
            }
        }

        // Method to shuffle an array.
        static void Shuffle(List<int> array)
        {
            Random rand = new Random();

            for (int i = array.Count - 1; i >= 1; i--)
            {
                // Generate a random index less than i.
                int j = rand.Next(i + 1);

                // Swap array[i] and array[j].
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        // Method to find the frequency of each element in an array.
        static Dictionary<int, int> FindFrequency(List<int> array)
        {
            // Initialize the dictionary to hold the frequency.
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            // Count the frequency of each element.
            foreach (var item in array)
            {
                if (frequency.ContainsKey(item))
                {
                    frequency[item]++;
                }
                else
                {
                    frequency[item] = 1;
                }
            }

            return frequency;
        }
    }
}
