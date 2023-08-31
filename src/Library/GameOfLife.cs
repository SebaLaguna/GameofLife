using System;
using System.Threading;

public class GameOfLife
{
    private GameBoard gameBoard;
    
    public GameOfLife(string filePath)
    {
        gameBoard = FileReader.LoadGameBoard(filePath);
    }
    
    public void RunGameLoop()
    {
        Console.WriteLine("¡Aquí está su juego, vea procrear a las células!");
        
        while (true)
        {
            Console.Clear();
            ConsolePrinter.PrintGameBoard(gameBoard);
            
            gameBoard.CalculateNextGeneration();
            Thread.Sleep(300);
        }
    }
}
