namespace Assignment3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //multiplication of two square Matrices
            // Get the size of the square matrices
            Console.Write("Enter the size of the square matrices (n x n): ");
            int n;

            // Validate the input
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer.");
            }

            // Declaring two matrices and the result matrix
            int[,] matrix1 = new int[n, n];
            int[,] matrix2 = new int[n, n];
            int[,] resultMatrix = new int[n, n];

            // Get values for the first matrix
            Console.WriteLine("Enter the elements of the first matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    while (!int.TryParse(Console.ReadLine(), out matrix1[i, j]))
                    {
                        Console.WriteLine("Invalid input! Please enter an integer.");
                        Console.Write($"Element [{i + 1},{j + 1}]: ");
                    }
                }
            }

            // Get values for the second matrix
            Console.WriteLine("Enter the elements of the second matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    while (!int.TryParse(Console.ReadLine(), out matrix2[i, j]))
                    {
                        Console.WriteLine("Invalid input! Please enter an integer.");
                        Console.Write($"Element [{i + 1},{j + 1}]: ");
                    }
                }
            }

            // Perform matrix multiplication
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    resultMatrix[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            // Display the resulting matrix
            Console.WriteLine("\nThe resulting matrix after multiplication is:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}