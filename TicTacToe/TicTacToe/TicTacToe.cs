namespace TicTacToe;

public class TicTacToe(Player playerOne, Player playerTwo) : ITicTacToe
{
    private Player CurrentPlayer { get; set; } = playerOne;
    private Player PlayerOne { get; } = playerOne;
    private Player PlayerTwo { get; } = playerTwo;

    public void SetUp()
    {
        Console.WriteLine("Hello, This is my Tic Tac Toe game");

        Console.WriteLine("What is your name?...(p1)");
        PlayerOne.Name = Console.ReadLine();

        Console.WriteLine("Now to the piece selection, X or O?");

        PieceSelect();

        Console.WriteLine("What is your name?...(p2)");
        PlayerTwo.Name = Console.ReadLine();

        PlayerTwo.Piece = PlayerOne.Piece == "X" ? "O" : "X";

        Console.WriteLine("Let's begin the match: ");
    }

    public void GameLoop()
    {
        var gameEndCondition = false;
        do
        {
            Console.WriteLine(CurrentPlayer.Name + " is up");
            Console.WriteLine(CurrentPlayer.Name + " place " + CurrentPlayer.Piece + " anywhere within the board");
            Board.Print(Board.Tiles ?? []);
            var tileOnBoardSelected = int.Parse(Console.ReadLine() ?? string.Empty) - 1;
            Board.PlacePiece(tileOnBoardSelected, CurrentPlayer);

            var win = GameEnd.WinCheck(Board.Tiles ?? [], CurrentPlayer);
            var draw = GameEnd.DrawCheck(Board.Tiles ?? []);

            if (win)
            {
                Console.WriteLine("Congratulations, " + CurrentPlayer.Name + " have won the game!");
                Board.Print(Board.Tiles ?? []);
                gameEndCondition = true;
            }
            else if (draw)
            {
                Console.WriteLine("It's a draw no spaces left to place and not three in a row");
                Board.Print(Board.Tiles ?? []);
                gameEndCondition = true;
            }

            SwitchPlayer();
        } while (!gameEndCondition);
    }

    private void PieceSelect()
    {
        do
        {
            var pieceSelect = Console.ReadLine();

            if (pieceSelect != "x" && pieceSelect != "X" && pieceSelect != "o" && pieceSelect != "O")
                Console.WriteLine("Please Choose what piece to play as, either X or O");
            else if ("X".Equals(pieceSelect, StringComparison.CurrentCultureIgnoreCase))
                CurrentPlayer.Piece = "X";
            else
                CurrentPlayer.Piece = "O";
        } while (CurrentPlayer.Piece != "X" && CurrentPlayer.Piece != "O");
    }

    private void SwitchPlayer()
    {
        CurrentPlayer = CurrentPlayer == PlayerOne ? PlayerTwo : PlayerOne;
    }
}