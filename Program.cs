using System;

namespace Binary_Search
{
    class Program
    {
        const int SIZE = 10;
        static void Main(string[] args)
        {
            int i,  num;
            int[] array_demo = new int[SIZE];

            for (i = 0; i <= SIZE - 1; i++)
            {
                array_demo[i] = i + 5;
            }
            
            for(i = 0; i <= SIZE - 1; i++)
            {
                Console.Write(array_demo[i] + " ");
            }

            Console.Write("\nEnter the number to search: ");
            num = Int32.Parse(Console.ReadLine());

            BinarySearch(array_demo, num);
        }
        
        // Binary Search Algorithm
        static void BinarySearch(int[] haystack, int needle)
        {
            int left, middle, right, needle_index;
            bool found;

            left = 0;
            right = haystack.Length - 1;
            found = false;
            needle_index = -1;
            while(left <= right && found == false)
            {
                middle = (int)((left + right) / 2);

                if(needle < haystack[middle])
                {
                    right = middle - 1;

                }
                else if(needle > haystack[middle])
                {
                    left = middle + 1;
                }
                else
                {
                    needle_index = middle;
                    found = true;
                }
            }

            if(found == false)
            {
                Console.WriteLine("Value not found!");
            }
            else
            {
                Console.WriteLine("Value found at index " + needle_index);
            }

        }
    }
}
