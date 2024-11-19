namespace Assignment_3_1_5
{
    internal class Program
    {
        static void Main(string[] args)

        //Assignment 3_1_5
        //Write a function which takes an array as input and finds the first occurrence of 2 consecutive 1s and changes their value to 0.
        //Input:  [0,2,1,1,9,1,1]
        //Output: [0,2,0,0,9,1,1]

        {
            int[] array = { 0, 2, 1, 1, 9, 1, 1,};

            Console.WriteLine("Original array:");
            PrintArray(array);
                        
            ChangeFirstConsecutiveOnes(array);

            Console.WriteLine("Modified array:");
            PrintArray(array);
        }

        static void ChangeFirstConsecutiveOnes(int[] arr)
        {
            // Loop through the array to find consecutive 1s
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 1 && arr[i + 1] == 1)
                {
                    // Change the consecutive 1s to 0s
                    arr[i] = 0;
                    arr[i + 1] = 0;
                    break; // Stop after modifying the first occurrence
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
   