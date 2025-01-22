namespace Assignment3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sort a list of elements using Bubble sort.

            // Input: Get the size of the array
            Console.Write("Enter the number of elements: ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer.");
            }

            // Declare the array
            int[] arr = new int[size];

            // Input: Get the elements of the array
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Invalid input! Please enter an integer.");
                    Console.Write($"Element {i + 1}: ");
                }
            }

            // Perform Bubble Sort
            BubbleSort(arr);

            // Output: Display the sorted array
            Console.WriteLine("Sorted array:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }

        // Bubble Sort function
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++) // Outer loop for passes
            {
                for (int j = 0; j < n - i - 1; j++) // Inner loop for comparisons
                {
                    if (arr[j] > arr[j + 1]) // Swap if elements are out of order
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }

}
