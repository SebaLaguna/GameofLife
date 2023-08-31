using System;

public class GameBoard
{
    private bool[,] cells;

    public GameBoard(bool[,] initialCells)
    {
        cells = initialCells;
    }

    public int GetWidth()
    {
        return cells.GetLength(0);
    }

    public int GetHeight()
    {
        return cells.GetLength(1);
    }

    public bool IsCellAlive(int x, int y)
    {
        if (x < 0 || x >= GetWidth() || y < 0 || y >= GetHeight())
        {
            return false;
        }
        return cells[x, y];
    }

    public void CalculateNextGeneration()
    {
        int width = cells.GetLength(0);
        int height = cells.GetLength(1);
        bool[,] cloneboard = new bool[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                int aliveNeighbors = CountAliveNeighbors(x, y);

                if (cells[x, y])
                {
                    // Celula viva
                    if (aliveNeighbors < 2)
                    {
                        // Muere por baja población
                        cloneboard[x, y] = false;
                    }
                    else if (aliveNeighbors > 3)
                    {
                        // Muere por sobrepoblación
                        cloneboard[x, y] = false;
                    }
                    else
                    {
                        // Sobrevive a la siguiente generación
                        cloneboard[x, y] = true;
                    }
                }
                else
                {
                    // Celula muerta
                    if (aliveNeighbors == 3)
                    {
                        // Nace por reproducción
                        cloneboard[x, y] = true;
                    }
                    else
                    {
                        // Permanece muerta
                        cloneboard[x, y] = false;
                    }
                }
            }
        }
        cells = cloneboard;
    }

    private int CountAliveNeighbors(int x, int y)
    {
        int count = 0;
        for (int i = x - 1; i <= x + 1; i++)
        {
            for (int j = y - 1; j <= y + 1; j++)
            {
                if (i >= 0 && i < GetWidth() && j >= 0 && j < GetHeight() && !(i == x && j == y) && cells[i, j])
                {
                    count++;
                }
            }
        }
        return count;
    }
}

