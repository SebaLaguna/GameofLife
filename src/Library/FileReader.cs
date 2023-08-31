using System;
using System.IO;

public class FileReader
{
    public static GameBoard LoadGameBoard(string filePath)
    {
        string content = File.ReadAllText(filePath);
        string[] contentLines = content.Split('\n');
        bool[,] board = new bool[contentLines.Length, contentLines[0].Length];

        for (int y = 0; y < contentLines.Length; y++)
        {
            for (int x = 0; x < contentLines[y].Length; x++)
            {
                if (contentLines[y][x] == '1')
                {
                    board[y, x] = true;
                }
            }
        }

        return new GameBoard(board);
    }
}



