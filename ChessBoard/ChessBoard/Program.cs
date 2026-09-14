//Shenol Mitkov
using System;
using System.Text;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set console encoding to UTF8 so special characters display correctly
            Console.OutputEncoding = Encoding.UTF8;

            // Prompt the user to enter the size of the chessboard
            Console.Write("Ange storlek på brädet: ");

            // Read the user's input as a string
            string input = Console.ReadLine();

            // Try to parse the input as an integer and ensure it's > 0
            if (!int.TryParse(input, out int n) || n <= 0)
            {
                // Invalid input — tell the user and exit early
                Console.WriteLine("Ange ett heltal större än 0.");
                return;
            }

            // Outer loop: iterate over each row of the board
            for (int row = 0; row < n; row++)
            {
                // Build the row using a StringBuilder for efficient string concatenation
                var lineBuilder = new StringBuilder();

                // Inner loop: iterate over each column in the current row
                for (int col = 0; col < n; col++)
                {
                    // Decide color based on row + column.
                    // If the sum is even the square is "white", otherwise "black" — this creates the checker pattern.
                    bool isWhite = (row + col) % 2 == 0;
                    // Append the corresponding character for a white or black square.
                    // '◻︎' = white square, '◼︎' = black square.
                    lineBuilder.Append(isWhite ? "◻︎" : "◼︎");
                }

                // Write the completed row
                Console.WriteLine(lineBuilder.ToString());
            }

            // Wait for a key press before the program exits (so the user can see the result)
            Console.ReadKey();
        }
    }
}
