namespace Assignment3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the size of the matrices
            Console.Write("Enter the number of rows: ");
            int rows;
            while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer.");
            }

            Console.Write("Enter the number of columns: ");
            int cols;
            while (!int.TryParse(Console.ReadLine(), out cols) || cols <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer.");
            }

            // Declare matrices
            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];

            // Input first matrix
            Console.WriteLine("Enter the elements of the first matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    while (!int.TryParse(Console.ReadLine(), out matrix1[i, j]))
                    {
                        Console.WriteLine("Invalid input! Please enter an integer.");
                        Console.Write($"Element [{i + 1},{j + 1}]: ");
                    }
                }
            }

            // Input second matrix
            Console.WriteLine("Enter the elements of the second matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    while (!int.TryParse(Console.ReadLine(), out matrix2[i, j]))
                    {
                        Console.WriteLine("Invalid input! Please enter an integer.");
                        Console.Write($"Element [{i + 1},{j + 1}]: ");
                    }
                }
            }

            // Check if the matrices are equal
            bool areEqual = true;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                    {
                        areEqual = false;
                        break;
                    }
                }
                if (!areEqual) break;
            }

            // Display the result
            if (areEqual)
            {
                Console.WriteLine("The matrices are equal.");
            }
            else
            {
                Console.WriteLine("The matrices are not equal.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}