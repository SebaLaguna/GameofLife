using System;
using System.Text;

class ConsolePrinter
{
    public static void PrintGameBoard(GameBoard gameBoard)
    {
        int height = gameBoard.GetHeight();
        int width = gameBoard.GetWidth();

        StringBuilder s = new StringBuilder();
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (gameBoard.IsCellAlive(x, y))
                {
                    s.Append("|X|");
                }
                else
                {
                    s.Append("___");
                }
            }
            s.Append("\n");
        }

        Console.SetCursorPosition(0, 0);
        Console.Write(s.ToString());
    }
}
