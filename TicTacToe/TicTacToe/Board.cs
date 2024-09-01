namespace TicTacToe;

public static class Board
{
    public static string[]? Tiles { get; }

    static Board()
    {
        Tiles = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];
    }

    public static void PlacePiece(int tileSelected, Player currentPlayer)
    {
        try
        {
            if (Tiles?[tileSelected] == "X" || Tiles?[tileSelected] == "O")
            {
                Console.WriteLine("The tile is already occupied, please select an empty tile");
                PlacePiece(int.Parse(Console.ReadLine() ?? string.Empty) - 1, currentPlayer);
            }
            else
            {
                if (Tiles != null)
                {
                    Tiles[tileSelected] = currentPlayer.Piece ?? string.Empty;
                }
            }
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("The number was out of the accepted range for the board." +
                              "The accepted range is from 1 to 9" +
                              "Please pick a valid number");
            PlacePiece(tileSelected, currentPlayer);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public static void Print(string?[] tiles)
    {
        Console.WriteLine("     |     |      \n" +
                          "  {0}  |  {1}  |  {2}\n" +
                          "_____|_____|_____\n" +
                          "     |     |      \n" +
                          "  {3}  |  {4}  |  {5}\n" +
                          "_____|_____|_____\n" +
                          "     |     |      \n" +
                          "  {6}  |  {7}  |  {8}\n" +
                          "     |     |      ", tiles[0], tiles[1], tiles[2], tiles[3], tiles[4], tiles[5], tiles[6], tiles[7], tiles[8]);
    }
}