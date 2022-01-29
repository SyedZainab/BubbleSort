using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an array: ");
            int size_of_an_array = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Array elements: ");
            string[] user_Input = Console.ReadLine().Split(' ');
            int[] int_Array = new int[size_of_an_array];

            for (int i = 0; i < size_of_an_array; i++)
            {
                int_Array[i] = int.Parse(user_Input[i]); //Assign user input to array.
            }

            Bubble_Sort(int_Array);
            
            Console.WriteLine("The sorted array is ");

            for (int n = 0; n < int_Array.Length; n++)
            {
                Console.Write(int_Array[n] + " "); //Print the sorted array to console.
            }
            Console.ReadLine();
        }

        public static void Bubble_Sort(int[] arr)
        {
            int size = arr.Length;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        //Swap the elements
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}

