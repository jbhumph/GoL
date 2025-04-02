namespace GoL.Models;

public class Game
{
    private bool[,] _grid;
    public int Rows { get; set; }
    public int Columns { get; set; }

    public Game(int rows, int columns)
    {
        // Constructor
        Rows = rows;
        Columns = columns;
        _grid = new bool[Rows, Columns];
    }

    public void Randomize()
    {
        // randomizes starting cells on the grid
    }

    public void Step()
    {
        // steps through to next frame of progression
    }

    public int CountNeighbors(int row, int column)
    {
        // counts neighbors of passed grid cell
        return 0;
    }
    
}