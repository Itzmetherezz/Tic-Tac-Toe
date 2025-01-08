using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



internal class Program
{
    private static void Main(string[] args)
    {
        string[] grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        bool player1 = true;
        int turns = 0;

        while (!Victory(grid) && turns != 9)
        {
            PrintGrid(grid);

            if (player1)
            {
                Console.WriteLine("Player 1, enter a number");
            }
            else
            {
                Console.WriteLine("Player 2, enter a number");
            }
            string input = Console.ReadLine();

            if (grid.Contains(input) && input != "X" && input != "0")
            {
                int gridIndex = Convert.ToInt32(input) - 1;
                if (player1)
                {
                    grid[gridIndex] = "X";
                }
                else
                {
                    grid[gridIndex] = "0";
                }
                turns++;
            }
            player1 = !player1;
        }

        PrintGrid(grid);

        if (Victory(grid))
        {
            Console.WriteLine ("You Win!");
        }
        else
        {
            Console.WriteLine("Tie");
        }
    }

    private static bool Victory(string[] grid)
    {
        if (grid[0] == grid[1] && grid[1] == grid[2])
        {
            return true;
        }
        if (grid[3] == grid[4] && grid[4] == grid[5])
        {
            return true;
        }
        if (grid[6] == grid[7] && grid[7] == grid[8])
        {
            return true;
        }
        if (grid[0] == grid[3] && grid[3] == grid[6])
        {
            return true;
        }
        if (grid[1] == grid[4] && grid[4] == grid[7])
        {
            return true;
        }
        if (grid[2] == grid[5] && grid[5] == grid[8])
        {
            return true;
        }
        if (grid[0] == grid[4] && grid[4] == grid[8])
        {
            return true;
        }
        if (grid[2] == grid[4] && grid[4] == grid[6])
        {
            return true;
        }
        return false;
    }

    private static void PrintGrid(string[] grid)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(grid[i * 3 + j] + "|");
            }
            Console.WriteLine();
            Console.WriteLine("------");
        }
    }
}
