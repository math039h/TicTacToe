using TicTacToe;

var playerOne = new Player();
var playerTwo = new Player();

var ticTacToe = new TicTacToe.TicTacToe(playerOne, playerTwo);

ticTacToe.SetUp();

ticTacToe.GameLoop();

// Stop application from shutting down right away
Console.WriteLine("Press any key to exit the application");
Console.ReadLine();