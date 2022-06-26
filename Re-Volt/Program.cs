using System;
using System.Linq;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numCommands = int.Parse(Console.ReadLine());
            char[][] matrix = new char[num] [];
            int playerRow = 0;
            int playerCol = 0;
            bool isValid = true;
            int counter = 0;
            for (int row = 0; row < num; row++)
            {
                
                char[] input = Console.ReadLine().ToCharArray();
                matrix[row] = input;
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                } 
               
            }
            for (int i = 0; i < numCommands; i++)
            {
                counter++;
                string command = Console.ReadLine();

                if (command == "up")
                {
                    matrix[playerRow][playerCol] = '-';
                    playerRow--;
                    if (playerRow < 0)
                    {
                        playerRow = num - 1;
                    }
                    if (matrix[playerRow][playerCol] == 'T')
                    {
                        playerRow++;

                    }
                    else if (matrix[playerRow][playerCol] == 'B')
                    {
                        playerRow--;
                    }
                    else if (matrix[playerRow][playerCol] == 'F')
                    {
                        isValid = false;
                       
                        break;
                    }
                    if (playerRow < 0)
                    {
                        playerRow = num - 1;
                        matrix[playerRow][playerCol] = 'f';
                    }

                }

                else if (command == "down")
                {
                    matrix[playerRow][ playerCol] = '-';
                    playerRow++;
                    if (playerRow > num - 1)
                    {

                        playerRow = 0;
                    }
                    if (matrix[playerRow][playerCol] == 'T')
                    {
                        playerRow--;

                    }
                    else if (matrix[playerRow][playerCol] == 'B')
                    {
                        playerRow++;
                    }
                    else if (matrix[playerRow][playerCol] == 'F')
                    {
                        isValid = false;
                       
                        break;
                    }
                    if (playerRow > num - 1)
                    {
                        playerRow = 0;
                        matrix[playerRow][playerCol] = 'f';
                    }
                }
                else if (command == "left")
                {
                    matrix[playerRow][playerCol] = '-';
                    playerCol--;
                    if (playerCol < 0)
                    {
                        playerCol = matrix[playerRow].Length - 1;
                    }
                    if (matrix[playerRow][playerCol] == 'T')
                    {
                        playerCol++;

                    }
                    else if (matrix[playerRow][playerCol] == 'B')
                    {
                        playerCol--;
                    }
                    else if (matrix[playerRow][playerCol] == 'F')
                    {
                        isValid = false;
                       
                        break;
                    }
                    if (playerCol < 0)
                    {
                        playerCol = matrix[playerRow].Length - 1;
                        matrix[playerRow][playerCol] = 'f';
                    }

                }
                else if (command == "right")
                {
                    matrix[playerRow][playerCol] = '-';
                    playerCol++;
                    if (playerCol > matrix[playerRow].Length - 1)
                    {

                        playerCol = 0;
                    }
                    if (matrix[playerRow][playerCol] == 'T')
                    {
                        playerCol--;

                    }
                    else if (matrix[playerRow][playerCol] == 'B')
                    {
                        playerCol++;
                    }
                    else if (matrix[playerRow][playerCol] == 'F')
                    {
                        isValid = false;
                        
                        break;
                    }
                    if (playerCol > matrix[playerRow].Length - 1)
                    {
                        playerCol = 0;
                        matrix[playerRow][playerCol] = 'f';
                    }
                }
            }

            if (isValid)
            {
                matrix[playerRow][playerCol] = 'f';
                Console.WriteLine("Player lost!");
            }
            else if (!isValid)
            {
                matrix[playerRow][playerCol] = 'f';
                Console.WriteLine("Player won!");
            }
            for (int i = 0; i < num; i++)
            {
                Console.Write(matrix[i]);
                Console.WriteLine();
             
            }
        }
    }
}
