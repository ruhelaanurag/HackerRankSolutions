using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class MazeBacktracking
    {
        public static void Main()
        {
            int[,] maze = new int[4, 4] {
                { 1, 0, 0, 0 },
                { 1, 1, 0, 1 },
                { 0, 1, 0, 0 },
                { 1, 1, 1, 1 }};
            Solution(maze);
            //printSolution(maze);
        }
        private static bool Solution(int[,] initialMaze) //Method to look for solution in the maze
        {
            int[,] sol = new int[4, 4];
            //int zero = recurse(sol);
            if (!recurse(initialMaze, sol, 0, 0))//If recursion returns false, there is no solution available.
            {
                Console.WriteLine("No Solution");
                //printSolution(sol);
                return false;
            }
            printSolution(sol);
            return true;
        }

        private static bool recurse(int[,] initialMaze, int[,] outputMaze, int posX, int posY) //Recursive method to find the path in maze.
        {
            //If X and Y are inside maze and X,Y are the last element of the maze. Return true.
            if (posX == initialMaze.GetLength(0)-1 && posY == initialMaze.GetLength(1) - 1 && initialMaze[posX,posY] == 1)
            {
                outputMaze[posX,posY] = 1;
                return true;
            }

            if (IsSafe(initialMaze, posX, posY)) //if X,Y are safe to visit. (safe: within the bonds of array and is a valid path (1))
            {
                outputMaze[posX,posY] = 1; //mark the path as visited in the solution.
                if (recurse(initialMaze, outputMaze, posX + 1, posY)) return true; //Move ahead.
                if (recurse(initialMaze, outputMaze, posX, posY+1)) return true; //Move below.

                outputMaze[posX, posY] = 0;//backtrack; if the the new X and Y are not safe to visit.
                return false;
            }
            return false;
        }

        private static bool IsSafe(int[,] initialMaze, int X, int Y) //check if X and Y are within the bounds and its a valid path.
        {
            if ((X >= 0 && X < initialMaze.GetLength(0)) && (Y >= 0 && Y < initialMaze.GetLength(1)) && initialMaze[X, Y] == 1) return true;
            return false;
        }

        private static void printSolution(int [,] sol) //print the input matrix.
        {
            for (int i = 0; i < sol.GetLength(0); i++)
            {
                for (int j = 0; j < sol.GetLength(1); j++)
                    Console.Write(sol[i,j]);
                Console.WriteLine();
            }
        }
    }
}
