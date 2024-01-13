using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Team
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Read the number of problems
                int n = int.Parse(Console.ReadLine());

                // Initialize a counter for the number of problems they will implement
                int implementCount = 0;

                // Iterate through each problem
                for (int i = 0; i < n; i++)
                {
                    // Read the input for each problem and split it into three integers
                    string[] input = Console.ReadLine().Split();

                    // Parse each input with error handling
                    if (input.Length != 3 ||
                        !int.TryParse(input[0], out int petya) ||
                        !int.TryParse(input[1], out int vasya) ||
                        !int.TryParse(input[2], out int tonya))
                    {
                        throw new FormatException("Invalid input format.");
                    }

                    // Count the number of friends sure about the solution for the current problem
                    int sureCount = petya + vasya + tonya;

                    // If at least two friends are sure, increment the implementCount
                    if (sureCount >= 2)
                    {
                        implementCount++;
                    }
                }

                // Print the result
                Console.WriteLine(implementCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
