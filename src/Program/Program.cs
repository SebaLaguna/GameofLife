using System;

class Program
{
    static void Main(string[] args)
    {

        string filePath = "../../assets/board.txt";

        GameOfLife game = new GameOfLife(filePath);

        game.RunGameLoop();

        Console.WriteLine ("Aqui esta su juego, vea procrear a las celulas ");
    }
}
