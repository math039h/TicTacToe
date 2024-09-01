namespace TicTacToe;

public static class GameEnd
{
    public static bool WinCheck(string?[] tiles, Player player)
    {
        var winCombinations = new string[8] { "123", "456", "789", "147", "258", "369", "159", "357" };

        foreach (var winCombination in winCombinations)
        {
            var tile1 = int.Parse(winCombination.Substring(0, 1)) - 1;
            var tile2 = int.Parse(winCombination.Substring(1, 1)) - 1;
            var tile3 = int.Parse(winCombination.Substring(2, 1)) - 1;
            if ((tiles[tile1] == "X" || tiles[tile1] == "O") && 
                (tiles[tile1] == tiles[tile2] && tiles[tile2] == tiles[tile3]) && 
                (tiles[tile1] != string.Empty))
            {
                return (true);
            }
        }

        return (false);
    }

    public static bool DrawCheck(string?[] tiles)
    {
        var i = 0;
        foreach (var tile in tiles)
        {
            if (tile == "X" || tile == "O")
                i++;
        }

        if (i == 9)
            return (true);

        return false;
    }
}